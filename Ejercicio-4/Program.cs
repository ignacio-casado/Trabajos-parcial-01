using System;
using System.Runtime.Serialization.Formatters;

class Program_4
{
    static void Main()
    {
        int jugadorUno = 0;
        int jugadorDos = 1;

        Random rnd = new Random();
        int random1 = rnd.Next(1, 7);
        int random2 = rnd.Next(1, 7);

        Console.WriteLine($"jugador {jugadorUno} has sacado: {random1} ");
        Console.WriteLine($"jugador {jugadorDos} has sacado: {random2} ");

        if (random1 > random2 && random1 >= 3)
        {
            Console.WriteLine($"Inicia jugador {jugadorUno}");
            int jugadorGanador = jugadorUno;
            int jugadorPerdedor = jugadorDos;
            Juego(jugadorGanador, jugadorPerdedor);
        }
        else if (random2 > random1 && random2 >= 3)
        {
            Console.WriteLine($"Inicia jugador {jugadorDos}");
            int jugadorGanador = jugadorDos;
            int jugadorPerdedor = jugadorUno;
            Juego(jugadorGanador, jugadorPerdedor);
        }
        else if (random1 == random2)
        {
            Console.WriteLine("Va de nuevo");
            Inicio();
        }
        else if (random1 > random2 || random2 > random1 && random1 < 3 || random2 < 3)
        {
            Console.WriteLine("va de nuevo");
            Inicio();
        }


    }
    private static void Inicio()
    {
        int jugador1 = 0;
        int jugador2 = 1;

        Random rnd = new Random();
        int random1 = rnd.Next(1, 7);
        int random2 = rnd.Next(1, 7);

        Console.WriteLine($"jugador  {0} has sacado: {random1} ");
        Console.WriteLine($"jugador  {1} has sacado: {random2} ");

        if (random1 > random2 && random1 >= 3)
        {
            Console.WriteLine("Inicia jugador {0}", jugador1);
            int jugadorGanador = jugador1;
            int jugadorPerdedor = jugador2;
            Juego(jugadorGanador, jugadorPerdedor);
        }
        else if (random2 > random1 && random2 >= 3)
        {
            Console.WriteLine("Inicia jugador {0}", jugador2);
            int jugadorGanador = jugador2;
            int jugadorPerdedor = jugador1;
            Juego(jugadorGanador, jugadorPerdedor);
        }
        else if (random1 == random2)
        {
            Console.WriteLine("Va de nuevo");
            Inicio();
        }
        else if (random1 > random2 || random2 > random1 && random1 < 3 || random2 < 3)
        {
            Console.WriteLine("va de nuevo");
            Inicio();
        }

    }
    private static void Juego(int jugadorGanador, int jugadorPerdedor)
    {
        int[] portales = { 6, 12, 24, 48 };
        int[] agujerosNegros = { 32, 38, 53 };

        int[] lugares = new int[2];
        int currentPlayer = jugadorGanador;

        while (true)
        {
            // Wait for user to press a key

            Console.WriteLine("Jugador {0}, presione una tecla para tirar el dado", currentPlayer);
            Console.ReadKey(true);

            //Simulate dice roll
            Random random = new Random();
            int dado = random.Next(1, 7);

            // Move current player's position
            lugares[currentPlayer] += dado;

            // Check if player has won

            if (lugares[currentPlayer] >= 64)
            {
                Console.WriteLine("Jugador {0} gano!!!!!!", currentPlayer);
                break;

            }
            if (lugares[currentPlayer] % 10 == 0)
            {
                Console.WriteLine("Jugador {0} saco {1} Y SUMO 10 POSICIONES CASILLERO RELAY",
                currentPlayer, dado, lugares[currentPlayer] + 10);
                //continue;
            }
            if (lugares[currentPlayer] == 6)
            {
                Console.WriteLine("Jugador {0} saco {1} y SE HA TELETRASNPORTADO A {2}, HA CAIDO EN CASILLERO PORTAL",
                currentPlayer, dado, lugares[currentPlayer] + 6);
                // continue;
            }
            if (lugares[currentPlayer] == 12)
            {
                Console.WriteLine("Jugador {0} saco {1} y SE HA TELETRASNPORTADO A {2}, HA CAIDO EN CASILLERO PORTAL",
                currentPlayer, dado, lugares[currentPlayer] - 6);
                // continue;
            }
            if (lugares[currentPlayer] == 24)
            {
                Console.WriteLine("Jugador {0} saco {1} y sSE HA TELETRASNPORTADO A {2} , HA CAIDO EN CASILLERO PORTAL",
               currentPlayer, dado, lugares[currentPlayer] + 24);
                //  continue;
            }
            if (lugares[currentPlayer] == 48)
            {
                Console.WriteLine("Jugador {0} saco {1} SE HA TELETRASNPORTADO A {2} , HA CAIDO EN CASILLERO PORTAL",
               currentPlayer, dado, lugares[currentPlayer] - 24);
                // continue;

            }
            if (lugares[currentPlayer] == 32 || lugares[currentPlayer] == 38 || lugares[currentPlayer] == 53)
            {

                Console.WriteLine("Jugador {0} saco {1} HA CAIDO EN UN AGUJERO NEGRO {2}",
              currentPlayer, dado, lugares[currentPlayer] / lugares[currentPlayer]);
                lugares[currentPlayer] = 0;
            }
            //  Print current player's position

            Console.WriteLine("Jugador {0} saco {1} y se a movido a {2}",
            currentPlayer, dado, lugares[currentPlayer]);
            // Switch to next player
            currentPlayer = (currentPlayer + 1) % 2;

        }
    }
}
