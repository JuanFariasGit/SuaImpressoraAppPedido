using System;
using SuaImpressoraAppPedido.Enum;
using System.Collections.Generic;

namespace SuaImpressoraAppPedido.Model
{
    public class Pedido
    {
        public long Id { get; set; }
        public string DataDoPedido { get; set; }
        public string DataDeEntrega { get; set; }
        public string Cliente { get; set; }
        public string Whatsapp { get; set; }
        public string Instagram { get; set; }
        public string Email { get; set; }
        public string EnderecoDeEntrega { get; set; }
        public string PontoDeReferencia { get; set; }
        public double Cupom { get; set; }
        public double Frete { get; set; }
        public double Total { get; set; }
        public string Observacao { get; set; }
        public TipoPagamento TipoPagamento { get; set; }
        public ICollection<PedidoItem> PedidoItems { get; set; }
    }
}
