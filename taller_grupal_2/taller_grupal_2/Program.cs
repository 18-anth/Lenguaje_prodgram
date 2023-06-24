// ANTHONY ESTUARDO CORDOVA MORENO,

// KAISER CRESPIN CHAVEZ,

// JULIANA RAMIREZ SACARELO,

// PAULA CARDENAS SARES,

// YOSELYN VELEZ CAMPUZANO

// GRUPO 7 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ingreso de datos
            Console.Write("Ingrese nombre del empleado: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese el mes: ");
            string mes = Console.ReadLine();

            Console.Write("Ingrese la cantidad de hijos: ");
            int hijos = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el valor anticipado del salario: ");
            double anticipo = Convert.ToDouble(Console.ReadLine());

            // Constantes
            const double SALARIO_BASICO = 425;
            const double INCREMENTO_POR_HIJO = 0.05;

            // incremento por hijos
            double incrementoHijos = hijos * (SALARIO_BASICO * INCREMENTO_POR_HIJO);

            // salario neto
            double salarioNeto = SALARIO_BASICO + incrementoHijos - anticipo;

            // resultados
            Console.WriteLine("\n--- Detalles del empleado ---");
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Mes: " + mes);
            Console.WriteLine("Número de hijos: " + hijos);
            Console.WriteLine("Valor anticipado: " + anticipo.ToString("C"));
            Console.WriteLine("--- Resultados ---");
            Console.WriteLine("Salario básico: " + SALARIO_BASICO.ToString("C"));
            Console.WriteLine("Incremento por hijos: " + incrementoHijos.ToString("C"));
            Console.WriteLine("Salario neto: " + salarioNeto.ToString("C"));

            Console.ReadLine();
        }
    }
}