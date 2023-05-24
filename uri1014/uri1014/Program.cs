using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        int X = int.Parse(Console.ReadLine());
        double Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double consumo = X / Y;

        Console.WriteLine(consumo.ToString("F3") + " km/l");
    }
}