using System;
using System.Globalization;

namespace media_ponderada {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            double num1 = 0, num2 = 0, num3 = 0, media = 0;
            int n = 0;

            Console.Write("Quantos casos voce vai digitar? ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                Console.WriteLine("Digite tres numeros: ");
                num1 = double.Parse(Console.ReadLine(), CI);
                num2 = double.Parse(Console.ReadLine(), CI);
                num3 = double.Parse(Console.ReadLine(), CI);
                media = (2 * num1 + 3 * num2 + 5 * num3) / 10;
                Console.WriteLine("MEDIA = "
                    + media.ToString("F1", CI));
            }
        }
    }
}
