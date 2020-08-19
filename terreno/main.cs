using System;
using System.Globalization;

namespace terreno {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            double largura = 0, b = 0, valor = 0, area = 0, preco = 0;

            Console.Write("Digite a largura do terreno: ");
            largura = double.Parse(Console.ReadLine());
            Console.Write("Digite o comprimento do terreno: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor do metro quadrado: ");
            valor = double.Parse(Console.ReadLine());
            area = largura * b;
            preco = valor * area;
            Console.WriteLine("Area do terreno = " +area.ToString("F2", CI));
            Console.WriteLine("Preco do terreno = " +preco.ToString("F2", CI));
        }
    }
}
