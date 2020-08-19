using System;
using System.Globalization;

namespace lanchonete {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture; 

            int codigo = 0, quantidade = 0;
            double preco = 0; 
            
            Console.WriteLine("Codigo do produto comprado: ");
            codigo = int.Parse(Console.ReadLine());
            
            switch (codigo) {
                case 1:
                    Console.Write("Quantidade comprada: ");
                    quantidade = int.Parse(Console.ReadLine());
                    preco = quantidade * 5.0;
                    Console.WriteLine("Valor a pagar: R$"
                        + preco.ToString("F2", CI));
                    break;
                case 2:
                    Console.Write("Quantidade comprada: ");
                    quantidade = int.Parse(Console.ReadLine());
                    preco = quantidade * 3.50;
                    Console.WriteLine("Valor a pagar: R$"
                        + preco.ToString("F2", CI));
                    break;
                case 3:
                    Console.Write("Quantidade comprada: ");
                    quantidade = int.Parse(Console.ReadLine());
                    preco = quantidade * 4.80;
                    Console.WriteLine("Valor a pagar: R$"
                        + preco.ToString("F2", CI));
                    break;
                case 4:
                    Console.Write("Quantidade comprada: ");
                    quantidade = int.Parse(Console.ReadLine());
                    preco = quantidade * 8.90;
                    Console.WriteLine("Valor a pagar: R$"
                        + preco.ToString("F2", CI));
                    break;
                case 5:
                    Console.Write("Quantidade comprada: ");
                    quantidade = int.Parse(Console.ReadLine());
                    preco = quantidade * 7.32;
                    Console.WriteLine("Valor a pagar: R$"
                        + preco.ToString("F2", CI));
                    break;
                default:
                    Console.WriteLine("Invalido");
                    break;
            }    
        }
    }
}
