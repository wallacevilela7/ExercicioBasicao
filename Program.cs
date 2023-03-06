using System;

namespace Exercicio {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine();

            //8) (Opcional) Faça um programa que imprima a seguinte tabela, usando fors encadeados:
            //1
            //2 4
            //3 6 9
            //4 8 12 16
            //n n*2 n * 3....n * n


            Console.WriteLine("Deseja imprimir até qual numero?");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();


            for (int l = 1; l <= n; l++) {
                for(int c = 1; c <= l; c++) {
                    Console.Write(l * c + " ");
                }
                Console.WriteLine();
            }
        }
    }

}
