using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using SuaImpressoraAppPedido.Model;
using SuaImpressoraAppPedido.Enum;
using System.Data.Entity;
using iTextSharp.text;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;

namespace SuaImpressoraAppPedido.View
{
    public partial class FormPedido : Form
    {
        public ListView LwP { get { return LwProdutos; } }
        private string op { get; set; }
        public FormPedido()
        {
            InitializeComponent();
        }
        private void FormPedido_Load(object sender, EventArgs e)
        {
            AdicionarDadosNaListaPedidos();
        }
        private void AdicionarDadosNaListaPedidos()
        {
            using (EfContext contexto = new EfContext())
            {
                LwPedidos.Items.Clear();
                foreach (Pedido pedido in contexto.Pedidos)
                {
                    String[] items = new String[6];

                    items[0] = pedido.Id.ToString();
                    items[1] = pedido.DataDoPedido;
                    items[2] = pedido.DataDeEntrega;
                    items[3] = pedido.Cliente;
                    items[4] = pedido.Whatsapp;
                    items[5] = "R$ " + pedido.Total.ToString("N2");

                    ListViewItem listViewItem = new ListViewItem(items);
                    LwPedidos.Items.Add(listViewItem);
                }
            }
        }

        private void TbPesquisarPedido_TextChanged(object sender, EventArgs e)
        {
            string vp = TbPesquisarPedido.Text;
            using (EfContext contexto = new EfContext())
            {
                LwPedidos.Items.Clear();
                List<Pedido> pedidos = contexto.Pedidos.Where(p => p.Cliente.Contains(vp) || p.Cliente.ToLower().Contains(vp) || p.Cliente.ToUpper().Contains(vp)).ToList();
                foreach (Pedido pedido in pedidos)
                {
                    String[] items = new String[6];

                    items[0] = pedido.Id.ToString();
                    items[1] = pedido.DataDoPedido;
                    items[2] = pedido.DataDeEntrega;
                    items[3] = pedido.Cliente;
                    items[4] = pedido.Whatsapp;
                    items[5] = "R$ " + pedido.Total.ToString("N2");

                    ListViewItem listViewItem = new ListViewItem(items);
                    LwPedidos.Items.Add(listViewItem);
                }
            }
        }

        public void AtualizarTotal()
        {
            double total = 0.00;
            double cupom = !String.IsNullOrEmpty(TbCupom.Text) ? double.Parse(TbCupom.Text) : 0.00;
            double frete = !String.IsNullOrEmpty(TbFrete.Text) ? double.Parse(TbFrete.Text) : 0.00;

            foreach (ListViewItem item in LwProdutos.Items)
            {
                total += double.Parse(item.SubItems[3].Text.Split(" ")[1]);
            }

            total -= (cupom / 100) * total;
            total += frete;
            TbTotal.Text = total.ToString("N2");
        }

        private void BtAdicionarProduto_Click(object sender, EventArgs e)
        {
            FormProduto fp = new FormProduto(this);
            fp.ShowDialog();
        }

        private void BtExcluirProduto_Click(object sender, EventArgs e)
        {
            LwProdutos.Items.RemoveAt(LwProdutos.SelectedIndices[0]);
            AtualizarTotal();
        }

