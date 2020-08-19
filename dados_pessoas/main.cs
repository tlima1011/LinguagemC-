using System;
using System.Globalization;

namespace dados_pessoas {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int n = 0, mulheres = 0, homens = 0;
            double maior_altura = 0, menor_altura = 0,media_alturas = 0, soma_altura_mulheres = 0; 

            Console.Write("Quantas pessoas serao digitadas? ");
            n = int.Parse(Console.ReadLine());

            double[] alturas = new double[n];
            char[] generos = new char[n];

            for(int i = 0; i < n; i++) {
                Console.Write("Altura da " + (i + 1) +"ª pessoa: ");
                alturas[i] = double.Parse(Console.ReadLine(),CI);
                Console.Write("Genero da " + (i + 1) + "ª pessoa: ");
                generos[i] = char.Parse(Console.ReadLine());
                generos[i] = char.ToUpper(generos[i]);
            }
            menor_altura = alturas[0]; 
            maior_altura = alturas[0];

            for(int i = 1; i < n; i++) {
                if(alturas[i] > maior_altura) {
                    maior_altura = alturas[i];
                }
                if(alturas[i] < menor_altura) {
                    menor_altura = alturas[i];
                }
            }
            Console.WriteLine("Menor altura = " 
                + menor_altura.ToString("F2",CI));
            Console.WriteLine("Maior altura = " +maior_altura.ToString("F2", CI));

            for(int i = 0; i < n; i++) {
                if(generos[i] == 'M') {
                    homens++;
                }
                else if(generos[i] == 'F'){
                    soma_altura_mulheres += alturas[i];
                    mulheres++;
                }
            }
            media_alturas = soma_altura_mulheres / mulheres;
            Console.WriteLine("Media das alturas das mulheres = " +media_alturas.ToString("F2", CI));
            Console.WriteLine("Numero de homens = " + homens);  
        }
    }
}
