using System;
using System.Globalization;

namespace medidas {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            double a = 0, b = 0, c = 0, areaQuadrado = 0, areaTrapezio = 0, areaTriangulo = 0;

            Console.Write("Digite a medida A: ");
            a = double.Parse(Console.ReadLine(),CI);
            Console.Write("Digite a medida B: ");
            b = double.Parse(Console.ReadLine(),CI);
            Console.Write("Digite a medida C: ");
            c = double.Parse(Console.ReadLine(),CI);
            areaQuadrado = a * a;
            areaTriangulo = (a * b) / 2;
            areaTrapezio = c * (a + b) / 2;
            Console.WriteLine("AREA DO QUADRADO = " +areaQuadrado.ToString("F4",CI));
            Console.WriteLine("AREA DO TRIANGULO = " +areaTriangulo.ToString("F4", CI));
            Console.WriteLine("AREA DO TRAPEZIO = " +areaTrapezio.ToString("F4", CI));
            //16.0000
         //7.0000
         //19.5000
        }
    }
}
