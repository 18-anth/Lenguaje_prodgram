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

class Program
{
    static void Main(string[] args)
    {
        int Person_Total= 0;
        int Person_Old = 0;

        Console.Write("Ingrese la cantidad de personas que van a ingresar al curso de METODOLOGÍA: ");
        Person_Total = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(" ");
        Console.WriteLine("*-------------------------------------*");
        Console.WriteLine(" ");

        for (int i = 1; i <= Person_Total; i++)
        {
            Console.Write($"Ingrese la edad de la persona {i}: ");
            int edad = Convert.ToInt32(Console.ReadLine());

            if (edad > 18)
            {
                Person_Old++;
                Console.Write($"La persona {i} cumple con ser mayor de 18 años");
                Console.WriteLine(" ");
            }else if (edad == 18)
            {
                Person_Old++;
                Console.Write($"La persona {i} cumple con tener 18 años");
                Console.WriteLine(" ");
            }
            else
            {
                Console.Write($"La persona {i} no cumple ser mayor de 18 años");
                Console.WriteLine(" ");
            }
        }
        Console.WriteLine(" ");
        Console.WriteLine("*-------------------------------------*");
        Console.WriteLine(" ");

        Console.Write($"Total de personas mayores de 18 años: {Person_Old}");
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.Write("Integrantes: ");
        Console.Write(@"
        PAULA GEORGINA CARDENAS SARES
        JULIANA ELIZABETH RAMÍREZ SACARELO
        KAISER FELIPE CRESPIN CHAVEZ  
        ANTHONY ESTUARDO CORDOVA MORENO  
        YOSELYN MARINA VELEZ CAMPUZANO
            ");
        Console.WriteLine(" ");
        Console.Write("Presione una tecla al azar para cerrar el Programa...");
        Console.ReadLine();
        Console.Write("");
    }
}
