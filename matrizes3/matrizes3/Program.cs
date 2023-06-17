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

        int maiorElemento;
        for (int i = 0; i < N; i++) {
            maiorElemento = mat[i, 0];
            for (int j = 0; j < N; j++) {
                if (mat[i, j] > maiorElemento) {
                    maiorElemento = mat[i, j];
                }
            }
            Console.WriteLine(maiorElemento);
        }
    }
}