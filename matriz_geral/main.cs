using System;
using System.Globalization;

namespace matriz_geral {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int n = 0, linha = 0, coluna = 0;
            double soma = 0;

            Console.WriteLine("Qual a ordem da matriz? ");
            n = int.Parse(Console.ReadLine());

            double[,] mat = new double[n, n];

            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    Console.Write("Elemento[" + i + "," + j + "]: ");
                    mat[i, j] = double.Parse(Console.ReadLine(), CI);
                }
            }

            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    if (mat[i, j] > 0) {
                        soma += mat[i, j];
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("SOMA DOS POSITIVOS: " + soma.ToString("F1", CI));
            Console.WriteLine();

            Console.Write("Escolha uma linha: ");
            linha = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("LINHA ESCOLHIDA: ");
            for (int j = 0; j < n; j++) {
                Console.Write(mat[linha, j].ToString("F1", CI) + "  ");
            }

            //-2.0 3.0 5.0
            Console.WriteLine();
            Console.Write("Escolha uma coluna: ");
            coluna = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("COLUNA ESCOLHIDA: ");// 10.0 5.0 4.0
            for (int i = 0; i < n; i++) {
                Console.Write(mat[i, coluna].ToString("F1", CI) + "  ");
            }
            Console.WriteLine();
            Console.Write("DIAGONAL PRINCIPAL: "); //7.0 3.0 4.0
            for (int i = 0; i < n; i++) {
                Console.Write(mat[i, i].ToString("F1", CI) + "  ");
            }
            Console.WriteLine();
            Console.WriteLine("MATRIZ ALTERADA:");
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    if (mat[i, j] < 0) {
                        Console.Write(Math.Pow(mat[i, j], 2).ToString("F1", CI) + "  ");
                    }
                    else {
                        Console.Write(mat[i, j].ToString("F1", CI) + "  ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
