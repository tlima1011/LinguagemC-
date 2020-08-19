using System;
using System.Globalization;

namespace pagamento {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            String nome = "";
            double valorHora = 0, horas = 0, pagamento = 0;
            
            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("Valor por hora R$");
            valorHora = double.Parse(Console.ReadLine());
            Console.Write("Horas trabalhadas: ");
            horas = int.Parse(Console.ReadLine());
            pagamento = valorHora * horas; 
            Console.WriteLine("O pagamento para " + nome + " deve ser R$" 
                +pagamento.ToString("F2", CI));
        }
    }
}
