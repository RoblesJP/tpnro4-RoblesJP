using System;
using Cadeteria;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Empresa miCadeteria1 = Helper.GenerarEmpresaAleatoria(3, 3, 10);
            Helper.InformeDeEmpresa(miCadeteria1);
        }
    }
}
