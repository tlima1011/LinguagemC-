using System;
using System.Globalization; 

namespace negativos {
    class Program {
        static void Main(string[] args) {

            int n = 0; 

            Console.Write("Quantos numeros voce vai digitar? ");
            n = int.Parse(Console.ReadLine());

            int[] numeros = new int[n]; 

            for(int i = 0; i < n; i++) {
                Console.Write("Digite " +(i + 1) + "º numero: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("NUMEROS NEGATIVOS:");
            for(int i = 0;i < n; i++) {
                if (numeros[i] < 0) {
                    Console.WriteLine(numeros[i]);
                }
            }

        }
    }
}
