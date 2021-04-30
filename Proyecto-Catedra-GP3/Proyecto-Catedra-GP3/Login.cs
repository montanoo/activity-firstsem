﻿using System;
using System.IO;

namespace Proyecto_Catedra_GP3
{
    class Login
    {
        public static void Ingresar()
        {
            bool banderaAcceso = true;
            do
            {
                int op;
                string inputUser, password;
                Console.WriteLine("Selecciona una opción: ");
                Console.WriteLine("1. Iniciar sesión");
                Console.WriteLine("2. Crear una cuenta");
                op = int.Parse(Console.ReadLine());

                Console.Clear();
                string lineCounter, line;
                int txtLineCounter = 0, counter = 0;
                string[] vector = new string[2];

                if (op == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Iniciar sesión");
                    Console.ForegroundColor = ConsoleColor.White;

                    StreamReader asignacionColumnas = new StreamReader("login.txt");
                    while ((lineCounter = asignacionColumnas.ReadLine()) != null)
                    {
                        txtLineCounter++;
                    }
                    asignacionColumnas.Close();

                    StreamReader lecturaDatos = new StreamReader("login.txt");
                    string[,] userData = new string[txtLineCounter, 2];
                    while ((line = lecturaDatos.ReadLine()) != null)
                    {
                        vector = line.Split(",");
                        for (int k = 0; k < vector.Length; k++) 
                        {
                            userData[counter, k] = vector[k];
                        }
                        counter++;
                    }
                    Console.WriteLine("Digita tu usuario");
                    inputUser = Console.ReadLine();

                    Console.WriteLine("Digita tu contraseña");
                    password = Console.ReadLine();

                    for (int i = 0; i < userData.GetLength(0); i++)
                    {
                        string currentUser, currentPassword;
                        currentUser = userData[i, 0];
                        currentPassword = userData[i, 1];

                        if (inputUser == currentUser && password == currentPassword)
                        {
                            banderaAcceso = false;
                            if (!banderaAcceso)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"Bienvenido, {currentUser}");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                        }
                    }
                    if (banderaAcceso)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Datos inválidos");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                else if (op == 2)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Creación de usuario");
                    Console.ForegroundColor = ConsoleColor.White;

                    CreacionLogin();
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Usuario creado con éxito.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            while (banderaAcceso);
        }
        public static void CreacionLogin()
        {
            string user, password;
            StreamWriter usuario = new StreamWriter("login.txt", true);

            Console.WriteLine("Digita tu usuario");
            user = Console.ReadLine();

            Console.WriteLine("Digita tu contraseña");
            password = Console.ReadLine();

            usuario.Write($"{user},{password}\n");
            usuario.Close();
        }
    }
}