        private void TbFrete_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(TbFrete.Text, @"[0-9]") || TbFrete.Text.Trim().Equals("")) 
            {
                AtualizarTotal();
            } 
        }

        private void TbCupom_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(TbCupom.Text, @"[0-9]") || TbCupom.Text.Trim().Equals(""))
            {
                AtualizarTotal();
            }
        }

        private void AdicionarPedido()
        {
            List<PedidoItem> pedidoItems = new List<PedidoItem>();
            string tipoPagamentoStr = GbTipoPagamento.Controls.OfType<RadioButton>().Single(r => r.Checked).Text;
            int tipoPagemento = tipoPagamentoStr.Equals("PIX") ? 1 : tipoPagamentoStr.Equals("DINHEIRO") ? 2 : 3;

            foreach (ListViewItem item in LwProdutos.Items)
            {
                pedidoItems.Add(new PedidoItem
                {
                    Descricao = item.SubItems[0].Text,
                    PrecoUnitario = double.Parse(item.SubItems[1].Text.Split(" ")[1]),
                    Quantidade = int.Parse(item.SubItems[2].Text)
                });
            }

            using (EfContext contexto = new EfContext())
            {
                Pedido pedido = new Pedido()
                {
                    DataDeEntrega = MkDataEntrega.Text,
                    DataDoPedido = MkDataPedido.Text,
                    Cliente = TbCliente.Text.Trim(),
                    Whatsapp = MkWhatsapp.Text,
                    Instagram = TbInstagram.Text.Trim(),
                    Email = TbEmail.Text.Trim(),
                    EnderecoDeEntrega = RtbEnderecoDeEntrega.Text.Trim(),
                    PontoDeReferencia = TbPontoDeReferencia.Text.Trim(),
                    Observacao = RtbObservacaoDoPedido.Text.Trim(),
                    Cupom = !String.IsNullOrEmpty(TbCupom.Text) ? double.Parse(TbCupom.Text) : 0.00,
                    Frete = !String.IsNullOrEmpty(TbFrete.Text) ? double.Parse(TbFrete.Text) : 0.00,
                    Total = !String.IsNullOrEmpty(TbTotal.Text) ? double.Parse(TbTotal.Text) : 0.00,
                    Troco = !String.IsNullOrEmpty(TbTroco.Text) ? double.Parse(TbTroco.Text) : 0.00,
                    TipoPagamento = (TipoPagamento)tipoPagemento,
                    PedidoItems = pedidoItems
                };

                contexto.Pedidos.Add(pedido);

                try
                {
                    contexto.SaveChanges();
                    LimparCampos();
                    DesativarCamposParaAdicionarOuEditar();
                    DesativarBotaoSalvarCancelarEAtivarBotaoAdicionarEditarExcluirGerarPdf();
                    MessageBox.Show("Pedido adicionado com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    this.op = "";
                    AdicionarDadosNaListaPedidos();
                }
            }
        }

        private void EditarPedido()
        {
            long id = long.Parse(TbNumeroPedido.Text);
            string tipoPagamentoStr = GbTipoPagamento.Controls.OfType<RadioButton>().Single(r => r.Checked).Text;
            int tipoPagemento = tipoPagamentoStr.Equals("PIX") ? 1 : tipoPagamentoStr.Equals("DINHEIRO") ? 2 : 3;

            using (EfContext contexto = new EfContext())
            {
                List<PedidoItem> pedidoItems = contexto.PedidoItems.Where(p => p.PedidoId == id).ToList();

                foreach (PedidoItem item in pedidoItems)
                {
                    contexto.PedidoItems.Remove(item);
                }

                foreach (ListViewItem item in LwProdutos.Items)
                {
                    pedidoItems.Add(new PedidoItem
                    {
                        Descricao = item.SubItems[0].Text,
                        PrecoUnitario = double.Parse(item.SubItems[1].Text.Split(" ")[1]),
                        Quantidade = int.Parse(item.SubItems[2].Text)
                    });
                }

                Pedido pedido = contexto.Pedidos.Single(p => p.Id == id);
                pedido.DataDeEntrega = MkDataEntrega.Text;
                pedido.DataDoPedido = MkDataPedido.Text;
                pedido.Cliente = TbCliente.Text.Trim();
                pedido.Whatsapp = MkWhatsapp.Text;
                pedido.Instagram = TbInstagram.Text.Trim();
                pedido.Email = TbEmail.Text.Trim();
                pedido.EnderecoDeEntrega = RtbEnderecoDeEntrega.Text.Trim();
                pedido.PontoDeReferencia = TbPontoDeReferencia.Text.Trim();
                pedido.Observacao = RtbObservacaoDoPedido.Text.Trim();
                pedido.Cupom = !String.IsNullOrEmpty(TbCupom.Text) ? double.Parse(TbCupom.Text) : 0.00;
                pedido.Frete = !String.IsNullOrEmpty(TbFrete.Text) ? double.Parse(TbFrete.Text) : 0.00;
                pedido.Total = !String.IsNullOrEmpty(TbTotal.Text) ? double.Parse(TbTotal.Text) : 0.00;
                pedido.Troco = !String.IsNullOrEmpty(TbTroco.Text) ? double.Parse(TbTroco.Text) : 0.00;
                pedido.TipoPagamento = (TipoPagamento)tipoPagemento;
                pedido.PedidoItems = pedidoItems;

                try
                {
                    contexto.SaveChanges();
                    DesativarCamposParaAdicionarOuEditar();
                    DesativarBotaoSalvarCancelarEAtivarBotaoAdicionarEditarExcluirGerarPdf();
                    MessageBox.Show("Pedido atualizado com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    this.op = "";
                    AdicionarDadosNaListaPedidos();
                }
            }
        }

        private void ExcluirPedido()
        {
            DialogResult dialog = MessageBox.Show("Deseja realmente excluir", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                using (EfContext contexto = new EfContext())
                {
                    long id = long.Parse(TbNumeroPedido.Text);
                    Pedido pedido = contexto.Pedidos.Single(p => p.Id == id);
                    List<PedidoItem> pedidoItems = contexto.PedidoItems.Where(p => p.PedidoId == id).ToList();

                    contexto.Pedidos.Remove(pedido);

                    foreach (PedidoItem item in pedidoItems)
                    {
                        contexto.PedidoItems.Remove(item);
                    }

                    try
                    {
                        contexto.SaveChanges();
                        LimparCampos();
                        MessageBox.Show("Pedido excluido com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        AdicionarDadosNaListaPedidos();
                    }
                }
            }
        }

        private void RbDinheiro_CheckedChanged(object sender, EventArgs e)
        {
            TbTroco.Enabled = false;
            TbTroco.Clear();
        }

        private void RbDinheiro_Click(object sender, EventArgs e)
        {
            TbTroco.Enabled = true;
        }

        private void LwPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LwPedidos.SelectedItems.Count > 0)
            {
                LimparCampos();
                long id = long.Parse(LwPedidos.SelectedItems[0].SubItems[0].Text);
                using (EfContext contexto = new EfContext())
                {
                    Pedido pedido = contexto.Pedidos.Single(p => p.Id == id);
                    TbNumeroPedido.Text = id.ToString();
                    MkDataPedido.Text = pedido.DataDoPedido;
                    MkDataEntrega.Text = pedido.DataDeEntrega;
                    TbCliente.Text = pedido.Cliente;
                    MkWhatsapp.Text = pedido.Whatsapp;
                    TbInstagram.Text = pedido.Instagram;
                    TbEmail.Text = pedido.Email;
                    RtbEnderecoDeEntrega.Text = pedido.EnderecoDeEntrega;
                    TbPontoDeReferencia.Text = pedido.PontoDeReferencia;
                    RtbObservacaoDoPedido.Text = pedido.Observacao;

                    List<PedidoItem> pedidoItems = contexto.PedidoItems.Where(p => p.PedidoId == id).ToList();

                    foreach (PedidoItem item in pedidoItems)
                    {
                        String[] items = new String[4];

                        items[0] = item.Descricao;
                        items[1] = "R$ " + item.PrecoUnitario.ToString("N2");
                        items[2] = item.Quantidade.ToString();
                        items[3] = "R$ " + (double.Parse(item.PrecoUnitario.ToString()) * int.Parse(item.Quantidade.ToString())).ToString("N2");

                        ListViewItem listViewItem = new ListViewItem(items);
                        LwProdutos.Items.Add(listViewItem);
                    }

                    TbCupom.Text = pedido.Cupom.ToString("N2");
                    TbFrete.Text = pedido.Frete.ToString("N2");
                    TbTotal.Text = pedido.Total.ToString("N2");

                    string tipoPagamento = pedido.TipoPagamento.ToString();
                    if (tipoPagamento == "PIX")
                    {
                        RbPix.Checked = true;
                    }
                    else if (tipoPagamento == "DINHEIRO")
                    {
                        RbDinheiro.Checked = true;
                    }
                    else if (tipoPagamento == "CARTAO")
                    {
                        RbCartao.Checked = true;
                    }

                    TbTroco.Text = pedido.Troco.ToString("N2");
                }
            }
        }

        private void BtExcluirPedido_Click(object sender, EventArgs e)
        {
            if (TbNumeroPedido.Text.Length > 0)
            {
                ExcluirPedido();
            }
            else
            {
                MessageBox.Show("Selecione o pedido que deseja excluir", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtAdicionarPedido_Click(object sender, EventArgs e)
        {
            this.op = "adicionar";
            LimparCampos();
            AtivarCamposParaAdicionarOuEditar();
            AtivarBotaoSalvarCancelarEDesativarBotaoAdicionarEditarExcluirGerarPdf();
        }

        private void BtEditar_Click(object sender, EventArgs e)
        {
            if (TbNumeroPedido.Text.Length > 0)
            {
                this.op = "editar";
                AtivarCamposParaAdicionarOuEditar();
                AtivarBotaoSalvarCancelarEDesativarBotaoAdicionarEditarExcluirGerarPdf();
            } 
            else
            {
                MessageBox.Show("Selecione o pedido que deseja editar", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtSalvar_Click(object sender, EventArgs e)
        {
            if (this.op.Equals("adicionar"))
            {
                AdicionarPedido();
            }
            else if (this.op.Equals("editar"))
            {
                EditarPedido();
            }
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            this.op = "";
            LimparCampos();
            DesativarBotaoSalvarCancelarEAtivarBotaoAdicionarEditarExcluirGerarPdf();
            DesativarCamposParaAdicionarOuEditar();
            AdicionarDadosNaListaPedidos();
        }

        private void BtGerarPdf_Click(object sender, EventArgs e)
        {
            EncodingProvider ep = CodePagesEncodingProvider.Instance;
            Encoding.RegisterProvider(ep);

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Pdf File |*.pdf";
           
            string htmlStr = Properties.Resources.relatorio.ToString();
            htmlStr = htmlStr.Replace("@NUMEROPEDIDO", TbNumeroPedido.Text);
            htmlStr = htmlStr.Replace("@DATADOPEDIDO", MkDataPedido.Text);
            htmlStr = htmlStr.Replace("@DATADEENTREGA", MkDataEntrega.Text);
            htmlStr = htmlStr.Replace("@CLIENTE", TbCliente.Text);
            htmlStr = htmlStr.Replace("@WHATSAPP", MkWhatsapp.Text);
            htmlStr = htmlStr.Replace("@INSTAGRAM", TbInstagram.Text);
            htmlStr = htmlStr.Replace("@EMAIL", TbEmail.Text);
            htmlStr = htmlStr.Replace("@ENDERECODEENTREGA", RtbEnderecoDeEntrega.Text);
            htmlStr = htmlStr.Replace("@PONTODEREFERENCIA", TbPontoDeReferencia.Text);

            string produtos = "";
            foreach (ListViewItem item in LwProdutos.Items)
            {
                produtos += "<tr style=\"height: 30px\">";
                produtos += "<td align=\"center\">" + item.SubItems[0].Text + "</td>";
                produtos += "<td align=\"center\">" + item.SubItems[1].Text + "</td>";
                produtos += "<td align=\"center\">" + item.SubItems[2].Text + "</td>";
                produtos += "<td align=\"center\">" + item.SubItems[3].Text + "</td>";
                produtos += "</tr>";
            }

            string cupom = !String.IsNullOrEmpty(TbCupom.Text) ? TbCupom.Text : "0,00";
            string frete = !String.IsNullOrEmpty(TbFrete.Text) ? TbFrete.Text : "0,00";
            string total = !String.IsNullOrEmpty(TbTotal.Text) ? TbTotal.Text : "0,00";
            string troco = !String.IsNullOrEmpty(TbTroco.Text) ? TbTroco.Text : "0,00";

            htmlStr = htmlStr.Replace("@PRODUTOS", produtos);
            htmlStr = htmlStr.Replace("@CUPOM", "R$ " + cupom);
            htmlStr = htmlStr.Replace("@FRETE", "R$ " + frete);
            htmlStr = htmlStr.Replace("@TOTAL", "R$ " + total);

            htmlStr = htmlStr.Replace("@OBSERVACAODOPEDIDO", RtbObservacaoDoPedido.Text);
            htmlStr = htmlStr.Replace("@TIPOPAGAMENTO", GbTipoPagamento.Controls.OfType<RadioButton>().Single(r => r.Checked).Text);
            htmlStr = htmlStr.Replace("@TROCO", "R$ " + troco);

            if (sfd.ShowDialog().Equals(DialogResult.OK))
            {
                try
                {
                    using (FileStream arquivo = new FileStream(sfd.FileName, FileMode.Create))
                    {
                        Document doc = new Document(PageSize.A4, 25, 25, 25, 25);
                        PdfWriter wri = PdfWriter.GetInstance(doc, arquivo);

                        doc.Open();

                        using (StringReader sr = new StringReader(htmlStr))
                        {
                            XMLWorkerHelper.GetInstance().ParseXHtml(wri, doc, sr);
                        }

                        doc.Close();
                    }
                    MessageBox.Show("PDF exportado com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } 
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AtivarBotaoSalvarCancelarEDesativarBotaoAdicionarEditarExcluirGerarPdf()
        {
            BtSalvar.Enabled = true;
            BtCancelar.Enabled = true;
            BtAdicionarPedido.Enabled = false;
            BtEditar.Enabled = false;
            BtExcluirPedido.Enabled = false;
            BtGerarPdf.Enabled = false;
        }

        private void DesativarBotaoSalvarCancelarEAtivarBotaoAdicionarEditarExcluirGerarPdf()
        {
            BtSalvar.Enabled = false;
            BtCancelar.Enabled = false;
            BtAdicionarPedido.Enabled = true;
            BtEditar.Enabled = true;
            BtExcluirPedido.Enabled = true;
            BtGerarPdf.Enabled = true;
        }

        private void AtivarCamposParaAdicionarOuEditar()
        {
            MkDataPedido.Enabled = true;
            MkDataEntrega.Enabled = true;
            TbCliente.Enabled = true;
            MkWhatsapp.Enabled = true;
            TbInstagram.Enabled = true;
            TbEmail.Enabled = true;
            RtbEnderecoDeEntrega.Enabled = true;
            TbPontoDeReferencia.Enabled = true;
            RtbObservacaoDoPedido.Enabled = true;
            BtAdicionarProduto.Enabled = true;
            BtExcluirProduto.Enabled = true;
            LwProdutos.Enabled = true;
            TbCupom.Enabled = true;
            TbFrete.Enabled = true;
            RbPix.Enabled = true;
            RbDinheiro.Enabled = true;
            RbCartao.Enabled = true;
        }

        private void DesativarCamposParaAdicionarOuEditar()
        {
            MkDataPedido.Enabled = false;
            MkDataEntrega.Enabled = false;
            TbCliente.Enabled = false;
            MkWhatsapp.Enabled = false;
            TbInstagram.Enabled = false;
            TbEmail.Enabled = false;
            RtbEnderecoDeEntrega.Enabled = false;
            TbPontoDeReferencia.Enabled = false;
            RtbObservacaoDoPedido.Enabled = false;
            BtAdicionarProduto.Enabled = false;
            BtExcluirProduto.Enabled = false;
            LwProdutos.Enabled = false;
            TbCupom.Enabled = false;
            TbFrete.Enabled = false;
            RbPix.Enabled = false;
            RbDinheiro.Enabled = false;
            RbCartao.Enabled = false;
        }

        private void LimparCampos()
        {
            TbNumeroPedido.Clear();
            MkDataPedido.Clear();
            MkDataEntrega.Clear();
            TbCliente.Clear();
            MkWhatsapp.Clear();
            TbInstagram.Clear();
            TbEmail.Clear();
            RtbEnderecoDeEntrega.Clear();
            TbPontoDeReferencia.Clear();
            RtbObservacaoDoPedido.Clear();
            LwProdutos.Items.Clear();
            TbCupom.Clear();
            TbFrete.Clear();
            TbTotal.Clear();
            RbPix.Checked = true;
            RbDinheiro.Checked = false;
            RbCartao.Checked = false;
            TbTroco.Clear();
        }
    }
}
