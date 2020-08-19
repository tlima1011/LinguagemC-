using System;

namespace par_impar {
    class Program {
        static void Main(string[] args) {

            int num = 0, n = 0;
            String resultado = "";

            Console.Write("Quantos numeros voce vai digitar ? ");
            n = int.Parse(Console.ReadLine()); 

            for(int i = 0; i < n; i++) {
                Console.Write("Digite um numero: ");
                num = int.Parse(Console.ReadLine()); 
                if(num == 0) {
                    Console.WriteLine("NULO");
                }else if(num % 2 != 0) {
                    resultado = "IMPAR "; 
                    if (num < 0) {
                        resultado += "NEGATIVO";
                        Console.WriteLine(resultado);
                    }
                    else {
                        resultado += "POSITIVO";
                        Console.WriteLine(resultado);
                    }
                }
                else {
                    resultado = "PAR ";
                    if (num < 0) {
                        resultado += "NEGATIVO";
                        Console.WriteLine(resultado);
                    }
                    else {
                        resultado += "POSITIVO";
                        Console.WriteLine(resultado);
                    }
                }
            }
        }
    }
}
