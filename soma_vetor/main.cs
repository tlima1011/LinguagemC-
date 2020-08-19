using System;
using System.Globalization; 

namespace soma_vetor {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int n = 0;
            double soma = 0, media = 0; 

            Console.Write("Quantos numeros voce vai digitar? ");
            n = int.Parse(Console.ReadLine());

            double []numeros = new double[n]; 
            
            for(int i = 0; i < n; i++) {
                Console.Write("Digite " + (i + 1)+ "º numero: ");
                numeros[i] = double.Parse(Console.ReadLine(), CI);
            }
            Console.WriteLine();
            Console.Write("VALORES = ");
            for(int i = 0; i < n; i++) {
                Console.Write(numeros[i].ToString("F1",CI) + "   ");
                soma += numeros[i]; 
            }
            media = soma / n;
            Console.WriteLine();
            Console.WriteLine("SOMA = " + soma.ToString("F2", CI));
            Console.WriteLine("MEDIA = " + media.ToString("F2", CI));//  9.00
           
        }
    }
}
