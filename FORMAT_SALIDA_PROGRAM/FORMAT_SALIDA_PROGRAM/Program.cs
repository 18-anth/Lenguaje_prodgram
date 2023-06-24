using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace format_salida_program{
    internal class Program
    {
        static void Main(string[] args)
        // CALCULAR EL AREA DE UN TRIANGULO
        {
            double BASE, ALTURA, RESULT;
            string linea;
            Console.Write("Diguite la base: ");
            linea = Console.ReadLine();
            BASE = double.Parse(linea);
            Console.Write("Diguite la altura: ");
            linea = Console.ReadLine();
            ALTURA = double.Parse(linea);

            RESULT = (BASE * ALTURA) / 2;

            Console.WriteLine("AREA DE TRIANGULO: " + string.Format("{0:####.00}", RESULT));

            Console.WriteLine("AREA DE TRIANGULO: " + string.Format("{0:c}", RESULT));
            Console.WriteLine("AREA DE TRIANGULO: " + string.Format("{0:f}", RESULT));
            Console.WriteLine("AREA DE TRIANGULO: " + string.Format("{0:g}", RESULT));
            Console.WriteLine();
            Console.WriteLine("HOY ES: " + String.Format("Hoy es {0:F}", DateTime.Now));
            Console.WriteLine("HOY ES: " + String.Format("Hoy es {0:dddd} {0:dd/MM/yyyy}", DateTime.Now));
            Console.WriteLine("Presione una tecla para finalizar: "); 
            Console.WriteLine();
        }
    }
}

