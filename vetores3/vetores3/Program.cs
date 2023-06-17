internal class Program
{
    private static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        
        int[] A = new int[N];
        int[] B = new int[N];

        string[] valores = Console.ReadLine().Split(' ');
        for (int i = 0; i < N; i++) {
            A[i] = int.Parse(valores[i]);
        }

        valores = Console.ReadLine().Split(' ');
        for (int i = 0; i < N; i++) {
            B[i] = int.Parse(valores[i]);
        }

        int[] C = new int[N];

        for (int i = 0; i < N; i++) {
            C[i] = A[i] + B[i];
            Console.Write(C[i] + " ");
        }
    }
}