using System;
using System.Globalization;

namespace troco_verificado {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            double unitario = 0, preco = 0, dinheiro = 0, troco = 0, faltante = 0;
            int quantidade = 0;

            Console.Write("Preço unitário do produto R$");
            unitario = double.Parse(Console.ReadLine(), CI);
            Console.Write("Quantidade comprada: ");
            quantidade = int.Parse(Console.ReadLine());
            Console.Write("Dinheiro recebido R$");
            dinheiro = double.Parse(Console.ReadLine(), CI);
            preco = unitario * quantidade;
            if (dinheiro < preco) {
                faltante = preco - dinheiro;
                Console.WriteLine("DINHEIRO INSUFICIENTE. FALTAM R$ "
                    + faltante.ToString("F2", CI));
            }
            else {
                troco = dinheiro - preco;
                Console.WriteLine("TROCO = R$" + troco.ToString("F2", CI));
            }
        }
    }
}
