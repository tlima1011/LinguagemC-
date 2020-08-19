using System;
using System.Globalization;

namespace temperatura {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            double f = 0, c = 0; 
            char conversao; 
            
            Console.Write("Voce vai digitar a temperatura em qual escala(C/ F)? ");
            conversao = char.Parse(Console.ReadLine());
            conversao = char.ToUpper(conversao);
            switch (conversao) {
                case 'F':
                    Console.Write("Digite a temperatura em Fahrenheit: ");
                    f = double.Parse(Console.ReadLine(), CI);
                    c = 5/9.0 * (f - 32);
                    Console.WriteLine("Temperatura equivalente em Celsius: " 
                        +c.ToString("F2",CI)+"ºC");
                    break;
                case 'C':
                    Console.Write("Digite a temperatura em Celsius: ");
                    c = double.Parse(Console.ReadLine(), CI);
                    f = c * (9 / 5.0) +32;
                    Console.WriteLine("Temperatura equivalente em Fahrenheit: "
                        + f.ToString("F2", CI)+"ºF");
                    break;
                default:
                    Console.WriteLine("Inválido");
                    break;
            }
        }
    }
}
