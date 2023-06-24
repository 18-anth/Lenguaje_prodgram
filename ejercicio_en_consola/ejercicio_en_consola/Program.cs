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

namespace ejercicio_en_consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double subtotal;
            double impuesto; 

            double precioHamburguesa = 2.5;
            const double precioPapas = 1.5;
            const double precioBebida = 1.0;


            Console.WriteLine("BIENVENIDOS AL CUSTRACIO CASCARUDO :)");
            Console.WriteLine(" ");
            double hamburgesas, papas, bebidas, total = 0;
            Console.WriteLine("CANTIDAD DE HAMBURGUESAS: ");
            hamburgesas = double.Parse(Console.ReadLine());
            Console.WriteLine("CANTIDAD DE PAPAS: ");
            papas = double.Parse(Console.ReadLine());
            Console.WriteLine("CANTIDAD DE BEBIDAS: ");
            bebidas = double.Parse(Console.ReadLine());
          

            // Realizar cálculos
            subtotal = (hamburgesas * precioHamburguesa) + (papas * precioPapas) + (bebidas * precioBebida);
            impuesto = subtotal * 0.13; // Suponiendo un impuesto del 13%
            total = subtotal + impuesto;

           
            Console.WriteLine(" ");
            Console.WriteLine("---------- DETALLES DE LA ORDEN ----------");
            Console.WriteLine("FECHA DE EMICIÓN: " + DateTime.Now);
            Console.WriteLine("CANTIDAD DE HAMBURGUESAS: " + hamburgesas);
            Console.WriteLine("CANTIDAD DE PAPAS: " + papas);
            Console.WriteLine("CANTIDAD DE BEBIDAS: " + bebidas);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("Subtotal: ${0:F2}", subtotal);
            Console.WriteLine("Impuesto: ${0:F2}", impuesto);
            Console.WriteLine("Total a pagar: ${0:F2}", total);
            Console.WriteLine(" ");
            Console.WriteLine("CREADO POR: ");
            Console.WriteLine("ANTHONY ESTUARDO CORDOVA MORENO, KAISER CRESPIN CHAVEZ,");
            Console.WriteLine("JULIANA RAMIREZ SACARELO, PAULA CARDENAS SARES, YOSELYN VELEZ CAMPUZANO");
            Console.WriteLine(" ");
            Console.WriteLine("UN PLACER ATENDERLE!");
            Console.WriteLine("QUE TENGA UN EXCELENTE DÍA!");
            
            
            Console.ReadKey();
        }
    }
}
