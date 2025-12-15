using System;

class Program
{
    static void Main()
    {
        // Esta es la version 1.0
        Random random = new Random();
        
        // Genera y registra un número aleatorio entre 1 y 100
        int number = GenerateRandomNumber(random, 1, 100);

        Console.WriteLine("Number: " + number);
    }

    /// Genera un número aleatorio en el rango [min, max], lo escribe por consola y lo devuelve.
    static int GenerateRandomNumber(Random rng, int min = 0, int max = 100)
    {
        // Random.Next upper bound is exclusive, por eso usamos max + 1 para incluir max
        int value = rng.Next(min, max + 1);
        Console.WriteLine($"Generated random number: {value}");
        return value;
    }
}