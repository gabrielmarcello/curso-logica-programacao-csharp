using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        double[] A = new double[N];

        string[] valores = Console.ReadLine().Split(' ');

        for (int i = 0; i < N; i++) {
            A[i] = double.Parse(valores[i], CultureInfo.InvariantCulture);
        }

        double soma = 0.0;
        for (int i = 0; i < N; i++) {
            soma = soma + A[i];
        }

        double media = soma / N;
        Console.WriteLine("MEDIA = " + media.ToString("F3", CultureInfo.InvariantCulture));

        for (int i = 0; i < N; i++) {
            if (A[i] < media) {
                Console.WriteLine(A[i].ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}