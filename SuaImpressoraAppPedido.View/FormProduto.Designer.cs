
namespace SuaImpressoraAppPedido.View
{
    partial class FormProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TbDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TbQuantidade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TbPrecoUnitario = new System.Windows.Forms.TextBox();
            this.BtSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "DESCRIÇÃO:";
            // 
            // TbDescricao
            // 
            this.TbDescricao.Location = new System.Drawing.Point(12, 27);
            this.TbDescricao.Name = "TbDescricao";
            this.TbDescricao.Size = new System.Drawing.Size(334, 23);
            this.TbDescricao.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "QUANTIDADE:";
            // 
            // TbQuantidade
            // 
            this.TbQuantidade.Location = new System.Drawing.Point(63, 77);
            this.TbQuantidade.Name = "TbQuantidade";
            this.TbQuantidade.Size = new System.Drawing.Size(100, 23);
            this.TbQuantidade.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "PREÇO UNITÁRIO (R$):";
            // 
            // TbPrecoUnitario
            // 
            this.TbPrecoUnitario.Location = new System.Drawing.Point(196, 77);
            this.TbPrecoUnitario.Name = "TbPrecoUnitario";
            this.TbPrecoUnitario.Size = new System.Drawing.Size(100, 23);
            this.TbPrecoUnitario.TabIndex = 5;
            // 
            // BtSalvar
            // 
            this.BtSalvar.Location = new System.Drawing.Point(135, 129);
            this.BtSalvar.Name = "BtSalvar";
            this.BtSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtSalvar.TabIndex = 6;
            this.BtSalvar.Text = "SALVAR";
            this.BtSalvar.UseVisualStyleBackColor = true;
            this.BtSalvar.Click += new System.EventHandler(this.BtSalvar_Click);
            // 
            // FormProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 171);
            this.Controls.Add(this.BtSalvar);
            this.Controls.Add(this.TbPrecoUnitario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbQuantidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbDescricao);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbDescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbQuantidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbPrecoUnitario;
        private System.Windows.Forms.Button BtSalvar;
    }
}