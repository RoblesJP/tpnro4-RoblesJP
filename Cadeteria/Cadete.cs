using System;
using System.Collections.Generic;
using System.Linq;

namespace Cadeteria
{
    public class Cadete
    {
        private int id;
        private string nombre;
        private string direccion;
        private long telefono;
        List<Pedido> listaDePedidos;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public long Telefono { get => telefono; set => telefono = value; }
        public List<Pedido> ListaDePedidos { get => listaDePedidos; set => listaDePedidos = value; }

        public Cadete(int id, string nombre, string direccion, long telefono)
        {
            Id = id;
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
            ListaDePedidos = new List<Pedido>();
        }

        public void AgregarPedido(Pedido pedido)
        {
            ListaDePedidos.Add(pedido);
        }

        public int Jornal()
        {
            int jornal = 0;
            int cantidadDePedidosEnregados = (ListaDePedidos.Where(pedido => pedido.Estado == Estado.Entregado)).Count();
            jornal = cantidadDePedidosEnregados * 100;
            return jornal;
        }

        public int CantidadDePedidosEntregados()
        {
            int cantidadDePedidosEntregados = (ListaDePedidos.Where(pedido => pedido.Estado == Estado.Entregado)).Count();
            return cantidadDePedidosEntregados;
        }

        public double PromedioDePedidosEntregados()
        {
            return (double) CantidadDePedidosEntregados() / (double) ListaDePedidos.Count;
        }
    }
}
