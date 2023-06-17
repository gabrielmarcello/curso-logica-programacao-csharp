﻿using System.Globalization;
internal class Program
{
    private static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        double[,] mat = new double[N, N];

        for (int i = 0; i < N; i++) {
            string[] valores = Console.ReadLine().Split(' ');
            for (int j = 0; j < N; j++) {
                mat[i, j] = double.Parse(valores[j], CultureInfo.InvariantCulture);
            }
        }

        int linha = int.Parse(Console.ReadLine());
        int coluna = int.Parse(Console.ReadLine());

        double somaPositivos = 0.0;
        for (int i = 0; i < N; i++) {
            for (int j = 0; j < N; j++) {
                if (mat[i, j] > 0) {
                    somaPositivos = somaPositivos + mat[i, j];
                }
            }
        }
        Console.WriteLine("SOMA DOS POSITIVOS: " + somaPositivos.ToString("F1", CultureInfo.InvariantCulture));

        Console.Write("LINHA ESCOLHIDA: ");
        for(int j = 0; j < N; j++) {
            Console.Write(mat[linha, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
        }
        Console.WriteLine();

        Console.Write("COLUNA ESCOLHIDA: ");
        for(int i = 0; i < N; i++) {
            Console.Write(mat[i, coluna].ToString("F1", CultureInfo.InvariantCulture) + " ");
        }
        Console.WriteLine();

        Console.Write("DIAGONAL PRINCIPAL: ");
        for(int i = 0; i < N; i++) {
                Console.Write(mat[i, i].ToString("F1", CultureInfo.InvariantCulture) + " "); 
        }
        Console.WriteLine();

        for(int i = 0; i < N; i++) {
            for(int j = 0; j < N; j++) {
                if ((mat[i,j]) < 0.0) {
                    mat[i, j] = mat[i, j] * mat[i,j];
                }
            }
        }
        Console.WriteLine("MATRIZ ALTERADA: ");
        for(int i = 0; i < N; i++) {
            for(int j = 0; j < N; j++) {
                Console.Write(mat[i, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();
        }
    }
}