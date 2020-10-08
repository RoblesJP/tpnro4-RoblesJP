using System;
using System.Collections.Generic;
using System.Text;

namespace Cadeteria
{
    public class PedidoDelicado : Pedido
    {
        public PedidoDelicado(string descripcion) : base(descripcion) { }
        public override double Precio()
        {
            return PrecioBase * 1.25;
        }
    }
}
