using System;
using System.Collections.Generic;
using System.Text;

namespace Cadeteria
{
    public enum Estado
    {
        Pendiente,
        Entregado
    }
    public class Pedido
    {
        private int nro;
        private string descripcion;
        Cliente cliente;
        Estado estado;

        public int Nro { get => nro; set => nro = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public Estado Estado { get => estado; set => estado = value; }

        public Pedido(string descripcion, string nombreDeCliente, string direccionDeCliente, long telefonoDeCliente)
        {
            Nro = new Random().Next(1000, 10000);
            Descripcion = descripcion;
            Cliente = new Cliente(nombreDeCliente, direccionDeCliente, telefonoDeCliente);
            Estado = Estado.Pendiente;
        }
    }
}
