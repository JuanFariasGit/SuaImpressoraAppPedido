
namespace SuaImpressoraAppPedido.View
{
    partial class FormPedido
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.MkDataPedido = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MkDataEntrega = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TbCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MkWhatsapp = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TbInstagram = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.RtbEnderecoDeEntrega = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.RtbObservacaoDoPedido = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TbPontoDeReferencia = new System.Windows.Forms.TextBox();
            this.LwProdutos = new System.Windows.Forms.ListView();
            this.descricao = new System.Windows.Forms.ColumnHeader();
            this.valorUni = new System.Windows.Forms.ColumnHeader();
            this.quantidade = new System.Windows.Forms.ColumnHeader();
            this.subtotal = new System.Windows.Forms.ColumnHeader();
            this.TbEmail = new System.Windows.Forms.TextBox();
            this.BtAdicionarProduto = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.TbTotal = new System.Windows.Forms.TextBox();
            this.BtExcluirProduto = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TbCupom = new System.Windows.Forms.TextBox();
            this.TbFrete = new System.Windows.Forms.TextBox();
            this.RbPix = new System.Windows.Forms.RadioButton();
            this.RbDinheiro = new System.Windows.Forms.RadioButton();
            this.RbCartao = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.TbTroco = new System.Windows.Forms.TextBox();
            this.BtSalvar = new System.Windows.Forms.Button();
            this.TbNumeroPedido = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.GbTipoPagamento = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Lista = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.TbPesquisarPedido = new System.Windows.Forms.TextBox();
            this.LwPedidos = new System.Windows.Forms.ListView();
            this.PedidoNumero = new System.Windows.Forms.ColumnHeader();
            this.DataDoPedido = new System.Windows.Forms.ColumnHeader();
            this.DataDaEntrega = new System.Windows.Forms.ColumnHeader();
            this.Cliente = new System.Windows.Forms.ColumnHeader();
            this.Whatsapp = new System.Windows.Forms.ColumnHeader();
            this.Total = new System.Windows.Forms.ColumnHeader();
            this.Dados = new System.Windows.Forms.TabPage();
            this.BtGerarPdf = new System.Windows.Forms.Button();
            this.BtAdicionarPedido = new System.Windows.Forms.Button();
            this.BtEditar = new System.Windows.Forms.Button();
            this.BtExcluirPedido = new System.Windows.Forms.Button();
            this.BtCancelar = new System.Windows.Forms.Button();
            this.GbTipoPagamento.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Lista.SuspendLayout();
            this.Dados.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "DATA DO PEDIDO:";
            // 
            // MkDataPedido
            // 
            this.MkDataPedido.Enabled = false;
            this.MkDataPedido.Location = new System.Drawing.Point(4, 84);
            this.MkDataPedido.Mask = "00/00/0000";
            this.MkDataPedido.Name = "MkDataPedido";
            this.MkDataPedido.Size = new System.Drawing.Size(100, 23);
            this.MkDataPedido.TabIndex = 1;
            this.MkDataPedido.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "DATA DE ENTREGA:";
            // 
            // MkDataEntrega
            // 
            this.MkDataEntrega.Enabled = false;
            this.MkDataEntrega.Location = new System.Drawing.Point(4, 137);
            this.MkDataEntrega.Mask = "00/00/0000";
            this.MkDataEntrega.Name = "MkDataEntrega";
            this.MkDataEntrega.Size = new System.Drawing.Size(100, 23);
            this.MkDataEntrega.TabIndex = 3;
            this.MkDataEntrega.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "CLIENTE:";
            // 
            // TbCliente
            // 
            this.TbCliente.Enabled = false;
            this.TbCliente.Location = new System.Drawing.Point(4, 186);
            this.TbCliente.Name = "TbCliente";
            this.TbCliente.Size = new System.Drawing.Size(331, 23);
            this.TbCliente.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "WHATSAPP:";
            // 
            // MkWhatsapp
            // 
            this.MkWhatsapp.Enabled = false;
            this.MkWhatsapp.Location = new System.Drawing.Point(4, 236);
            this.MkWhatsapp.Mask = "(00) 9 0000-0000";
            this.MkWhatsapp.Name = "MkWhatsapp";
            this.MkWhatsapp.Size = new System.Drawing.Size(100, 23);
            this.MkWhatsapp.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "INSTAGRAM:";
            // 
            // TbInstagram
            // 
            this.TbInstagram.Enabled = false;
            this.TbInstagram.Location = new System.Drawing.Point(4, 289);
            this.TbInstagram.Name = "TbInstagram";
            this.TbInstagram.Size = new System.Drawing.Size(167, 23);
            this.TbInstagram.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "E-MAIL:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 374);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "ENDEREÇO DE ENTREGA:";
            // 
            // RtbEnderecoDeEntrega
            // 
            this.RtbEnderecoDeEntrega.Enabled = false;
            this.RtbEnderecoDeEntrega.Location = new System.Drawing.Point(4, 396);
            this.RtbEnderecoDeEntrega.Name = "RtbEnderecoDeEntrega";
            this.RtbEnderecoDeEntrega.Size = new System.Drawing.Size(331, 96);
            this.RtbEnderecoDeEntrega.TabIndex = 13;
            this.RtbEnderecoDeEntrega.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(378, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "PONTO DE REFERÊNCIA:";
            // 
            // RtbObservacaoDoPedido
            // 
            this.RtbObservacaoDoPedido.Enabled = false;
            this.RtbObservacaoDoPedido.Location = new System.Drawing.Point(378, 83);
            this.RtbObservacaoDoPedido.Name = "RtbObservacaoDoPedido";
            this.RtbObservacaoDoPedido.Size = new System.Drawing.Size(331, 96);
            this.RtbObservacaoDoPedido.TabIndex = 17;
            this.RtbObservacaoDoPedido.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(378, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "OBSERVAÇÕES DO PEDIDO:";
            // 
            // TbPontoDeReferencia
            // 
            this.TbPontoDeReferencia.Enabled = false;
            this.TbPontoDeReferencia.Location = new System.Drawing.Point(378, 28);
            this.TbPontoDeReferencia.Name = "TbPontoDeReferencia";
            this.TbPontoDeReferencia.Size = new System.Drawing.Size(331, 23);
            this.TbPontoDeReferencia.TabIndex = 15;
            // 
            // LwProdutos
            // 
            this.LwProdutos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.descricao,
            this.valorUni,
            this.quantidade,
            this.subtotal});
            this.LwProdutos.Enabled = false;
            this.LwProdutos.FullRowSelect = true;
            this.LwProdutos.HideSelection = false;
            this.LwProdutos.Location = new System.Drawing.Point(378, 215);
            this.LwProdutos.MultiSelect = false;
            this.LwProdutos.Name = "LwProdutos";
            this.LwProdutos.Size = new System.Drawing.Size(464, 221);
            this.LwProdutos.TabIndex = 20;
            this.LwProdutos.UseCompatibleStateImageBehavior = false;
            this.LwProdutos.View = System.Windows.Forms.View.Details;
            // 
            // descricao
            // 
            this.descricao.Text = "DESCRIÇÃO";
            this.descricao.Width = 200;
            // 
            // valorUni
            // 
            this.valorUni.Text = "VALOR UNI";
            this.valorUni.Width = 100;
            // 
            // quantidade
            // 
            this.quantidade.Text = "QT";
            // 
            // subtotal
            // 
            this.subtotal.Text = "SUBTOTAL";
            this.subtotal.Width = 100;
            // 
            // TbEmail
            // 
            this.TbEmail.Enabled = false;
            this.TbEmail.Location = new System.Drawing.Point(4, 338);
            this.TbEmail.Name = "TbEmail";
            this.TbEmail.Size = new System.Drawing.Size(331, 23);
            this.TbEmail.TabIndex = 11;
            // 
            // BtAdicionarProduto
            // 
            this.BtAdicionarProduto.Enabled = false;
            this.BtAdicionarProduto.Location = new System.Drawing.Point(378, 186);
            this.BtAdicionarProduto.Name = "BtAdicionarProduto";
            this.BtAdicionarProduto.Size = new System.Drawing.Size(86, 23);
            this.BtAdicionarProduto.TabIndex = 18;
            this.BtAdicionarProduto.Text = "ADICIONAR";
            this.BtAdicionarProduto.UseVisualStyleBackColor = true;
            this.BtAdicionarProduto.Click += new System.EventHandler(this.BtAdicionarProduto_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(741, 437);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 15);
            this.label10.TabIndex = 25;
            this.label10.Text = "TOTAL (R$):";
            // 
            // TbTotal
            // 
            this.TbTotal.Enabled = false;
            this.TbTotal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TbTotal.Location = new System.Drawing.Point(743, 455);
            this.TbTotal.Name = "TbTotal";
            this.TbTotal.PlaceholderText = "0,00";
            this.TbTotal.Size = new System.Drawing.Size(100, 32);
            this.TbTotal.TabIndex = 26;
            // 
            // BtExcluirProduto
            // 
            this.BtExcluirProduto.Enabled = false;
            this.BtExcluirProduto.Location = new System.Drawing.Point(470, 186);
            this.BtExcluirProduto.Name = "BtExcluirProduto";
            this.BtExcluirProduto.Size = new System.Drawing.Size(86, 23);
            this.BtExcluirProduto.TabIndex = 19;
            this.BtExcluirProduto.Text = "EXCLUIR";
            this.BtExcluirProduto.UseVisualStyleBackColor = true;
            this.BtExcluirProduto.Click += new System.EventHandler(this.BtExcluirProduto_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(637, 437);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 15);
            this.label11.TabIndex = 23;
            this.label11.Text = "FRETE (R$):";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(531, 437);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 15);
            this.label12.TabIndex = 21;
            this.label12.Text = "CUPOM (%):";
            // 
            // TbCupom
            // 
            this.TbCupom.Enabled = false;
            this.TbCupom.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TbCupom.Location = new System.Drawing.Point(531, 455);
            this.TbCupom.Name = "TbCupom";
            this.TbCupom.PlaceholderText = "0,00";
            this.TbCupom.Size = new System.Drawing.Size(100, 32);
            this.TbCupom.TabIndex = 22;
            this.TbCupom.TextChanged += new System.EventHandler(this.TbCupom_TextChanged);
            // 
            // TbFrete
            // 
            this.TbFrete.Enabled = false;
            this.TbFrete.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TbFrete.Location = new System.Drawing.Point(637, 455);
            this.TbFrete.Name = "TbFrete";
            this.TbFrete.PlaceholderText = "0,00";
            this.TbFrete.Size = new System.Drawing.Size(100, 32);
            this.TbFrete.TabIndex = 24;
            this.TbFrete.TextChanged += new System.EventHandler(this.TbFrete_TextChanged);
            // 
            // RbPix
            // 
            this.RbPix.AutoSize = true;
            this.RbPix.Checked = true;
            this.RbPix.Enabled = false;
            this.RbPix.Location = new System.Drawing.Point(15, 24);
            this.RbPix.Name = "RbPix";
            this.RbPix.Size = new System.Drawing.Size(42, 19);
            this.RbPix.TabIndex = 28;
            this.RbPix.TabStop = true;
            this.RbPix.Text = "PIX";
            this.RbPix.UseVisualStyleBackColor = true;
            // 
            // RbDinheiro
            // 
            this.RbDinheiro.AutoSize = true;
            this.RbDinheiro.Enabled = false;
            this.RbDinheiro.Location = new System.Drawing.Point(15, 49);
            this.RbDinheiro.Name = "RbDinheiro";
            this.RbDinheiro.Size = new System.Drawing.Size(79, 19);
            this.RbDinheiro.TabIndex = 29;
            this.RbDinheiro.Text = "DINHEIRO";
            this.RbDinheiro.UseVisualStyleBackColor = true;
            this.RbDinheiro.CheckedChanged += new System.EventHandler(this.RbDinheiro_CheckedChanged);
            this.RbDinheiro.Click += new System.EventHandler(this.RbDinheiro_Click);
            // 
            // RbCartao
            // 
            this.RbCartao.AutoSize = true;
            this.RbCartao.Enabled = false;
            this.RbCartao.Location = new System.Drawing.Point(15, 73);
            this.RbCartao.Name = "RbCartao";
            this.RbCartao.Size = new System.Drawing.Size(69, 19);
            this.RbCartao.TabIndex = 30;
            this.RbCartao.Text = "CARTÃO";
            this.RbCartao.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(877, 133);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 15);
            this.label14.TabIndex = 31;
            this.label14.Text = "TROCO (R$):";
            // 
            // TbTroco
            // 
            this.TbTroco.Enabled = false;
            this.TbTroco.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TbTroco.Location = new System.Drawing.Point(877, 151);
            this.TbTroco.Name = "TbTroco";
            this.TbTroco.PlaceholderText = "0,00";
            this.TbTroco.Size = new System.Drawing.Size(100, 32);
            this.TbTroco.TabIndex = 32;
            // 
            // BtSalvar
            // 
            this.BtSalvar.Enabled = false;
            this.BtSalvar.Location = new System.Drawing.Point(913, 207);
            this.BtSalvar.Name = "BtSalvar";
            this.BtSalvar.Size = new System.Drawing.Size(86, 23);
            this.BtSalvar.TabIndex = 33;
            this.BtSalvar.Text = "SALVAR";
            this.BtSalvar.UseVisualStyleBackColor = true;
            this.BtSalvar.Click += new System.EventHandler(this.BtSalvar_Click);
            // 
            // TbNumeroPedido
            // 
            this.TbNumeroPedido.Enabled = false;
            this.TbNumeroPedido.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TbNumeroPedido.Location = new System.Drawing.Point(4, 29);
            this.TbNumeroPedido.Name = "TbNumeroPedido";
            this.TbNumeroPedido.Size = new System.Drawing.Size(167, 32);
            this.TbNumeroPedido.TabIndex = 35;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(4, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 15);
            this.label15.TabIndex = 34;
            this.label15.Text = "PEDIDO Nº:";
            // 
            // GbTipoPagamento
            // 
            this.GbTipoPagamento.Controls.Add(this.RbDinheiro);
            this.GbTipoPagamento.Controls.Add(this.RbPix);
            this.GbTipoPagamento.Controls.Add(this.RbCartao);
            this.GbTipoPagamento.Location = new System.Drawing.Point(877, 20);
            this.GbTipoPagamento.Name = "GbTipoPagamento";
            this.GbTipoPagamento.Size = new System.Drawing.Size(150, 100);
            this.GbTipoPagamento.TabIndex = 36;
            this.GbTipoPagamento.TabStop = false;
            this.GbTipoPagamento.Text = "TIPO DE PAGAMENTO";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Lista);
            this.tabControl1.Controls.Add(this.Dados);
            this.tabControl1.Location = new System.Drawing.Point(4, 11);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1042, 588);
            this.tabControl1.TabIndex = 37;
            // 
            // Lista
            // 
            this.Lista.Controls.Add(this.label13);
            this.Lista.Controls.Add(this.TbPesquisarPedido);
            this.Lista.Controls.Add(this.LwPedidos);
            this.Lista.Location = new System.Drawing.Point(4, 24);
            this.Lista.Name = "Lista";
            this.Lista.Padding = new System.Windows.Forms.Padding(3);
            this.Lista.Size = new System.Drawing.Size(1034, 560);
            this.Lista.TabIndex = 1;
            this.Lista.Text = "Lista";
            this.Lista.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(186, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 15);
            this.label13.TabIndex = 2;
            this.label13.Text = "PESQUISAR:";
            // 
            // TbPesquisarPedido
            // 
            this.TbPesquisarPedido.Location = new System.Drawing.Point(262, 25);
            this.TbPesquisarPedido.Name = "TbPesquisarPedido";
            this.TbPesquisarPedido.PlaceholderText = "NOME DO CLIENTE (PODE SER O PRIMEIRO NOME OU COMPLETO)";
            this.TbPesquisarPedido.Size = new System.Drawing.Size(538, 23);
            this.TbPesquisarPedido.TabIndex = 1;
            this.TbPesquisarPedido.TextChanged += new System.EventHandler(this.TbPesquisarPedido_TextChanged);
            // 
            // LwPedidos
            // 
            this.LwPedidos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PedidoNumero,
            this.DataDoPedido,
            this.DataDaEntrega,
            this.Cliente,
            this.Whatsapp,
            this.Total});
            this.LwPedidos.FullRowSelect = true;
            this.LwPedidos.HideSelection = false;
            this.LwPedidos.Location = new System.Drawing.Point(67, 57);
            this.LwPedidos.MultiSelect = false;
            this.LwPedidos.Name = "LwPedidos";
            this.LwPedidos.Size = new System.Drawing.Size(913, 497);
            this.LwPedidos.TabIndex = 0;
            this.LwPedidos.UseCompatibleStateImageBehavior = false;
            this.LwPedidos.View = System.Windows.Forms.View.Details;
            this.LwPedidos.SelectedIndexChanged += new System.EventHandler(this.LwPedidos_SelectedIndexChanged);
            // 
            // PedidoNumero
            // 
            this.PedidoNumero.Text = "PEDIDO N°";
            this.PedidoNumero.Width = 100;
            // 
            // DataDoPedido
            // 
            this.DataDoPedido.Text = "DATA DO PEDIDO";
            this.DataDoPedido.Width = 150;
            // 
            // DataDaEntrega
            // 
            this.DataDaEntrega.Text = "DATA DA ENTREGA";
            this.DataDaEntrega.Width = 150;
            // 
            // Cliente
            // 
            this.Cliente.Text = "CLIENTE";
            this.Cliente.Width = 250;
            // 
            // Whatsapp
            // 
            this.Whatsapp.Text = "WHATSAPP";
            this.Whatsapp.Width = 150;
            // 
            // Total
            // 
            this.Total.Text = "TOTAL";
            this.Total.Width = 100;
            // 
            // Dados
            // 
            this.Dados.Controls.Add(this.BtGerarPdf);
            this.Dados.Controls.Add(this.BtAdicionarPedido);
            this.Dados.Controls.Add(this.BtEditar);
            this.Dados.Controls.Add(this.BtExcluirPedido);
            this.Dados.Controls.Add(this.BtCancelar);
            this.Dados.Controls.Add(this.TbPontoDeReferencia);
            this.Dados.Controls.Add(this.GbTipoPagamento);
            this.Dados.Controls.Add(this.label1);
            this.Dados.Controls.Add(this.TbNumeroPedido);
            this.Dados.Controls.Add(this.MkDataPedido);
            this.Dados.Controls.Add(this.label15);
            this.Dados.Controls.Add(this.label2);
            this.Dados.Controls.Add(this.BtSalvar);
            this.Dados.Controls.Add(this.MkDataEntrega);
            this.Dados.Controls.Add(this.TbTroco);
            this.Dados.Controls.Add(this.label3);
            this.Dados.Controls.Add(this.label14);
            this.Dados.Controls.Add(this.TbCliente);
            this.Dados.Controls.Add(this.TbCupom);
            this.Dados.Controls.Add(this.label4);
            this.Dados.Controls.Add(this.label12);
            this.Dados.Controls.Add(this.MkWhatsapp);
            this.Dados.Controls.Add(this.TbFrete);
            this.Dados.Controls.Add(this.label5);
            this.Dados.Controls.Add(this.label11);
            this.Dados.Controls.Add(this.TbInstagram);
            this.Dados.Controls.Add(this.BtExcluirProduto);
            this.Dados.Controls.Add(this.label6);
            this.Dados.Controls.Add(this.TbTotal);
            this.Dados.Controls.Add(this.label7);
            this.Dados.Controls.Add(this.label10);
            this.Dados.Controls.Add(this.RtbEnderecoDeEntrega);
            this.Dados.Controls.Add(this.BtAdicionarProduto);
            this.Dados.Controls.Add(this.label8);
            this.Dados.Controls.Add(this.TbEmail);
            this.Dados.Controls.Add(this.label9);
            this.Dados.Controls.Add(this.LwProdutos);
            this.Dados.Controls.Add(this.RtbObservacaoDoPedido);
            this.Dados.Location = new System.Drawing.Point(4, 24);
            this.Dados.Name = "Dados";
            this.Dados.Padding = new System.Windows.Forms.Padding(3);
            this.Dados.Size = new System.Drawing.Size(1034, 560);
            this.Dados.TabIndex = 0;
            this.Dados.Text = "Dados";
            this.Dados.UseVisualStyleBackColor = true;
            // 
            // BtGerarPdf
            // 
            this.BtGerarPdf.Location = new System.Drawing.Point(907, 373);
            this.BtGerarPdf.Name = "BtGerarPdf";
            this.BtGerarPdf.Size = new System.Drawing.Size(99, 23);
            this.BtGerarPdf.TabIndex = 41;
            this.BtGerarPdf.Text = "EXPORTA PDF";
            this.BtGerarPdf.UseVisualStyleBackColor = true;
            this.BtGerarPdf.Click += new System.EventHandler(this.BtGerarPdf_Click);
            // 
            // BtAdicionarPedido
            // 
            this.BtAdicionarPedido.Location = new System.Drawing.Point(913, 277);
            this.BtAdicionarPedido.Name = "BtAdicionarPedido";
            this.BtAdicionarPedido.Size = new System.Drawing.Size(86, 23);
            this.BtAdicionarPedido.TabIndex = 40;
            this.BtAdicionarPedido.Text = "ADICIONAR";
            this.BtAdicionarPedido.UseVisualStyleBackColor = true;
            this.BtAdicionarPedido.Click += new System.EventHandler(this.BtAdicionarPedido_Click);
            // 
            // BtEditar
            // 
            this.BtEditar.Location = new System.Drawing.Point(913, 304);
            this.BtEditar.Name = "BtEditar";
            this.BtEditar.Size = new System.Drawing.Size(86, 23);
            this.BtEditar.TabIndex = 39;
            this.BtEditar.Text = "EDITAR";
            this.BtEditar.UseVisualStyleBackColor = true;
            this.BtEditar.Click += new System.EventHandler(this.BtEditar_Click);
            // 
            // BtExcluirPedido
            // 
            this.BtExcluirPedido.Location = new System.Drawing.Point(913, 333);
            this.BtExcluirPedido.Name = "BtExcluirPedido";
            this.BtExcluirPedido.Size = new System.Drawing.Size(86, 23);
            this.BtExcluirPedido.TabIndex = 38;
            this.BtExcluirPedido.Text = "EXCLUIR";
            this.BtExcluirPedido.UseVisualStyleBackColor = true;
            this.BtExcluirPedido.Click += new System.EventHandler(this.BtExcluirPedido_Click);
            // 
            // BtCancelar
            // 
            this.BtCancelar.Enabled = false;
            this.BtCancelar.Location = new System.Drawing.Point(913, 236);
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.Size = new System.Drawing.Size(86, 23);
            this.BtCancelar.TabIndex = 37;
            this.BtCancelar.Text = "CANCELAR";
            this.BtCancelar.UseVisualStyleBackColor = true;
            this.BtCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // FormPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 604);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema SuaImpressora Para Pedidos (Por Juan de Oliveira Farias)";
            this.Load += new System.EventHandler(this.FormPedido_Load);
            this.GbTipoPagamento.ResumeLayout(false);
            this.GbTipoPagamento.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.Lista.ResumeLayout(false);
            this.Lista.PerformLayout();
            this.Dados.ResumeLayout(false);
            this.Dados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox MkDataPedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox MkDataEntrega;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox MkWhatsapp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TbInstagram;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox RtbEnderecoDeEntrega;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox RtbObservacaoDoPedido;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TbPontoDeReferencia;
        private System.Windows.Forms.TextBox TbEmail;
        private System.Windows.Forms.ColumnHeader descricao;
        private System.Windows.Forms.ColumnHeader quantidade;
        private System.Windows.Forms.ColumnHeader subtotal;
        private System.Windows.Forms.Button BtAdicionarProduto;
        private System.Windows.Forms.ListView LwProdutos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TbTotal;
        private System.Windows.Forms.ColumnHeader valorUni;
        private System.Windows.Forms.Button BtExcluirProduto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TbCupom;
        private System.Windows.Forms.TextBox TbFrete;
        private System.Windows.Forms.RadioButton RbPix;
        private System.Windows.Forms.RadioButton RbDinheiro;
        private System.Windows.Forms.RadioButton RbCartao;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TbTroco;
        private System.Windows.Forms.Button BtSalvar;
        private System.Windows.Forms.TextBox TbNumeroPedido;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox GbTipoPagamento;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Lista;
        private System.Windows.Forms.TabPage Dados;
        private System.Windows.Forms.ListView LwPedidos;
        private System.Windows.Forms.ColumnHeader PedidoNumero;
        private System.Windows.Forms.ColumnHeader DataDoPedido;
        private System.Windows.Forms.ColumnHeader DataDaEntrega;
        private System.Windows.Forms.ColumnHeader Cliente;
        private System.Windows.Forms.ColumnHeader Whatsapp;
        private System.Windows.Forms.ColumnHeader Total;
        private System.Windows.Forms.Button BtEditar;
        private System.Windows.Forms.Button BtExcluirPedido;
        private System.Windows.Forms.Button BtCancelar;
        private System.Windows.Forms.Button BtAdicionarPedido;
        private System.Windows.Forms.Button BtGerarPdf;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TbPesquisarPedido;
    }
}

