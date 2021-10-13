using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace SuaImpressoraAppPedido.Model
{
    public class PedidoItem
    {
        public long Id { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public double PrecoUnitario { get; set; }

        [ForeignKey("Pedido")]
        public long PedidoId { get; set; }
        public Pedido Pedido { get; set; }
    }
}
