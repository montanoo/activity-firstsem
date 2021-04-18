using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Catedra_GP3
{
    class Compra
    {
        public static void CompraProductos()
        {
            bool existenciaProducto = false;
            do
            {
                string codigoProducto;
                int unidadesComprar, continuarComprando, indexActual = 0;
                var retornoVector = LeerTxt.LeerTexto(); //Error porque aún no se ha unido
                double totalCompra;

                Console.WriteLine("Digita el código del producto que deseas comprar:");
                codigoProducto = Console.ReadLine();

                for (int i = 0; i < retornoVector.GetLength(0); i++)
                {
                    if (codigoProducto == retornoVector[i, 0])
                    {
                        Console.Clear();

                        Console.WriteLine($"Producto: {retornoVector[i, 1]}");
                        Console.WriteLine($"Descripción: {retornoVector[i, 4]}");
                        Console.WriteLine($"Unidades disponibles: {retornoVector[i, 3]}");
                        Console.WriteLine($"Precio del producto: ${retornoVector[i, 2]}");
                        indexActual = i;
                        existenciaProducto = true;
                    }
                }
                if (existenciaProducto)
                {
                    Console.WriteLine("¿Cuantas unidades deseas comprar?");
                    unidadesComprar = int.Parse(Console.ReadLine());

                    while (unidadesComprar < 0 || unidadesComprar > Convert.ToInt32(retornoVector[indexActual, 3]))
                    {
                        Console.WriteLine("¡No puedes comprar esa cantidad!");
                        Console.WriteLine("¿Cuantas unidades deseas comprar?");
                        unidadesComprar = int.Parse(Console.ReadLine());
                    }
                    totalCompra = unidadesComprar * Convert.ToDouble(retornoVector[indexActual, 2]);

                    Console.WriteLine($"Comprarás {unidadesComprar} unidades a ${retornoVector[indexActual, 2]} c/u, pagarás ${totalCompra}");
                }
                else
                {
                    Console.Clear();

                    Console.WriteLine("El producto deseado no existe");
                    Console.WriteLine("Si desea regresar al menú y comprar otro producto, presione [1]");
                    continuarComprando = int.Parse(Console.ReadLine());

                    if (continuarComprando == 1)
                    {
                        Productos.Inventario(); //Aún no se ha unido
                        existenciaProducto = false;
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                }
            }
            while (existenciaProducto == false);
        }
    }
}
