using System;

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
                Console.WriteLine("A. Comprar productos");
                Console.WriteLine("B. Buscar un producto por su código");
                Console.WriteLine("ESC. Salir");
                var retornoVector = LeerTxt.LeerTexto();
                opcionPrincipal = Console.ReadKey();

                switch (opcionPrincipal.Key)
                {
                    case ConsoleKey.A:
                        Console.Clear();
                        MenuSecundarioUno();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case ConsoleKey.B:
                        Console.Clear();
                        MenuSecundarioDos(retornoVector); //Falta pasarle un parámetro
                        Console.WriteLine("Para continuar, presiona cualquier tecla.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case ConsoleKey.Escape:
                        Console.WriteLine("Gracias por utilizar el programa.");
                        Recibo.Cierre();
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
            Console.WriteLine("Bienvenido a la opción 'comprar productos'");
            Productos.Inventario();
            Compra.CompraProductos();
        }
        public static void MenuSecundarioDos(string[,] vectorCodigo)
        {
            string codigoProducto;
            bool banderaInexistencia = true;
            Console.WriteLine("Bienvenido a la opción 'buscar producto por código'");
            Console.WriteLine("Para continuar, introduce un código.");
            codigoProducto = Console.ReadLine();
            Console.Clear();
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
