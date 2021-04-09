using System;
using System.Collections.Generic;
using System.Text;

namespace proyectoPrueba
{
    class LeerTxt
    {
        public static string[,] LeerTexto()
        {
            int counter = 0;
            string line;
            string[,] valores = new string[10, 5];
            string[] vector = new string[5];

            System.IO.StreamReader leerTxt =
                new System.IO.StreamReader(@"C:\Users\bryan\Desktop\Proyecto Cátedra\Avance 2\proyectoPrueba\Inventario.txt"); // Ubicación que debe sustituir
            while ((line = leerTxt.ReadLine()) != null)
            {
                vector = line.Split(","); //Separa la linea cuando exista una coma
                for (int i = 0; i < vector.Length; i++) //i = columna
                {
                    //Console.WriteLine(vector[i]);
                    valores[counter, i] = vector[i];
                }
                counter++; //Fila
            }
            leerTxt.Close();
            return valores;

        }

    }
}
