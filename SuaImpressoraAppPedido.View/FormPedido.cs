using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuaImpressoraAppPedido.View
{
    public partial class FormPedido : Form
    {
        public ListView LwP { get { return LwProdutos; } }
        public TextBox TbS01 { get { return TbSubtotal01; } }
        public FormPedido()
        {
            InitializeComponent();
        }

        private void BtAdicionar_Click(object sender, EventArgs e)
        {
            FormProduto fp = new FormProduto(this);
            fp.ShowDialog();
        }

        private void BtRemover_Click(object sender, EventArgs e)
        {
            double subtotal = double.Parse(TbSubtotal01.Text.Split(" ")[1]) - double.Parse(LwProdutos.SelectedItems[0].SubItems[3].Text.Split(" ")[1]);
            LwProdutos.Items.RemoveAt(LwProdutos.SelectedIndices[0]);
            TbSubtotal01.Text = "R$ " + subtotal.ToString("N2");
        }
    }
}
