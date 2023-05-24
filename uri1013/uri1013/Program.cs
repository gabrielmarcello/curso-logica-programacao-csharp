internal class Program
{
    private static void Main(string[] args)
    {
        int a, b, c, ab, abc;

        string[] vet = Console.ReadLine().Split(' ');
        a = int.Parse(vet[0]);
        b = int.Parse(vet[1]);
        c = int.Parse(vet[2]);

        ab = (a + b + Math.Abs(a - b)) / 2;

        abc = (ab + c + Math.Abs(ab - c)) / 2;

        Console.WriteLine(abc + " eh o maior");
    }
}