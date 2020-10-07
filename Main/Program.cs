using System;
using Cadeteria;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Empresa miCadeteria1 = Helper.GenerarEmpresaAleatoria(5, 5);
            Helper.InformeDeEmpresa(miCadeteria1);
        }
    }
}
