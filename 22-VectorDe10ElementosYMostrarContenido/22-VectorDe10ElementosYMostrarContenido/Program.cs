using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _22_VectorDe10ElementosYMostrarContenido
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            numeros[0] = 12;
            numeros[1] = 13;
            numeros[2] = 25;
            numeros[3] = 36;
            numeros[4] = 74;
            numeros[5] = 86;
            numeros[6] = 53;
            numeros[7] = 56;
            numeros[8] = 88;
            numeros[9] = 99;

            for (int posicion = 0; posicion < numeros.Length; posicion++)
            {
                Console.WriteLine("El numero de la posicion " + posicion + " es: " + numeros[posicion]);
            }


            Console.ReadKey();
        }
    }
}
