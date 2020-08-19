using System;
using System.Globalization; 

namespace mais_velho {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int n = 0, idadeVelho = 0;
            String nomeMaisVelho = "";

            Console.Write("Quantas pessoas voce vai digitar ? ");
            n = int.Parse(Console.ReadLine());

            String[] nomes = new String[n];
            int[] idades = new int[n];

            for(int i = 0; i < n; i++) {
                Console.WriteLine("Dados da " + (i + 1) + "ª pessoa: ");
                Console.Write("Nome: ");
                nomes[i] = Console.ReadLine();
                Console.Write("Idade: ");
                idades[i] = int.Parse(Console.ReadLine());
            }

            nomeMaisVelho = nomes[0];
            idadeVelho = idades[0]; 

            for(int i = 1; i < n; i++) {
                if(idades[i] > idadeVelho) {
                    nomeMaisVelho = nomes[i];
                    idadeVelho = idades[i];
                }
            }
            Console.WriteLine("PESSOA MAIS VELHA: " +nomeMaisVelho + " com "+ idadeVelho + " anos.");
        }
    }
}
