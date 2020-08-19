using System;
using System.Globalization;

namespace experiencia {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int n = 0, qtde = 0, coelhos = 0, ratos = 0, sapos = 0, total = 0;
            double porc_coelho = 0, porc_sapo = 0, porc_rato = 0;
            char tipo;

            Console.Write("Quantos casos de teste serao digitados? ");
            n = int.Parse(Console.ReadLine()); 

            for(int i = 0; i < n; i++) {
                Console.Write("Quantidade de cobaias: ");
                qtde = int.Parse(Console.ReadLine());
                Console.Write("Tipo de cobaia: [C] - Coelho [S] - Sapo [R] - Rato: ");
                tipo = char.Parse(Console.ReadLine());
                tipo = char.ToUpper(tipo);
                switch (tipo) {
                    case 'C':
                        coelhos += qtde;
                        break;
                    case 'S':
                        sapos += qtde;
                        break;
                    case 'R':
                        ratos += qtde;
                        break;
                    default:
                        do {
                            if(tipo != 'C' && tipo != 'R' && tipo != 'S') {
                                Console.WriteLine("Inváldio...");
                                Console.Write("Tipo de cobaia: [C] - Coelho [S] - Sapo [R] - Rato: ");
                                tipo = char.Parse(Console.ReadLine());
                                tipo = char.ToUpper(tipo);
                            }  
                        } while (tipo != 'C' && tipo != 'R' && tipo != 'S');
                        break;          
                }
            }
            total = coelhos + ratos + sapos;
            porc_coelho = (double) coelhos / total;
            porc_rato = (double) ratos / total;
            porc_sapo = (double) sapos / total;
            porc_coelho *= 100;
            porc_rato *= 100;
            porc_sapo *= 100;
            Console.WriteLine();
            Console.WriteLine("RELATORIO FINAL:");
            Console.WriteLine("Total: " + total + " cobaias");
            Console.WriteLine("Total de coelhos: " + coelhos);
            Console.WriteLine("Total de ratos: " + ratos);
            Console.WriteLine("Total de sapos: " + sapos);
            Console.WriteLine("Percentual de coelhos: " + porc_coelho.ToString("F2", CI)+"%");
            Console.WriteLine("Percentual de ratos: " + porc_rato.ToString("F2", CI) + "%");
            Console.WriteLine("Percentual de sapos: " +porc_sapo.ToString("F2", CI) + "%");
            }
        }
    }

