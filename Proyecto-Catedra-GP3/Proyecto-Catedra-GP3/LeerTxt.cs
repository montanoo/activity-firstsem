using System.IO;

namespace Proyecto_Catedra_GP3

{
    class LeerTxt
    {
        public static string oldPath = Directory.GetCurrentDirectory();
        public static string pathInventario = LeerTxt.oldPath.Replace("\\bin\\Debug\\netcoreapp3.1", "\\Inventario");

        public static string pathRecibo = LeerTxt.oldPath.Replace("\\bin\\Debug\\netcoreapp3.1", "\\Recibos");

        public static string[,] LeerTexto()
        {
            int counter = 0;
            string line;
            string[,] valores = new string[10, 5];
            string[] vector = new string[5];

            
            StreamReader leerTxt =new StreamReader($"{LeerTxt.pathInventario}\\Inventario.txt");
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
