using System;

namespace multiplos {
    class Program {
        static void Main(string[] args) {

            int n1 = 0, n2 = 0;

            Console.WriteLine("Digite dois numeros inteiros: ");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            if(n1 % n2 == 0 || n2 % n1 == 0) {
                Console.WriteLine("São multiplos");
            }
            else {
                Console.WriteLine("Não São multiplos");
            }
        }
    }
}
