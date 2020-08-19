using System;
using System.Globalization; 

namespace troco {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            double unitario = 0, preco = 0, dinheiro = 0, troco = 0;
            int quantidade = 0; 

            Console.Write("Preço unitário do produto R$");
            unitario = double.Parse(Console.ReadLine());
            Console.Write("Quantidade comprada: ");
            quantidade = int.Parse(Console.ReadLine());
            Console.Write("Dinheiro Recebido R$");
            dinheiro = double.Parse(Console.ReadLine());
            preco = unitario * quantidade;
            troco = dinheiro - preco;
            Console.WriteLine("TROCO = R$" + troco.ToString("F2", CI)); 
        }
    }
}
