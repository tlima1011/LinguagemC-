using System;

namespace soma_impares {
    class Program {
        static void Main(string[] args) {

            int troca = 0, x = 0, y = 0, soma = 0; 

            Console.WriteLine("Digite dois números: ");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            if(x > y) {
                troca = x;
                x = y;
                y = troca; 
            }
            for(int i = x + 1; i < y; i++) {
                if(i % 2 != 0) {
                    soma += i;
                }
            }
            Console.WriteLine("SOMA DOS IMPARES = " + soma);
        }
    }
}
