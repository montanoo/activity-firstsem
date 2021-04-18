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
        public static void Asignaciones()
        {
            var retornoVector = LeerTxt.LeerTexto();

            //Variables código de productos
            double codigoProducto1 = Convert.ToDouble(retornoVector[0, 0]);
            double codigoProducto2 = Convert.ToDouble(retornoVector[1, 0]);
            double codigoProducto3 = Convert.ToDouble(retornoVector[2, 0]);
            double codigoProducto4 = Convert.ToDouble(retornoVector[3, 0]);
            double codigoProducto5 = Convert.ToDouble(retornoVector[4, 0]);
            double codigoProducto6 = Convert.ToDouble(retornoVector[5, 0]);
            double codigoProducto7 = Convert.ToDouble(retornoVector[6, 0]);
            double codigoProducto8 = Convert.ToDouble(retornoVector[7, 0]);
            double codigoProducto9 = Convert.ToDouble(retornoVector[8, 0]);
            double codigoProducto10 = Convert.ToDouble(retornoVector[9, 0]);

            //Variables del precio del producto
            double precioProducto1 = Convert.ToDouble(retornoVector[0, 2]);
            double precioProducto2 = Convert.ToDouble(retornoVector[1, 2]);
            double precioProducto3 = Convert.ToDouble(retornoVector[2, 2]);
            double precioProducto4 = Convert.ToDouble(retornoVector[3, 2]);
            double precioProducto5 = Convert.ToDouble(retornoVector[4, 2]);
            double precioProducto6 = Convert.ToDouble(retornoVector[5, 2]);
            double precioProducto7 = Convert.ToDouble(retornoVector[6, 2]);
            double precioProducto8 = Convert.ToDouble(retornoVector[7, 2]);
            double precioProducto9 = Convert.ToDouble(retornoVector[8, 2]);
            double precioProducto10 = Convert.ToDouble(retornoVector[9, 2]);

            //Variables de unidades disponibles
            Int32 unidadesProducto1 = Convert.ToInt32(retornoVector[0, 3]);
            Int32 unidadesProducto2 = Convert.ToInt32(retornoVector[1, 3]);
            Int32 unidadesProducto3 = Convert.ToInt32(retornoVector[2, 3]);
            Int32 unidadesProducto4 = Convert.ToInt32(retornoVector[3, 3]);
            Int32 unidadesProducto5 = Convert.ToInt32(retornoVector[4, 3]);
            Int32 unidadesProducto6 = Convert.ToInt32(retornoVector[5, 3]);
            Int32 unidadesProducto7 = Convert.ToInt32(retornoVector[6, 3]);
            Int32 unidadesProducto8 = Convert.ToInt32(retornoVector[7, 3]);
            Int32 unidadesProducto9 = Convert.ToInt32(retornoVector[8, 3]);
            Int32 unidadesProducto10 = Convert.ToInt32(retornoVector[9, 3]);
        }
    }
}
