using System;

internal class Program
{
    private static void Main(string[] args)
    {
        string p1 = Console.ReadLine();
        string p2 = Console.ReadLine();
        string p3 = Console.ReadLine();

        if (p1 == "vertebrado") {
            if (p2 == "ave") {
                if (p3 == "carnivoro") {
                    Console.WriteLine("aguia");
                }
                else {
                    Console.WriteLine("pomba");
                }
            }
            else {
                if (p3 == "onivoro") {
                    Console.WriteLine("homem");
                }
                else {
                    Console.WriteLine("vaca");
                }
            }
        }
        else {
            if (p2 == "inseto") {
                if (p3 == "hematofago") {
                    Console.WriteLine("pulga");
                }
                else {
                    Console.WriteLine("lagarta");
                }
            }
            else {
                if (p3 == "hematofago") {
                    Console.WriteLine("sanguessuga");
                }
                else {
                    Console.WriteLine("minhoca");
                }
            }
        }
    }
}