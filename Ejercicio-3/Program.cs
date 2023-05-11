using System;

class Program_3
{
    static void Main()
    {
        //Ejercicio 3
        Console.WriteLine("Ingrese su apuesta");
        int response = int.Parse(Console.ReadLine());
        try
        {
            if (response >= 0 && response <= 36)
            {
                const int chances = 5;
                Random random = new Random();
                int contador = 0;
                for (int i = 0; i < chances; i++)
                {
                    contador++;
                    int random1 = random.Next(0, 36);
                    Console.WriteLine($"Numero que salio en la ruleta {contador}");
                    Console.WriteLine(random1);
                    if (random1 == response)
                    {
                        Console.WriteLine("HAS GANADO");
                        break;
                    }
                    else { Console.WriteLine("No has ganado"); }
                }

            }
            else { Console.WriteLine("Los valores de la ruleta van de  0 a 36"); }

        }
        catch (Exception ex) { Console.WriteLine(ex.ToString()); }

    }

}