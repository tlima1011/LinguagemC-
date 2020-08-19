using System;
using System.Globalization;

namespace maior_posicao {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int n = 0, pos_maior = 0;
            double maiorValor = 0;

            Console.Write("Quanto numeros voce vai digitar? ");
            n = int.Parse(Console.ReadLine());

            double[] numeros = new double[n];

            for(int i = 0; i < n; i++) {
                Console.Write("Digite " +(i + 1) +"º numero: ");
                numeros[i] = double.Parse(Console.ReadLine());
            }

            maiorValor = numeros[0]; 
            
            for(int i = 1; i < n; i++) {
                if(numeros[i] > maiorValor) {
                    maiorValor = numeros[i];
                    pos_maior = i;
                }
            }
            Console.WriteLine();
            Console.WriteLine("MAIOR VALOR = " 
                +maiorValor.ToString("F1", CI));
            Console.WriteLine("POSICAO DO MAIOR VALOR = " +pos_maior);
            //14.0
             //3w           
        }
    }
}
