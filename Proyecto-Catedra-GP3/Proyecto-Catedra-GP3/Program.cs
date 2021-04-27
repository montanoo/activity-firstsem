using System;
using System.IO;

namespace Proyecto_Catedra_GP3
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu.MenuPrincipal();

            StreamWriter total = new StreamWriter("Recibo.txt", true);
            total.WriteLine("Total de la compra: "+Compra.totalTotal);
            total.Close();
            Console.ReadKey();
        }
    }
}
