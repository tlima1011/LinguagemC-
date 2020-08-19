using System;

namespace senha_fixa {
    class Program {
        static void Main(string[] args) {
            
            int senha = 0;
            Console.Write("Digite a senha: ");
            do {
                senha = int.Parse(Console.ReadLine());
                if(senha != 2002) {
                    Console.Write("Senha Invalida! Tente novamente: ");
                }
                else {
                    break; 
                }
         } while (senha != 2002);
            Console.WriteLine("Acesso permitido!");
        }
    }
}
