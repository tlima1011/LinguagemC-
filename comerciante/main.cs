using System;
using System.Globalization;

namespace comerciante {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int n = 0, abaixo = 0, entre = 0, acima = 0;
            double perc_lucro = 0, lucro_total = 0, valor_compra = 0, valor_venda = 0 , lucro = 0; 
            
            Console.Write("Serao digitados dados de quantos produtos? ");
            n = int.Parse(Console.ReadLine());

            String [] produtos = new string[n];
            double [] preco_compra = new double[n];
            double [] preco_venda = new double[n];

            for(int i = 0; i < n; i++) {
                Console.WriteLine("Produto " +(i + 1) +": ");
                Console.Write("Nome: ");
                produtos[i] = Console.ReadLine();
                Console.Write("Preco de compra R$");
                preco_compra[i] = double.Parse(Console.ReadLine(),CI);
                Console.Write("Preco de venda R$"); 
                preco_venda[i] = double.Parse(Console.ReadLine(), CI);
            }

            for(int i = 0; i < n; i++) {
                valor_venda += preco_venda[i];
                valor_compra += preco_compra[i];
                lucro_total = valor_venda - valor_compra;
            }

            for(int i = 0; i < n; i++) {
                lucro = preco_venda[i] - preco_compra[i];
                perc_lucro = lucro * 100 / preco_compra[i];
                if (perc_lucro < 10) {
                    abaixo++;
                }else if(perc_lucro <= 20) {
                    entre++;
                }
                else {
                    acima++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("RELATORIO:");
            Console.WriteLine("Lucro abaixo de 10 %: " +abaixo);
            Console.WriteLine("Lucro entre 10 % e 20 %: " +entre);
            Console.WriteLine("Lucro acima de 20 %: " +acima);
            Console.WriteLine("Valor total de compra R$" 
                        +valor_compra.ToString("F2",CI));  //30.00
            Console.WriteLine("Valor total de venda R$" 
                        +valor_venda.ToString("F2", CI));  //33.50
            Console.WriteLine("Lucro total R$" 
                        +lucro_total.ToString("F2", CI)); //: 3.50
        }
    }
}
