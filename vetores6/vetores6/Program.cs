internal class Program
{
    private static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int[] idades = new int[N];
        string[] nomes = new string[N];

        for (int i = 0; i < N; i++) {
            string[] valores = Console.ReadLine().Split(' ');
            nomes[i] = valores[0];
            idades[i] = int.Parse(valores[1]);
        }
        
        int maiorIdade = idades[0];
        int posicaoMaiorIdade = 0;
        for (int i = 0; i < N; i++) {
           if (idades[i] > maiorIdade) {
                maiorIdade = idades[i];
                posicaoMaiorIdade = i;
            }
         }

        Console.WriteLine("Pessoa mais velha: " + nomes[posicaoMaiorIdade]);
    }
}