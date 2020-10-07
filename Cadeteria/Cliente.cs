using System;
using System.Collections.Generic;
using System.Text;

namespace Cadeteria
{
    public class Cliente
    {
        private int id;
        private string nombre;
        private string direccion;
        private long telefono;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public long Telefono { get => telefono; set => telefono = value; }

        public Cliente(string nombre, string direccion, long telefono)
        {
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
        }
    }
}
