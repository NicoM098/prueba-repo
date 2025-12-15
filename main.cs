using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        
        int randomNumber = random.Next(1, 101);
        Console.WriteLine($"Random number between 1 and 100: {randomNumber}");
        
        string[] colors = { "Red", "Blue", "Green", "Yellow", "Purple" };
        string randomColor = colors[random.Next(colors.Length)];
        Console.WriteLine($"Random color: {randomColor}");
    }
}