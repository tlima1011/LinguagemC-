using System;
using System.Globalization;

namespace glicose {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;
            double glicose = 0;
            String classificacao = "";

            Console.Write("Digite a medida da glicose: ");
            glicose = double.Parse(Console.ReadLine(), CI);
            if(glicose <= 100) {
                classificacao = "Normal";
            }else if(glicose <= 140) {
                classificacao = "Elevado";
            }
            else {
                classificacao = "Diabetes"; 
            }
            Console.WriteLine("Classificacao: " +classificacao);
        }
    }
}
