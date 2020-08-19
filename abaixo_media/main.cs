using System;
using System.Globalization;

namespace abaixo_media {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int n = 0;
            double soma = 0, media = 0; 

            Console.WriteLine("Quantos elementos vai ter o vetor?");
            n = int.Parse(Console.ReadLine());

            double [] numeros = new double[n]; 

            for(int i = 0; i < n; i++) {
                Console.Write("Digite o " + (i + 1) + "º número: ");
                numeros[i] = double.Parse(Console.ReadLine(), CI);
            }

            for(int i = 0; i < n; i++) {
                soma += numeros[i];
            }
            media = soma / n;
            Console.WriteLine();
            Console.WriteLine("MEDIA DO VETOR = " 
                +media.ToString("F3",CI)); //12.125
            Console.WriteLine("ELEMENTOS ABAIXO DA MEDIA:");
            for(int i = 0; i < n; i++) {
                if(numeros[i] < media) {
                    Console.WriteLine(numeros[i].ToString("F1",CI));
                }
            }
        }
    }
}
