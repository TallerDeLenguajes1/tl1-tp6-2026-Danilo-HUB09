// ============================================================
//  Ejercicio 1 – Invertir un número
//  Curso: Taller de Lenguajes I  |  Lenguaje: C#
// ============================================================

using System;

namespace CalculadoraV2
{
    internal static class Program
    {
        static void Main()
        {
            Console.Write("Ingresá un número: ");
            string entrada = Console.ReadLine() ?? string.Empty;

            // double.TryParse: convierte el string a double (punto flotante de 64 bits).
            // Equivale a sscanf con %lf en C.
            if (!double.TryParse(entrada, out double numero))
            {
                Console.WriteLine($"Error: \"{entrada}\" no es un número válido.");
                return;
            }

            Console.WriteLine($"\n── Resultados para {numero} ──────────────────");

            // Math.Abs: valor absoluto. Equivale a fabs() de <math.h> en C.
            Console.WriteLine($"Valor absoluto  : {Math.Abs(numero)}");

            // Math.Pow(base, exponente): potenciación. Equivale a pow() de <math.h>.
            Console.WriteLine($"Cuadrado        : {Math.Pow(numero, 2)}");

            // Math.Sqrt: raíz cuadrada. Equivale a sqrt() de <math.h>.
            // Se verifica que el número no sea negativo antes de calcularla.
            if (numero < 0)
                Console.WriteLine("Raíz cuadrada   : No definida para números negativos");
            else
                Console.WriteLine($"Raíz cuadrada   : {Math.Sqrt(numero)}");

            // Math.Sin y Math.Cos reciben el ángulo en RADIANES, igual que sin()/cos() en C.
            Console.WriteLine($"Seno            : {Math.Sin(numero)}");
            Console.WriteLine($"Coseno          : {Math.Cos(numero)}");

            // Parte entera de un float:
            // (float) es un cast explícito, igual que en C: convierte double a float (32 bits).
            // Math.Truncate elimina los decimales sin redondear (como (int) en C pero devuelve double).
            float comoFloat = (float)numero;
            Console.WriteLine($"Parte entera    : {Math.Truncate(comoFloat)}");
        }
    }
}