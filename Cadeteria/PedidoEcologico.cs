using System;
using System.Collections.Generic;
using System.Text;

namespace Cadeteria
{
    public class PedidoEcologico : Pedido
    {
        public PedidoEcologico(string descripcion) : base(descripcion) { }
        public override double Precio()
        {
            return PrecioBase;
        }
    }
}
