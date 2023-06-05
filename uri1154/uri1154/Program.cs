using System;
using System.Globalization;
internal class Program
{
    private static void Main(string[] args)
    {
        int idade = int.Parse(Console.ReadLine());
        int quant = 0;
        int soma = 0;

        while (idade >= 0) {
            quant += 1;
            soma += idade;
            idade = int.Parse(Console.ReadLine()); 
        }

        double media = (double)soma / quant;

        Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
    }
}