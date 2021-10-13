using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SuaImpressoraAppPedido.View
{
    public partial class FormProduto : Form
    {
        private FormPedido fp;
        private double Subtotal;
        public FormProduto(FormPedido fp)
        {
            InitializeComponent();
            this.fp = fp;
            this.Subtotal = double.Parse(fp.TbS01.Text.Split(" ")[1]);
        }

        private void BtSalvar_Click(object sender, EventArgs e)
        {
            String[] items = new String[4];

            items[0] = TbDescricao.Text.Trim();
            items[1] = "R$ " + TbPrecoUnitario.Text.Trim();
            items[2] = TbQuantidade.Text.Trim();
            items[3] = "R$ " + (double.Parse(TbPrecoUnitario.Text) * int.Parse(TbQuantidade.Text)).ToString("N2");

            ListViewItem listViewItem = new ListViewItem(items);
            fp.LwP.Items.Add(listViewItem);

            this.Subtotal += double.Parse(TbPrecoUnitario.Text) * int.Parse(TbQuantidade.Text);
            fp.TbS01.Text = "R$ " + Subtotal.ToString("N2");

            LimparCampos();
        }

        private void LimparCampos() 
        {
            TbDescricao.Clear();
            TbQuantidade.Clear();
            TbPrecoUnitario.Clear();
        }
    }
}
