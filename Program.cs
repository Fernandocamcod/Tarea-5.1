using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int numeroAleatorio = random.Next(1, 101); // Genera un número aleatorio entre 1 y 100
        int intento = 0;
        int numeroUsuario;

        Console.WriteLine("¡Bienvenido al juego de adivinanzas!");
        Console.WriteLine("He generado un número aleatorio entre 1 y 100. Intenta adivinarlo.");

        while (intento != numeroAleatorio)
        {
            Console.Write("Introduce tu intento: ");
            string input = Console.ReadLine();

            // Verifica que la entrada del usuario es un número válido
            if (int.TryParse(input, out numeroUsuario))
            {
                if (numeroUsuario < 1 || numeroUsuario > 100)
                {
                    Console.WriteLine("Por favor, introduce un número entre 1 y 100.");
                }
                else
                {
                    intento = numeroUsuario;

                    if (intento < numeroAleatorio)
                    {
                        Console.WriteLine("Demasiado bajo. Intenta nuevamente.");
                    }
                    else if (intento > numeroAleatorio)
                    {
                        Console.WriteLine("Demasiado alto. Intenta nuevamente.");
                    }
                    else
                    {
                        Console.WriteLine("¡Felicidades! ¡Has adivinado el número!");
                    }
                }
            }
            else
            {
                Console.WriteLine("Por favor, introduce un número válido.");
            }
        }

        // Mantiene la consola abierta hasta que el usuario presione una tecla
        Console.WriteLine("Presiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}
