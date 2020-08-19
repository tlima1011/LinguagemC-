using System;
using System.Globalization;

namespace media_pares {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int n = 0, cont = 0;
            double soma = 0, media = 0; 

            Console.Write("Quantos elementos vai ter o vetor? ");
            n = int.Parse(Console.ReadLine());

            int[] numeros = new int[n];

            for(int i = 0;i < n; i++) {
                Console.Write("Digite o " +(i + 1) +"º numero: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }
            
            for(int i = 0; i < n; i++) {
                if(numeros[i] % 2 == 0) {
                    soma += numeros[i];
                    cont++;
                }
            }
            if(cont == 0) {
                Console.WriteLine("NENHUM NUMERO PAR");
            }
            else {
                media = soma / cont;
                Console.WriteLine("MEDIA DOS PARES = " + media.ToString("F1", CI));
            }
        }
    }
}
