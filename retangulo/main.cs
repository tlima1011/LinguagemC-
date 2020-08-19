using System;
using System.Globalization;

namespace retangulo {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            double largura = 0, b = 0, diagonal = 0, area = 0, perimetro = 0;

            Console.Write("Base do retangulo: ");
            b = double.Parse(Console.ReadLine(),CI); 
            
            Console.Write("Altura do retangulo: ");
            largura = double.Parse(Console.ReadLine(),CI);

            area = b * largura;
            perimetro = 2 * (b + largura);
            diagonal = Math.Sqrt(Math.Pow(b, 2) + Math.Pow(largura, 2));
            
            Console.WriteLine("AREA = " + area.ToString("F4", CI));
            Console.WriteLine("PERIMETRO = " +perimetro.ToString("F4", CI));
            Console.WriteLine("DIAGONAL = " +diagonal.ToString("F4", CI));
        }
    }
}
