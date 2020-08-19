using System;
using System.Runtime.Serialization;

namespace numeros_pares {
    class Program {
        static void Main(string[] args) {

            int n = 0, qtde = 0, soma = 0; 

            Console.Write("Quantos numeros voce vai digitar? ");
            n = int.Parse(Console.ReadLine());

            int[] numeros = new int[n]; 

            for(int i = 0; i < n; i++) {
                Console.Write("Digite " + (i + 1 ) +"º numero: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("NUMEROS PARES: ");   
            for(int i = 0; i < n; i++) {
                if (numeros[i] % 2 == 0) {
                    Console.Write(numeros[i] + "  ");
                    soma++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("QUANTIDADE DE PARES = " +soma); 
        }
    }
}
