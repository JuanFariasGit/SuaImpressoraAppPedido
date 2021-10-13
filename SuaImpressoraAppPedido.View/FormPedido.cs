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
    }
}
