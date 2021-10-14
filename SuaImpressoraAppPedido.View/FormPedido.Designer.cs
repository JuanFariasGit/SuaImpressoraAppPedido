
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
            this.BtAdicionar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.TbTotal = new System.Windows.Forms.TextBox();
            this.BtRemover = new System.Windows.Forms.Button();
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.GbTipoPagamento = new System.Windows.Forms.GroupBox();
            this.GbTipoPagamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "DATA DO PEDIDO:";
            // 
            // MkDataPedido
            // 
            this.MkDataPedido.Location = new System.Drawing.Point(12, 94);
            this.MkDataPedido.Mask = "00/00/0000";
            this.MkDataPedido.Name = "MkDataPedido";
            this.MkDataPedido.Size = new System.Drawing.Size(100, 23);
            this.MkDataPedido.TabIndex = 1;
            this.MkDataPedido.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "DATA DE ENTREGA:";
            // 
            // MkDataEntrega
            // 
            this.MkDataEntrega.Location = new System.Drawing.Point(12, 147);
            this.MkDataEntrega.Mask = "00/00/0000";
            this.MkDataEntrega.Name = "MkDataEntrega";
            this.MkDataEntrega.Size = new System.Drawing.Size(100, 23);
            this.MkDataEntrega.TabIndex = 3;
            this.MkDataEntrega.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "CLIENTE:";
            // 
            // TbCliente
            // 
            this.TbCliente.Location = new System.Drawing.Point(12, 196);
            this.TbCliente.Name = "TbCliente";
            this.TbCliente.Size = new System.Drawing.Size(331, 23);
            this.TbCliente.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "WHATSAPP:";
            // 
            // MkWhatsapp
            // 
            this.MkWhatsapp.Location = new System.Drawing.Point(12, 246);
            this.MkWhatsapp.Mask = "(00) 9 0000-0000";
            this.MkWhatsapp.Name = "MkWhatsapp";
            this.MkWhatsapp.Size = new System.Drawing.Size(100, 23);
            this.MkWhatsapp.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "INSTAGRAM:";
            // 
            // TbInstagram
            // 
            this.TbInstagram.Location = new System.Drawing.Point(12, 299);
            this.TbInstagram.Name = "TbInstagram";
            this.TbInstagram.Size = new System.Drawing.Size(167, 23);
            this.TbInstagram.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "E-MAIL:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 384);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "ENDEREÇO DE ENTREGA:";
            // 
            // RtbEnderecoDeEntrega
            // 
            this.RtbEnderecoDeEntrega.Location = new System.Drawing.Point(12, 406);
            this.RtbEnderecoDeEntrega.Name = "RtbEnderecoDeEntrega";
            this.RtbEnderecoDeEntrega.Size = new System.Drawing.Size(331, 96);
            this.RtbEnderecoDeEntrega.TabIndex = 13;
            this.RtbEnderecoDeEntrega.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(386, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "PONTO DE REFERÊNCIA:";
            // 
            // RtbObservacaoDoPedido
            // 
            this.RtbObservacaoDoPedido.Location = new System.Drawing.Point(386, 105);
            this.RtbObservacaoDoPedido.Name = "RtbObservacaoDoPedido";
            this.RtbObservacaoDoPedido.Size = new System.Drawing.Size(331, 96);
            this.RtbObservacaoDoPedido.TabIndex = 17;
            this.RtbObservacaoDoPedido.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(386, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "OBSERVAÇÕES DO PEDIDO:";
            // 
            // TbPontoDeReferencia
            // 
            this.TbPontoDeReferencia.Location = new System.Drawing.Point(386, 50);
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
            this.LwProdutos.FullRowSelect = true;
            this.LwProdutos.HideSelection = false;
            this.LwProdutos.Location = new System.Drawing.Point(386, 237);
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
            this.TbEmail.Location = new System.Drawing.Point(12, 348);
            this.TbEmail.Name = "TbEmail";
            this.TbEmail.Size = new System.Drawing.Size(331, 23);
            this.TbEmail.TabIndex = 11;
            // 
            // BtAdicionar
            // 
            this.BtAdicionar.Location = new System.Drawing.Point(386, 208);
            this.BtAdicionar.Name = "BtAdicionar";
            this.BtAdicionar.Size = new System.Drawing.Size(86, 23);
            this.BtAdicionar.TabIndex = 18;
            this.BtAdicionar.Text = "ADICIONAR";
            this.BtAdicionar.UseVisualStyleBackColor = true;
            this.BtAdicionar.Click += new System.EventHandler(this.BtAdicionar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(749, 459);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 15);
            this.label10.TabIndex = 25;
            this.label10.Text = "TOTAL (R$):";
            // 
            // TbTotal
            // 
            this.TbTotal.Enabled = false;
            this.TbTotal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TbTotal.Location = new System.Drawing.Point(751, 477);
            this.TbTotal.Name = "TbTotal";
            this.TbTotal.Size = new System.Drawing.Size(100, 32);
            this.TbTotal.TabIndex = 26;
            this.TbTotal.Text = "0,00";
            // 
            // BtRemover
            // 
            this.BtRemover.Location = new System.Drawing.Point(478, 208);
            this.BtRemover.Name = "BtRemover";
            this.BtRemover.Size = new System.Drawing.Size(86, 23);
            this.BtRemover.TabIndex = 19;
            this.BtRemover.Text = "REMOVER";
            this.BtRemover.UseVisualStyleBackColor = true;
            this.BtRemover.Click += new System.EventHandler(this.BtRemover_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(645, 459);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 15);
            this.label11.TabIndex = 23;
            this.label11.Text = "FRETE (R$):";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(539, 459);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 15);
            this.label12.TabIndex = 21;
            this.label12.Text = "CUPOM (%):";
            // 
            // TbCupom
            // 
            this.TbCupom.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TbCupom.Location = new System.Drawing.Point(539, 477);
            this.TbCupom.Name = "TbCupom";
            this.TbCupom.PlaceholderText = "0,00";
            this.TbCupom.Size = new System.Drawing.Size(100, 32);
            this.TbCupom.TabIndex = 22;
            this.TbCupom.TextChanged += new System.EventHandler(this.TbCupom_TextChanged);
            // 
            // TbFrete
            // 
            this.TbFrete.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TbFrete.Location = new System.Drawing.Point(645, 477);
            this.TbFrete.Name = "TbFrete";
            this.TbFrete.PlaceholderText = "0,00";
            this.TbFrete.Size = new System.Drawing.Size(100, 32);
            this.TbFrete.TabIndex = 24;
            this.TbFrete.TextChanged += new System.EventHandler(this.TbFrete_TextChanged);
            // 
            // RbPix
            // 
            this.RbPix.AutoSize = true;
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
            this.RbDinheiro.Location = new System.Drawing.Point(15, 49);
            this.RbDinheiro.Name = "RbDinheiro";
            this.RbDinheiro.Size = new System.Drawing.Size(79, 19);
            this.RbDinheiro.TabIndex = 29;
            this.RbDinheiro.TabStop = true;
            this.RbDinheiro.Text = "DINHEIRO";
            this.RbDinheiro.UseVisualStyleBackColor = true;
            // 
            // RbCartao
            // 
            this.RbCartao.AutoSize = true;
            this.RbCartao.Location = new System.Drawing.Point(15, 73);
            this.RbCartao.Name = "RbCartao";
            this.RbCartao.Size = new System.Drawing.Size(69, 19);
            this.RbCartao.TabIndex = 30;
            this.RbCartao.TabStop = true;
            this.RbCartao.Text = "CARTÃO";
            this.RbCartao.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(885, 155);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 15);
            this.label14.TabIndex = 31;
            this.label14.Text = "TROCO (R$):";
            // 
            // TbTroco
            // 
            this.TbTroco.Enabled = false;
            this.TbTroco.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TbTroco.Location = new System.Drawing.Point(885, 173);
            this.TbTroco.Name = "TbTroco";
            this.TbTroco.PlaceholderText = "0,00";
            this.TbTroco.Size = new System.Drawing.Size(100, 32);
            this.TbTroco.TabIndex = 32;
            // 
            // BtSalvar
            // 
            this.BtSalvar.Location = new System.Drawing.Point(885, 228);
            this.BtSalvar.Name = "BtSalvar";
            this.BtSalvar.Size = new System.Drawing.Size(111, 33);
            this.BtSalvar.TabIndex = 33;
            this.BtSalvar.Text = "SALVAR";
            this.BtSalvar.UseVisualStyleBackColor = true;
            this.BtSalvar.Click += new System.EventHandler(this.BtSalvar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(12, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 23);
            this.textBox1.TabIndex = 35;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 32);
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
            this.GbTipoPagamento.Location = new System.Drawing.Point(885, 42);
            this.GbTipoPagamento.Name = "GbTipoPagamento";
            this.GbTipoPagamento.Size = new System.Drawing.Size(150, 100);
            this.GbTipoPagamento.TabIndex = 36;
            this.GbTipoPagamento.TabStop = false;
            this.GbTipoPagamento.Text = "TIPO DE PAGAMENTO";
            // 
            // FormPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 524);
            this.Controls.Add(this.GbTipoPagamento);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.BtSalvar);
            this.Controls.Add(this.TbTroco);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.TbCupom);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TbFrete);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.BtRemover);
            this.Controls.Add(this.TbTotal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.BtAdicionar);
            this.Controls.Add(this.TbEmail);
            this.Controls.Add(this.LwProdutos);
            this.Controls.Add(this.TbPontoDeReferencia);
            this.Controls.Add(this.RtbObservacaoDoPedido);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.RtbEnderecoDeEntrega);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TbInstagram);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MkWhatsapp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TbCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MkDataEntrega);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MkDataPedido);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema SuaImpressora Para Pedidos (Por Juan de Oliveira Farias)";
            this.GbTipoPagamento.ResumeLayout(false);
            this.GbTipoPagamento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button BtAdicionar;
        private System.Windows.Forms.ListView LwProdutos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TbTotal;
        private System.Windows.Forms.ColumnHeader valorUni;
        private System.Windows.Forms.Button BtRemover;
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox GbTipoPagamento;
    }
}

