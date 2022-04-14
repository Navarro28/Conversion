using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion
{
    class Program
    {
        private static object int32;

        static void Main(string[] args)
        {
            string cadena;

            int numero1 = 5, numero2, resultado;

            //Preguntamos al usuario el numero
            Console.WriteLine("De un numero para sumar:");
            //Se asigna la variable tipo string

            cadena = Console.ReadLine();
            numero2 = int32.Parse(cadena);
            //numero2 convert.ToInt32(cadena);
            //realizar suma

            resultado = numero1 + numero2;

            //Mostrar el resultado

            Console.WriteLine("El resultado es:" + resultado);
            Console.ReadKey();


        }
    }
}
