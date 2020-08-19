using System;

namespace soma {
    class Program {
        static void Main(string[] args) {

            int x = 0, y = 0, soma = 0; 
            Console.Write("Informe o valor de X: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Informe o valor de Y: "); 
            y = int.Parse(Console.ReadLine());
            soma = x + y;
            Console.WriteLine("SOMA = " +soma);  

        }
    }
}
