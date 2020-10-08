using System;
using System.Collections.Generic;
using System.Text;

namespace Cadeteria
{
    class PedidoExpress : Pedido
    {
        public PedidoExpress(string descripcion) : base(descripcion) { }
        public override double Precio()
        {
            return PrecioBase * 1.25;
        }
    }
}
