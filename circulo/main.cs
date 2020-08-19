using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace circulo {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            double area = 0, raio = 0; 

            Console.Write("Digite o valor do raio do circulo: ");
            raio = double.Parse(Console.ReadLine());
            area = Math.PI * (Math.Pow(raio, 2));
            Console.WriteLine("AREA = " +area.ToString("F3", CI));
        }
    }
}
