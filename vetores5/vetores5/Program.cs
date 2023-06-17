internal class Program
{
    private static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int[] V = new int[N];


        string[] valores = Console.ReadLine().Split(' ');
        for (int i = 0; i < N; i++) {
            V[i] = int.Parse(valores[i]);
        }
        int soma = 0;
        int cont = 0;
        for (int i = 0; i < N; i++) {
            if (V[i] % 2 == 0) {
                soma = soma + V[i];
                cont++;
            }
        }
        int media = soma / cont;

        Console.WriteLine(media);
    }
}