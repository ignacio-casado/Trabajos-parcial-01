using System;
using System.Globalization;
using System.Reflection;

class Program_1
    {
        static void Main()
        {
            //Ejercicio 1

            //declarando constantes
            const string letraE = "E";
            const string letraA = "A";
            const string letraO = "O";
            const string letraS = "S";
            const string letraR = "R";
            const string letraN = "N";
            const string space = " ";
            const string replaceSpace = "->";
            const string change = "x";

            //Date
            DateTime currentDateTime = DateTime.Now;

            //Input
            Console.WriteLine("Escriba el texto");
            string response = Console.ReadLine();

            try
            {
                if (response.Length >= 15)
                {
                    string encript = response.ToUpper();
                    encript = encript.Replace(letraE, change.ToString()).Replace(letraR, letraE).Replace(change.ToString(), letraR);
                    encript = encript.Replace(letraA, change.ToString()).Replace(letraS, letraA).Replace(change.ToString(), letraS);
                    encript = encript.Replace(letraO, change.ToString()).Replace(letraN, letraO).Replace(change.ToString(), letraN);
                    encript = encript.Replace(space, replaceSpace);

                    Console.WriteLine(encript + " " + currentDateTime);
                }
                else
                {
                    Console.WriteLine("El texto ingresado no es mayor a 15");
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }

        }
    }

