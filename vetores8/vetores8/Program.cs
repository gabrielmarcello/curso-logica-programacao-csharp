using System.Globalization;
internal class Program
{
    private static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        double[] alturas = new double[N];
        char[] sexo = new char[N];

        for (int i = 0; i < N; i++) {
            string[] valores = Console.ReadLine().Split(' ');
            alturas[i] = double.Parse(valores[0]);
            sexo[i] = char.Parse(valores[1]);
        }
        double maiorAltura = alturas[0];
        for (int i = 0; i < N; i++) {
            if (alturas[i] > maiorAltura) {
                maiorAltura = alturas[i];
            }
        }
        double menorAltura = alturas[0];
        for (int i = 0; i < N; i++) {
            if (alturas[i] < menorAltura) {
                menorAltura = alturas[i];
            }
        }

        double somaAlturaFeminino = 0;
        int contFeminino = 0;

        for (int i = 0; i < N; i++) {
            if (sexo[i] == 'F') {
                somaAlturaFeminino = somaAlturaFeminino + alturas[i];
                contFeminino++;
            }
        }
        if (contFeminino == 0) {
            Console.WriteLine("Não há mulheres");
        }
        else
        {
            double media = somaAlturaFeminino / contFeminino;
            Console.WriteLine("Media das alturas das mulheres: " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
        int contMasculino = 0;
        for(int i = 0; i < N; i++) {
            if (sexo[i] == 'M') {
            contMasculino++;
            }
        }

        Console.WriteLine("Numero de homens: " + contMasculino);

    }
}