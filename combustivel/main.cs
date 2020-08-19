using System;
using System.Globalization;

namespace combustivel {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int alcool = 0, gasolina = 0, diesel = 0, codigo = 0;

            do {
                Console.Write("Informe um codigo (1, 2, 3) ou 4 para parar: ");
                codigo = int.Parse(Console.ReadLine());
                switch (codigo) {
                    case 1:
                        alcool++;
                        break;
                    case 2:
                        gasolina++;
                        break;
                    case 3:
                        diesel++;
                        break;
                }
            } while (codigo != 4);
            Console.WriteLine();
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel); 
        }
    }
}
