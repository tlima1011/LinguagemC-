using System;

namespace tabuada {
    class Program {
        static void Main(string[] args) {

            int n = 0, produto = 0; 

            Console.Write("Deseja a tabuada para qual valor? ");
            n = int.Parse(Console.ReadLine()); 

            for(int i = 1; i <= 10; i++) {
                produto = n * i;
                Console.WriteLine(n + " X " + i + " = " + produto); 
            }
        }
    }
}
