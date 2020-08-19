using System;

namespace tempo_de_jogo {
    class Program {
        static void Main(string[] args) {

            int horas = 0, horaInicial = 0, horaFinal = 0;

            Console.Write("Hora inicial.: ");
            horaInicial = int.Parse(Console.ReadLine());
            Console.Write("Hora final.: ");
            horaFinal = int.Parse(Console.ReadLine());
            if (horaInicial == 0 && horaFinal == 0) {
                horas = 24;
            }
            else if (horaInicial > horaFinal) {
                horas = (horaFinal + 24) - horaInicial;
            }
            else {
                horas = horaFinal - horaInicial;
            }
            Console.WriteLine("O JOGO DUROU " + horas + " HORA(S)");
        }
    }
}
