using System;
using System.IO;

namespace Proyecto_Catedra_GP3
{
    class Program
    {
        static void Main(string[] args)
        {
            Login.Ingresar();
            Recibo.Apertura();
            Menu.MenuPrincipal();
            Console.ReadKey();
        }
    }
}
