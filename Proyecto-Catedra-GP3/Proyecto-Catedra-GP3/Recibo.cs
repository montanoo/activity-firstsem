using System;
using System.IO;

namespace Proyecto_Catedra_GP3
{
    class Recibo
    {
        public static void Apertura()
        {

            if (!Directory.Exists(LeerTxt.pathRecibo))
            {
                Directory.CreateDirectory(LeerTxt.pathRecibo);
            }

            StreamWriter aperturaRecibo = new StreamWriter($"{LeerTxt.pathRecibo}\\{DateTime.Now.ToString("dd-MM-yy")}.txt", true);
            aperturaRecibo.WriteLine("------------Detalle de compra------------");
            aperturaRecibo.Close();
        }
        public static void Cierre()
        {
            StreamWriter total = new StreamWriter($"{LeerTxt.pathRecibo}\\{DateTime.Now.ToString("dd-MM-yy")}.txt", true);
            total.WriteLine($"Total de la compra: ${Math.Round(Compra.totalTotal,2)}");
            total.WriteLine("------------Fin de compra------------\n");
            total.Close();
        }
    }
}
