
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Program_2
{
    static void Main()
    {


        //Ejercicio 2

        Console.WriteLine("Bienvenido a la calculadora de factoriales");
        Console.WriteLine("Para comenzar a calcular seleccione 1");
        Console.WriteLine("Para salir seleccione 2");

        try
        {
            int response = int.Parse(Console.ReadLine());

            switch (response)
            {
                case 1:
                    Factorial();
                    break;
                case 2:
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("El numero debe ser 1 o 2");
                    break;
            }

        }
        catch { Console.WriteLine("No puede ser null"); }
    }

    private static void Factorial()
    {
        Console.WriteLine("Ingrese el numero que desea encontral su factorial");

        int resultado = int.Parse(Console.ReadLine());
        Int64 resultadoFactorial = 1;

        for (int i = 1; i <= resultado; i++)
        {

            resultadoFactorial *= i;

            Console.WriteLine(i);
        }
        Console.WriteLine($"El factorial de !{resultado} es:  " + resultadoFactorial);
    }
}
