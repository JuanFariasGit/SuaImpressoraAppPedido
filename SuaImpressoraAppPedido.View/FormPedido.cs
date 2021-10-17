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

namespace SuaImpressoraAppPedido.View
{
    public partial class FormPedido : Form
    {
        public ListView LwP { get { return LwProdutos; } }
        public TextBox TbS01 { get { return TbTotal; } }
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
        public void AtualizarTotal()
        {
            double total = 0.00;
            double cupom = !String.IsNullOrEmpty(TbCupom.Text) ? double.Parse(TbCupom.Text) : 0.00;
            double frete = !String.IsNullOrEmpty(TbFrete.Text) ? double.Parse(TbFrete.Text) : 0.00;

            foreach (ListViewItem item in LwProdutos.Items)
            {
                total += double.Parse(item.SubItems[3].Text.Split(" ")[1]);
            }

            total += frete;
            total -= (cupom / 100) * total;
            TbTotal.Text = total.ToString("N2");
        }

        private void BtAdicionar_Click(object sender, EventArgs e)
        {
            FormProduto fp = new FormProduto(this);
            fp.ShowDialog();
        }

        private void BtRemover_Click(object sender, EventArgs e)
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

        private void BtSalvar_Click(object sender, EventArgs e)
        {
            List<PedidoItem> pedidoItems = new List<PedidoItem>();
            string tipoPagamentoStr = GbTipoPagamento.Controls.OfType<RadioButton>().SingleOrDefault(r => r.Checked).Text;
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
                    Cliente = TbCliente.Text,
                    Whatsapp = MkWhatsapp.Text,
                    Instagram = TbInstagram.Text,
                    Email = TbEmail.Text,
                    EnderecoDeEntrega = RtbEnderecoDeEntrega.Text,
                    PontoDeReferencia = TbPontoDeReferencia.Text,
                    Observacao = RtbObservacaoDoPedido.Text,
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
                    MessageBox.Show("Pedido adicionado com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                long id = int.Parse(LwPedidos.SelectedItems[0].SubItems[0].Text);
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

        private void BtExcluir_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Deseja realmente excluir", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes) {
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
            RbPix.Checked = false;
            RbDinheiro.Checked = false;
            RbCartao.Checked = false;
            TbTroco.Clear();
        }
    }
}
