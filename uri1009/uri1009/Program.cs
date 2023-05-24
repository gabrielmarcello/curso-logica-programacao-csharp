using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        string vendedor = Console.ReadLine();
        double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double vendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double total = 15.0 / 100 * vendas + salario;

        Console.WriteLine("TOTAL = R$ " + total.ToString("F2"));
    }
}