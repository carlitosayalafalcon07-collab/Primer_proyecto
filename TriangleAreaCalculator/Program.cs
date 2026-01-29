using System;

namespace TriangleAreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Calculadora de Área de Triángulos ---");

            // Solicitar la base del triángulo
            Console.Write("Ingrese la longitud de la base del triángulo: ");
            string baseInput = Console.ReadLine();
            double triangleBase;

            // Validar y convertir la entrada de la base
            while (!double.TryParse(baseInput, out triangleBase) || triangleBase <= 0)
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número positivo para la base.");
                Console.Write("Ingrese la longitud de la base del triángulo: ");
                baseInput = Console.ReadLine();
            }

            // Solicitar la altura del triángulo
            Console.Write("Ingrese la altura del triángulo: ");
            string heightInput = Console.ReadLine();
            double triangleHeight;

            // Validar y convertir la entrada de la altura
            while (!double.TryParse(heightInput, out triangleHeight) || triangleHeight <= 0)
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número positivo para la altura.");
                Console.Write("Ingrese la altura del triángulo: ");
                heightInput = Console.ReadLine();
            }

            // Calcular el área
            double area = 0.5 * triangleBase * triangleHeight;

            // Mostrar el resultado
            Console.WriteLine($"La base del triángulo es: {triangleBase}");
            Console.WriteLine($"La altura del triángulo es: {triangleHeight}");
            Console.WriteLine($"El área del triángulo es: {area}");

            Console.WriteLine("\nPresione cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}