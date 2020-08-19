using System;

namespace duracao {
    class Program {
        static void Main(string[] args) {

            int resto = 0, duracao = 0, horas = 0, minutos = 0, segundos = 0;

            Console.Write("Digite a duracao em segundos: ");
            duracao = int.Parse(Console.ReadLine());
            horas = duracao / 3600;
            resto = duracao % 3600;
            minutos = resto / 60;
            segundos = resto % 60;
            Console.WriteLine(horas + "hh:" + minutos + "mm:" + segundos + "s");
        }
    }
}
