using System;
using System.Security.Cryptography.X509Certificates;

namespace pares_consecutivos {
    class Program {
        static void Main(string[] args) {

            int soma = 0, x = 0;

            do {
                Console.Write("Digite um número inteiro: ");
                x = int.Parse(Console.ReadLine());
                if( x % 2 != 0) {
                    x++;   
                }
                soma = 5 * x + 20;
             
            } while (x == 0); 
            Console.WriteLine("SOMA = " +soma);
        }
    }
}
