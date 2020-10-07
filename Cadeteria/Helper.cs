using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using System.Text;

namespace Cadeteria
{
    public class Helper
    {
        private static readonly string[] Nombres = { "Juan", "Pedro", "Maria", "Carlos", "Aracely", "Claudio" };

        public static Empresa GenerarEmpresaAleatoria(int cantidadDeCadetes, int cantidadDePedidosPorCadete)
        {
            Empresa miEmpresaAleatoria = new Empresa("Una empresa de mentira");
            Random rnd = new Random();

            for (int i = 0; i < cantidadDeCadetes; i++)
            {
                miEmpresaAleatoria.AgregarCadete(Nombres[rnd.Next(Nombres.Length)], "Direccion del cadete", 3811234567);
                for (int j = 0; j < cantidadDePedidosPorCadete; j++)
                {
                    Pedido suPedidoAleatorio = new Pedido("Un pedido aleatorio", Nombres[rnd.Next(Nombres.Length)], "Direccion del cliente", 3811234567);
                    if (rnd.Next(0, 2) == 1)
                    {
                        suPedidoAleatorio.Estado = Estado.Entregado;
                    }
                    miEmpresaAleatoria.ListadoDeCadetes[i].AgregarPedido(suPedidoAleatorio);
                }
            }
            return miEmpresaAleatoria;
        }

        public static void InformeDeEmpresa(Empresa miEmpresa)
        {
            Console.WriteLine("####### {0} #######", miEmpresa.Nombre.ToUpper());
            foreach (Cadete miCadete in miEmpresa.ListadoDeCadetes)
            {
                Console.WriteLine(" -- CADETE {0}: {1} --", miCadete.Id, miCadete.Nombre);
                foreach (Pedido suPedido in miCadete.ListaDePedidos)
                {
                    Console.WriteLine(" > PEDIDO {0}: {1} [{2}]", suPedido.Nro, suPedido.Descripcion, suPedido.Estado);
                }
                Console.WriteLine("Pedidos entregados: {0} | Promedio: {1} | Jornal: ${2}", miCadete.CantidadDePedidosEntregados(), miCadete.PromedioDePedidosEntregados(), miCadete.Jornal());
                Console.WriteLine();
            }
            Cadete cadeteConMasPedidosEntregados = miEmpresa.CadeteConMasPedidosEntregados();
            Console.WriteLine("Cadete con mas pedidos entregados: Cadete {0} - {1} con {2} pedidos entregados", cadeteConMasPedidosEntregados.Id, cadeteConMasPedidosEntregados.Nombre, cadeteConMasPedidosEntregados.CantidadDePedidosEntregados());
        }
    }
}
