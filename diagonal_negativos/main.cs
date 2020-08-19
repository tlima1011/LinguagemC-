using System;

namespace diagonal_negativos {
    class Program {
        static void Main(string[] args) {

            int n = 0, cont_negativos = 0; 

            Console.WriteLine("Qual a ordem da matriz? ");
            n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for(int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    Console.Write("Elemento["+i+","+j+"]: ");
                    mat[i,j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("DIAGONAL PRINCIPAL:");                        
            for(int i = 0; i < n; i++) {
                Console.Write(mat[i,i] + "  ");
            }
            
            for(int i = 0; i < n; i++) {
                for(int j = 0; j < n; j++) {
                    if(mat[i,j] < 0) {
                        cont_negativos++;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("QUANTIDADE DE NEGATIVOS = " +cont_negativos); 
        }
    }
}
