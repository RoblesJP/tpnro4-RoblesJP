using System;

namespace Cadeteria
{
    public enum Estado
    {
        Pendiente,
        Asignado,
        Entregado
    }

    public enum Tipo
    {
        Express,
        Delicado,
        Ecologico
    }

    public class Pedido
    {
        // atributos
        protected static double PrecioBase = 150;
        private int nro;
        private string descripcion;
        Estado estado;

        // propiedades
        public int Nro { get => nro; set => nro = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public Estado Estado { get => estado; set => estado = value; }
        
        // constructor
        public Pedido(string descripcion)
        {
            Nro = new Random().Next(1000, 10000);
            Descripcion = descripcion;
            Estado = Estado.Pendiente;
        }

        // métodos
        public virtual double Precio() { return 0; }
    }
}
