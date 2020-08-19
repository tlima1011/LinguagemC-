using System;
using System.Globalization;

namespace aumento {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;
            double salario = 0, aumento = 0, novoSalario = 0, porcentagem = 0;

            Console.Write("Digite o salario da pessoa - R$");
            salario = double.Parse(Console.ReadLine(), CI);
            if (salario <= 1000) {
                porcentagem = 0.20;
            }
            else if (salario <= 3000) {
                porcentagem = 0.15;
            }
            else if (salario <= 8000) {
                porcentagem = 0.10;
            }
            else {
                porcentagem = 0.05;
            }
            aumento = salario * porcentagem;
            novoSalario = salario + aumento;
            porcentagem *= 100;
            Console.WriteLine("Novo salario = R$" + novoSalario.ToString("F2", CI));
            Console.WriteLine("Aumento = R$" + aumento.ToString("F2", CI));
            Console.WriteLine("Porcentagem = " + porcentagem.ToString("F0", CI)+"%");
        }
    }
}
