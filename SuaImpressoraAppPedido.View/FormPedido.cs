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

        public void AtualizarTotal()
        {
            double total = 0.00;
            double cupom = !String.IsNullOrEmpty(TbCupom.Text) ? double.Parse(TbCupom.Text) : 0.00;
            double frete = !String.IsNullOrEmpty(TbFrete.Text) ? double.Parse(TbFrete.Text) : 0.00;

            foreach (ListViewItem item in LwProdutos.Items)
            {
                total += double.Parse(item.SubItems[3].Text.Split(" ")[1]);
            }

            total += frete - (cupom / 100) * total;
            TbTotal.Text = "R$ " + total.ToString("N2");
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
            if (Regex.IsMatch(TbFrete.Text, @"[0-9]") || TbFrete.Text.Trim().Equals("")) {
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
    }
}
