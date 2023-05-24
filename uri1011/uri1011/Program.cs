using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        double R, volume, pi = 3.14159;

        R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        volume = 4 / 3.0 * pi * Math.Pow(R, 3);

        Console.WriteLine("VOLUME = " + volume.ToString("F3"), CultureInfo.InvariantCulture);
    }
}