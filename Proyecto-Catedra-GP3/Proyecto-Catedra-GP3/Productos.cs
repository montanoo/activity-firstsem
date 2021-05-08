using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Catedra_GP3
{
    class Productos
    {
        public static void Inventario()
        {
            var retornoVector = LeerTxt.LeerTexto();

            // Productos en el inventario
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"|Código: {retornoVector[i, 0]} | Nombre: {retornoVector[i, 1]}");
                Console.WriteLine($"|Descripción: {retornoVector[i, 4]}");
            }
        }
    }
}
