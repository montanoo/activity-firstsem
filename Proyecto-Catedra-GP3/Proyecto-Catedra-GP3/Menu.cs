using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Catedra_GP3
{
    class Menu
    {
        public static void MenuPrincipal()
        {
            ConsoleKeyInfo opcionPrincipal;
            do
            {
                Console.WriteLine("Seleccione su opción: ");
                Console.WriteLine("A. Ver todos los productos");
                Console.WriteLine("B. Buscar un producto por su código");
                Console.WriteLine("ESC. Salir");
                var retornoVector = //LeerTxt.LeerTexto();
                opcionPrincipal = Console.ReadKey(true);

                switch (opcionPrincipal.Key)
                {
                    case ConsoleKey.A:
                        Console.Clear();
                        MenuSecundarioUno();
                        Console.WriteLine("Para continuar, presiona cualquier tecla.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case ConsoleKey.B:
                        Console.Clear();
                        //MenuSecundarioDos(retornoVector); //El parámetro es incorrecto porque aún no se ha unido.
                        Console.WriteLine("Para continuar, presiona cualquier tecla.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case ConsoleKey.Escape:
                        Console.WriteLine("Gracias por utilizar el programa.");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Tecla incorrecta");
                        Console.WriteLine("Para continuar, presiona cualquier tecla.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
            while (opcionPrincipal.Key != ConsoleKey.Escape);
        }
        public static void MenuSecundarioUno()
        {
            Console.WriteLine("Bienvenido a la opción 'ver todos los productos'");
            //Productos.Inventario();
        }
        public static void MenuSecundarioDos(string[,] vectorCodigo)
        {
            string codigoProducto;
            bool banderaInexistencia = true;
            Console.WriteLine("Bienvenido a la opción 'buscar producto por código'");
            Console.WriteLine("Para continuar, introduce un código.");
            codigoProducto = Console.ReadLine();

            for (int i = 0; i < vectorCodigo.GetLength(0); i++)
            {
                if (codigoProducto == vectorCodigo[i, 0])
                {
                    Console.WriteLine($"********| El producto fue encontrado |********");
                    Console.WriteLine($"|Código: {vectorCodigo[i, 0]} | Nombre: {vectorCodigo[i, 1]}");
                    Console.WriteLine($"|Descripción: {vectorCodigo[i, 4]}\n");
                    banderaInexistencia = false;
                }
            }
            if (banderaInexistencia) //Se activará solo si el producto no existe, si nunca entra en el if de arriba.
            {
                Console.WriteLine("El producto no fue encontrado, no existe.");
            }
        }
    }
}
