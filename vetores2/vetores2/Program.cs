

internal class Program
{
    private static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int[] vet = new int[N];

        string[] valores = Console.ReadLine().Split(' ');

        for (int i = 0; i < N; i++) {
            vet[i] = int.Parse(valores[i]);
        }

        for (int i = 0; i < N; i++) {
            if (vet[i] % 2 == 0) {
                Console.Write(vet[i] + " ");
            }
        }
        Console.WriteLine();
        
        int quantPares = 0;
        for (int i = 0; i < N; i++) {
                if (vet[i] % 2 == 0) {
                    quantPares++;
                }
            }
        Console.WriteLine(quantPares);
    }
}