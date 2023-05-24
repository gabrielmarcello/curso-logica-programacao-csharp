using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        int number, hours;
        double perhour, salario;

        number = int.Parse(Console.ReadLine());
        hours = int.Parse(Console.ReadLine());
        perhour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


        salario = hours * perhour;

        Console.WriteLine("NUMBER = " + number);
        Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
    }
}