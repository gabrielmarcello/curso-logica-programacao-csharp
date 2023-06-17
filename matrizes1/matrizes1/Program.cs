internal class Program
{
    private static void Main(string[] args)
    {
        string[] s = Console.ReadLine().Split(' ');
        int M = int.Parse(s[0]);
        int N = int.Parse(s[1]);

        int[,] mat = new int[M, N];

        for (int i = 0; i < M; i++) {
            string[] s1 = Console.ReadLine().Split(' ');
            for (int j = 0; j < N; j++) {
                mat[i, j] = int.Parse(s1[j]);
            }
        }


        Console.WriteLine("VALORES NEGATIVOS:");
        for(int i = 0; i< M; i++) {
            for (int j = 0; j < N; j++) {
                if (mat[i, j] < 0) {
                    Console.WriteLine(mat[i, j]);
                }
            }
        }
    }
}