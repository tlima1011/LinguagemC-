using System;
using System.Globalization; 

namespace media_idades {
    class Program {
        static void Main(string[] args) {

            int idade = 0, cont = 0;
            double media = 0, soma = 0;

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.WriteLine("Digite as idades: ");
            idade = int.Parse(Console.ReadLine());
            if (idade < 0) {
                Console.WriteLine("IMPOSSIVEL CALCULAR");
            }
            else {
                do {
                    soma += idade;
                    idade = int.Parse(Console.ReadLine());
                    cont++; 
                } while (idade >= 0);
                media = soma / cont;
                Console.WriteLine("MEDIA = " + media.ToString("F2", CI));
            }
        }
    }
}
