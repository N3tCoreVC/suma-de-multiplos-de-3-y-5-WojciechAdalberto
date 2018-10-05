using System;
using System.Collections.Generic;

namespace sum3y5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<int> Multiplos = new List<int>();
            Multiplos.Add(3);
            Multiplos.Add(5);
            Console.WriteLine("Dame un numero ");
            int numero;
            if ( Int32.TryParse(Console.ReadLine(), out numero) ){
                int suma = 0;
                numero++;
                for ( int i = 1 ; i < numero ; i++ ){
                    for ( int j= 0 ; j < Multiplos.Count ; j++ )
                    {
                        if (i%Multiplos[j]==0)
                        {
                            suma = suma + i;
                            break;
                        }
                    }
                }
                Console.WriteLine("la suma fue de "+suma);
            } else{
                Console.WriteLine("No es un numero");
            }
        }
    }
}
