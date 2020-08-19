using System;
using System.Globalization; 

namespace notas {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            double nota1 = 0, nota2 = 0, notaFinal = 0;
            
            Console.Write("Digite a primeira nota: ");
            nota1 = double.Parse(Console.ReadLine(), CI);
            Console.Write("Digite a segunda nota: ");
            nota2 = double.Parse(Console.ReadLine(), CI);
            notaFinal = nota1 + nota2;
            Console.WriteLine("NOTA FINAL = " + notaFinal.ToString("F1", CI));
            if(notaFinal < 60) {
                Console.WriteLine("REPROVADO");
            }
        }
    }
}
