using System;
using System.Globalization;

namespace aprovados {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int n = 0, num_aprovados = 0;

            Console.Write("Quantos alunos serao digitados? ");
            n = int.Parse(Console.ReadLine());

            String[] nomes = new string[n];
            double[] notas1 = new double[n];
            double[] notas2 = new double[n];
            double[] medias = new double[n];

            for (int i = 0; i < n; i++) {
                Console.WriteLine("Digite nome, primeira e segunda nota do " + (i + 1) + "º aluno:");
                nomes[i] = Console.ReadLine();
                notas1[i] = double.Parse(Console.ReadLine(), CI);
                notas2[i] = double.Parse(Console.ReadLine(), CI);
            }

            for (int i = 0; i < n; i++) {
                medias[i] = (notas1[i] + notas2[i]) / 2;
            }

            Console.WriteLine("Alunos aprovados:");
            for (int i = 0; i < n; i++) {
                if(medias[i] >= 6) {
                    Console.WriteLine(nomes[i]);
                    num_aprovados++;
                }
            }
            Console.WriteLine("Quantidade de aprovados.: " +num_aprovados);
        }
    }
}
