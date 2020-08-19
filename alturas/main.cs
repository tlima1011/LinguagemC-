using System;
using System.Globalization;

namespace alturas {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int n = 0, menor16 = 0;
            double porc_menor = 0, soma = 0, media = 0;

            Console.Write("Quantas pessoas serao digitadas? ");
            n = int.Parse(Console.ReadLine());

            String[] nomes = new String[n];
            int[] idades = new int[n];
            double[] alturas = new double[n];

            for (int i = 0; i < n; i++) {
                Console.WriteLine("Dados da " + (i + 1) + "ª pessoa: ");
                Console.Write("Nome: ");
                nomes[i] = Console.ReadLine();
                Console.Write("Idade: ");
                idades[i] = int.Parse(Console.ReadLine());
                Console.Write("Altura: ");
                alturas[i] = double.Parse(Console.ReadLine(), CI);
            }

            for (int i = 0; i < n; i++) {
                soma += alturas[i];
            }
            media = soma / n;
            Console.Write("Altura média: " + media.ToString("F2", CI));

            for (int i = 0; i < n; i++) {
                if (idades[i] < 16) {
                    menor16++;
                }
            }
            porc_menor = menor16 * 100 / n;
            Console.WriteLine();
            Console.WriteLine("Pessoas com menos de 16 anos: "
                        + porc_menor.ToString("F1", CI) + "%"); // 40.0 %
            for (int i = 0; i < n; i++) {
                if (idades[i] < 16) {
                    Console.WriteLine(nomes[i]);
                }
            }
        }
    }
}
