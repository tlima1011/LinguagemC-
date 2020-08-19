using System;
using System.Globalization; 

namespace operadora {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int minutos = 0;
            double valor = 0; 

            Console.Write("Digite a quantidade de minutos: ");
            minutos = int.Parse(Console.ReadLine());
            valor = 50; 
            if(minutos > 100) {
                valor = valor + 2 * (minutos - 100);
            }
            Console.WriteLine("Valor a pagar: R$" + valor.ToString("F2", CI));
        }
    }
}
