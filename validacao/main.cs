using System;
using System.Globalization; 

namespace validacao {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;
            double media = 0, nota1 = 0, nota2 = 0;

            Console.Write("Digite a primeira Nota: ");
            do {
                nota1 = double.Parse(Console.ReadLine(), CI);
                if(nota1 < 0 || nota1 > 10) {
                    Console.Write("Valor invalido!Tente novamente: ");
                }
            } while (nota1 < 0 || nota1 > 10);

            Console.Write("Digite a segunda Nota: ");
            do {
                nota2 = double.Parse(Console.ReadLine(), CI);
                if (nota2 < 0 || nota2 > 10) {
                    Console.Write("Valor invalido!Tente novamente: ");
                }
            } while (nota2 < 0 || nota2 > 10);
            media = (nota1 + nota2) / 2.0;
            Console.WriteLine("MEDIA = " + media.ToString("F2", CI));
        }
    }
}
