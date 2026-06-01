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
            // ═══════════════════════════════════════════════════════
            //  PARTE 1 – Operaciones con un número
            // ═══════════════════════════════════════════════════════

            Console.Write("Ingresá un número: ");
            string entrada1 = Console.ReadLine() ?? string.Empty;

            if (!double.TryParse(entrada1, out double numero))
            {
                Console.WriteLine($"Error: \"{entrada1}\" no es un número válido.");
                return;
            }

            Console.WriteLine($"\n── Resultados para {numero} ──────────────────");

            // Math.Abs: valor absoluto. Equivale a fabs() en C.
            Console.WriteLine($"Valor absoluto  : {Math.Abs(numero)}");

            // Math.Pow(base, exp): potencia. Equivale a pow() en C.
            Console.WriteLine($"Cuadrado        : {Math.Pow(numero, 2)}");

            // Math.Sqrt: raíz cuadrada. No definida para negativos (devolvería NaN).
            if (numero < 0)
                Console.WriteLine("Raíz cuadrada   : No definida para números negativos");
            else
                Console.WriteLine($"Raíz cuadrada   : {Math.Sqrt(numero)}");

            // Math.Sin / Math.Cos: reciben el ángulo en radianes, igual que en C.
            Console.WriteLine($"Seno            : {Math.Sin(numero)}");
            Console.WriteLine($"Coseno          : {Math.Cos(numero)}");

            // Cast explícito a float (32 bits) igual que en C.
            // Math.Truncate elimina los decimales sin redondear.
            float comoFloat = (float)numero;
            Console.WriteLine($"Parte entera    : {Math.Truncate(comoFloat)}");

            // ═══════════════════════════════════════════════════════
            //  PARTE 2 – Máximo y mínimo entre dos números
            // ═══════════════════════════════════════════════════════

            Console.WriteLine("\n── Máximo y mínimo ───────────────────────────");

            Console.Write("Ingresá el primer número : ");
            string entradaA = Console.ReadLine() ?? string.Empty;

            Console.Write("Ingresá el segundo número: ");
            string entradaB = Console.ReadLine() ?? string.Empty;

            // Se validan ambos números antes de operar.
            if (!double.TryParse(entradaA, out double a) || !double.TryParse(entradaB, out double b))
            {
                Console.WriteLine("Error: uno o ambos valores no son números válidos.");
                return;
            }

            // Math.Max / Math.Min: equivalen a escribir un if manualmente en C,
            // ya que C no tiene estas funciones para doubles en la stdlib estándar.
            Console.WriteLine($"Máximo          : {Math.Max(a, b)}");
            Console.WriteLine($"Mínimo          : {Math.Min(a, b)}");
        }
    }
}