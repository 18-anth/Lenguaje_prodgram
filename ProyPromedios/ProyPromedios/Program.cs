struct ProyPromedios
{
    internal class Program
    {
        static void Main(string[] args) { 
            
            int Can, i;
            double nota1, nota2, Prom, Sum;
            string Nombre, linea;
            Console.WriteLine("Ingrese la cantidad de estudiantes");

            linea = Console.ReadLine();
            Can = int.Parse(linea);
            Sum = 0;

            for (i = 0; i <= Can; i++) {
                if (i < 10 )
                {
                    
                }
                Console.Write("NOMBRE: ");Nombre = Console.ReadLine();
                Console.Write("Nota 1: "); linea = Console.ReadLine();
                nota1 = double.Parse(linea);
                Console.Write("Nota 2: "); linea = Console.ReadLine();
                nota2 = double.Parse(linea);
                Prom = (nota1+nota2)/2;
                Console.WriteLine("Promedio: " + Prom);
                Sum += Prom;
            }
            Console.WriteLine();
            Console.WriteLine("Suma total es: " + Sum);
            Console.WriteLine("Media Aritmetica: " + Sum / Can);
            Console.WriteLine("Digite una tecla para finalizar el programa: ");
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
