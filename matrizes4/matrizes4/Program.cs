internal class Program
{
    private static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int[,] mat = new int[N, N];

        for (int i = 0; i < N; i++) {
            string[] s = Console.ReadLine().Split(' ');
            for (int j = 0; j < N; j++) {
                mat[i, j] = int.Parse(s[j]);
            }
        }

        int soma = 0;
        for (int i = 0; i < N; i++) {
            int soma = 0;
            for (int j = i + 1; j < N; j++) {
                soma = soma + mat[i, j];
            }
            Console.WriteLine(soma);
        }
    }
}