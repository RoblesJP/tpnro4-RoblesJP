using System;
using System.Collections.Generic;
using System.Text;

namespace Cadeteria
{
    public class Cliente : Persona
    {
        private static int nextId = 0;
        // atributos
        private List<Pedido> listaDePedidosRealizados;

        // propiedades
        public List<Pedido> ListaDePedidosRealizados { get => listaDePedidosRealizados; set => listaDePedidosRealizados = value; }

        // constructor
        public Cliente(string nombre, string direccion, long telefono) : base(nombre, direccion, telefono)
        { 
            Id = ++nextId;
            ListaDePedidosRealizados = new List<Pedido>();
        }

        // métodos
        public int CantidadDePedidosRealizados()
        {
            return ListaDePedidosRealizados.Count;
        }

        public Pedido RealizarPedido(Tipo tipo, string descripcion)
        {
            Pedido suPedido = null;
            switch (tipo)
            {
                case Tipo.Express:
                    suPedido = new PedidoExpress(descripcion);
                    break;
                case Tipo.Delicado:
                    suPedido = new PedidoDelicado(descripcion);
                    break;
                case Tipo.Ecologico:
                    suPedido = new PedidoEcologico(descripcion);
                    break;
            }
            ListaDePedidosRealizados.Add(suPedido);
            return suPedido;
        }
    }
}
