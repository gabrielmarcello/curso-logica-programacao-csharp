using System;
internal class Program
{
    private static void Main(string[] args)
    {
        int alcool = 0;
        int gasolina = 0;
        int diesel = 0;

        int combustivel = int.Parse(Console.ReadLine());

        while (combustivel != 4)
        {
            if (combustivel == 1)
            {
                alcool += 1;
            }
            else if (combustivel == 2)
            {
                gasolina += 1;
            }
            else if (combustivel == 3)
            {
                diesel += 1;
            }

            combustivel = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("MUITO OBRIGADO");
        Console.WriteLine("Alcool: " + alcool);
        Console.WriteLine("Gasolina: " + gasolina);
        Console.WriteLine("Diesel: " + diesel);
    }
}