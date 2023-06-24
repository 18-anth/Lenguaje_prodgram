using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operacion_Basic
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string linea;
            int NUM1, NUM2;
            double RESUL;

            Console.Write("PRIMER NUMERO: ");
            linea = Console.ReadLine();
            NUM1 = int.Parse(linea);
            Console.Write("SEGUNDO NUMERO: ");
            linea = Console.ReadLine();
            NUM2 = int.Parse(linea);
            Console.WriteLine();
            RESUL = NUM1 + NUM2;
            Console.WriteLine("LA SUMA ES: " + RESUL);
            RESUL = NUM1 - NUM2;
            Console.WriteLine("LA RESTA ES: {0} - {1} = {2}", NUM1, NUM2, RESUL);
            RESUL = NUM1 * NUM2;
            Console.WriteLine("LA MULTIPLICACION ES: " + RESUL);
            RESUL = NUM1 / NUM2;
            Console.WriteLine("LA DIVISION ES: " + RESUL);
            Console.Write("PRESIONE UNA TECLA PARA SALIR");
            Console.ReadLine();

        }
    }
}
