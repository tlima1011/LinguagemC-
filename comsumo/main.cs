using System;
using System.Globalization; 

namespace consumo {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;
            double distancia = 0, combustivel = 0, consumo = 0; 
           
            Console.Write("Distancia percorrida: ");
            distancia = double.Parse(Console.ReadLine(),CI);
            Console.Write("Combustível gasto: ");
            combustivel = double.Parse(Console.ReadLine(),CI);
            consumo = distancia / combustivel;
            Console.WriteLine("Consumo medio = " +consumo.ToString("F3",CI));//12.987
        }
    }
}
