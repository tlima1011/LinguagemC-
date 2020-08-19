using System;

namespace fatorial {
    class Program {
        static void Main(string[] args) {

            int f = 1, n = 0;

            Console.Write("Digite o valor de N: ");
            n = int.Parse(Console.ReadLine()); 
            for(int i = 1; i <= n; i++) {
                f *= i;
            }
            Console.WriteLine("FATORIAL = " +f);
        }
    }
}
