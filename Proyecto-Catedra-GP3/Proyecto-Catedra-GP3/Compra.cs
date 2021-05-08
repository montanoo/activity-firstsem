using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Proyecto_Catedra_GP3
{
    class Compra
    {
        public static double totalTotal = 0;
        public static void CompraProductos()
        {
            bool existenciaProducto = false;
            do
            {
                string codigoProducto;
                int unidadesComprar, continuarComprando, indexActual = 0, opcionesSecundarias;
                var retornoVector = LeerTxt.LeerTexto(); 
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
                    Console.WriteLine($"Comprarás {unidadesComprar} unidades a ${retornoVector[indexActual, 2]} c/u, pagarás ${Math.Round(totalCompra,2)}");
                    
                    int newValue = Convert.ToInt32(retornoVector[indexActual, 3]);
                    int Actualizar = newValue - unidadesComprar;
                    retornoVector[indexActual, 3] = Convert.ToString(Actualizar);

                    Compra.totalTotal += totalCompra;

                    if (!Directory.Exists(LeerTxt.pathRecibo))
                    {
                        Directory.CreateDirectory(LeerTxt.pathRecibo);
                    }

                    StreamWriter actualizarInventario = new StreamWriter($"{LeerTxt.pathInventario}\\Inventario.txt", false);
                    StreamWriter reciboImprimir = new StreamWriter($"{LeerTxt.pathRecibo}\\{DateTime.Now.ToString("dd-MM-yy")}.txt", true);
                    reciboImprimir.WriteLine($"Producto: {retornoVector[indexActual, 1]} ID: {retornoVector[indexActual, 0]}");
                    reciboImprimir.WriteLine($"Unidades: {unidadesComprar}");
                    reciboImprimir.WriteLine($"Precio: ${Convert.ToDouble(retornoVector[indexActual, 2])}");
                    reciboImprimir.WriteLine($"Total: ${Math.Round(totalCompra,2)}\n");
                    reciboImprimir.Close();
                    
                    Console.WriteLine("Recibo impreso con exito...");
                    for (int j = 0; j < retornoVector.GetLength(0); j++)
                    {
                        for (int k = 0; k < retornoVector.GetLength(1); k++)
                        {
                            if (k < retornoVector.GetLength(1) - 1)
                                actualizarInventario.Write($"{retornoVector[j, k]},");
                            else
                                actualizarInventario.Write($"{retornoVector[j, k]}");
                        }
                        actualizarInventario.Write($"\n");
                    }
                    actualizarInventario.Close();
                    Console.WriteLine("Si deseas seguir comprando, presiona '1', si deseas ir al menu principal, presiona '2', si desea salir, '3'.");
                    opcionesSecundarias = int.Parse(Console.ReadLine());

                    if (opcionesSecundarias == 1) {
                        Console.Clear();
                        Productos.Inventario();
                        Compra.CompraProductos();
                    }
                    else if (opcionesSecundarias == 3) 
                    {
                        StreamWriter total = new StreamWriter($"{LeerTxt.pathRecibo}\\{DateTime.Now.ToString("dd-MM-yy")}.txt", true);
                        total.WriteLine($"Total de la compra: ${Compra.totalTotal}");
                        total.WriteLine("------------Fin de compra------------");
                        total.Close();
                        Console.ReadKey();
                        Environment.Exit(0); 
                    }
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
                        StreamWriter total = new StreamWriter($"{LeerTxt.pathRecibo}\\{DateTime.Now.ToString("dd-MM-yy")}.txt", true);
                        total.WriteLine($"Total de la compra: ${Compra.totalTotal}");
                        total.WriteLine("------------Fin de compra------------");
                        total.Close();
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                }
            }
            while (!existenciaProducto);
        }
    }
}
