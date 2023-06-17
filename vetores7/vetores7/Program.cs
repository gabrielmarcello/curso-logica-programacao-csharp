﻿using System.Globalization;
internal class Program
{
    private static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        string[] nomes = new string[N];
        double[] nota1 = new double[N];
        double[] nota2 = new double[N];

        for (int i = 0; i < N; i++) {
            string[] valores = Console.ReadLine().Split(' ');
            nomes[i] = valores[0];
            nota1[i] = double.Parse(valores[1],CultureInfo.InvariantCulture);
            nota2[i] = double.Parse(valores[2], CultureInfo.InvariantCulture);
        }
        Console.WriteLine("Alunos Aprovados: ");
        for (int i = 0; i< N; i++) {
            double media = (nota1[i] + nota2[i]) / 2.0;
            if (media >= 6) {
                Console.WriteLine(nomes[i]);
            }
        }
    }
}