internal class Program
{
    private static void Main(string[] args)
    {
        double hours, speed, litros;

        hours = double.Parse(Console.ReadLine());
        speed = double.Parse(Console.ReadLine());

        litros = hours * speed / 12;

        Console.WriteLine(litros.ToString("F3"));
    }
}