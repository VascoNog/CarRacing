using System.Net.WebSockets;

namespace CarRacing.app;

internal class Car
{
    // Properties -> Convenção: Uppercase
    // Variáveis privadas da classe, posso representar com "_", exeplo "_xpto".
    public int Kms { get; set; }

    public string Make { get; set; }

    public string Symbol { get; set; }  

    public ConsoleColor Color { get; set; }

    public Car(string make, string symbol)
    {
        Make = make;
        Symbol = symbol;
        Color = (ConsoleColor)Random.Shared.Next(0, 16);
    }

    // Construtor Parameterless
    public Car()
    {
    }

 
    public void Speed(int maxKms = 10)
    {
        Kms += Random.Shared.Next(1, maxKms + 1);
    }

    public int GetKms()
    { 
        return Kms; 
    }
    
    public void Print()
    {
      
        Console.ForegroundColor = Color;
        for (int i = 0; i < Kms; i++)
            Console.Write(Symbol);
        Console.ResetColor();

        Console.WriteLine($"Kms: {Kms} [{Make}]");
    }
}