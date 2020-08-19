using System;

namespace sequencia_impares {
    class Program {
        static void Main(string[] args) {

            int x = 0; 

            Console.Write("Digite o valor de X: ");
            x = int.Parse(Console.ReadLine()); 
            for(int i = 0; i <= x; i++) {
                if( i % 2 != 0) {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
