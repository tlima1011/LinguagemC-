using System;

namespace dentro_fora {
    class Program {
        static void Main(string[] args) {

            int x = 0 , n = 0, dentro = 0, fora = 0; 
            
            Console.Write("Quantos numeros voce vai digitar? ");
            n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++) {
                Console.Write("Digite o " + (i + 1) + "º numero: ");
                x = int.Parse(Console.ReadLine()); 
                if(x >= 0 && x <= 20) {
                    fora++;
                }
                else {
                    dentro++;
                }
            }
            Console.WriteLine(dentro + " DENTRO");
            Console.WriteLine(fora + " FORA");
          
        }
    }
}
