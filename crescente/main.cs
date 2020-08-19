using System;

namespace crescente {
    class Program {
        static void Main(string[] args) {

            int x = 0, y = 0;

            Console.WriteLine("Digite dois numeros: ");

            do {
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());
                if (x > y) {
                    Console.WriteLine("DECRESCENTE!");
                }
                else if (x < y) {
                    Console.WriteLine("CRESCENTE!");
                }
                else {
                    break;
                }
                Console.WriteLine("Digite outros dois numeros:");
            } while (x != y);
        }
    }
}
