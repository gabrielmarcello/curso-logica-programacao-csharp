﻿using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        string[] cor = Console.ReadLine().Split(' ');
        double x = double.Parse(cor[0], CultureInfo.InvariantCulture);
        double y = double.Parse(cor[1], CultureInfo.InvariantCulture);

        if (x == 0.0 & y == 0.0){
            Console.WriteLine("Origem");
        }
        else if (x == 0.0){
            Console.WriteLine("Eixo Y");
        }
        else if (y == 0.0){
            Console.WriteLine("Eixo X");
        }
        else if (x > 0.0 && y > 0.0){
            Console.WriteLine("Q1");
        }
        else if (x < 0.0 & y > 0.0){
            Console.WriteLine("Q2");
        }
        else if (x < 0.0 && y < 0.0){
            Console.WriteLine("Q3");
        }
        else{
            Console.WriteLine("Q4");
        }
    }
}