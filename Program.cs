// ============================================================
//  Ejercicio 2
//  Curso: Taller de Lenguajes I  |  Lenguaje: C#
// ============================================================
using System;

namespace CalculadoraV1
{
    internal static class Program
    {
        static void Main()
        {
            bool continuar = true;

            while (continuar)
            {
                // ── Menú ────────────────────────────────────────────
                Console.WriteLine("\n=== CALCULADORA ===");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.Write("Seleccioná una opción (1-4): ");

                string opcionEntrada = Console.ReadLine() ?? string.Empty;

                // int.TryParse: convierte el string a int de forma segura.
                // Si falla devuelve false y opcion queda en 0.
                if (!int.TryParse(opcionEntrada, out int opcion) || opcion < 1 || opcion > 4)
                {
                    Console.WriteLine("Opción inválida. Intentá de nuevo.");
                    continue; // Vuelve al inicio del while sin pedir números
                }

                // ── Leer los dos números ────────────────────────────
                Console.Write("Ingresá el primer número: ");
                string entrada1 = Console.ReadLine() ?? string.Empty;

                Console.Write("Ingresá el segundo número: ");
                string entrada2 = Console.ReadLine() ?? string.Empty;

                // double.TryParse: igual que int.TryParse pero para decimales.
                if (!double.TryParse(entrada1, out double a) || !double.TryParse(entrada2, out double b))
                {
                    Console.WriteLine("Uno o ambos valores ingresados no son números válidos.");
                    continue;
                }

                // ── Calcular y mostrar resultado ────────────────────
                // switch en C# funciona igual que en C.
                // Se agrega el caso de división por cero específico para opcion 4.
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine($"Resultado: {a} + {b} = {a + b}");
                        break;
                    case 2:
                        Console.WriteLine($"Resultado: {a} - {b} = {a - b}");
                        break;
                    case 3:
                        Console.WriteLine($"Resultado: {a} * {b} = {a * b}");
                        break;
                    case 4:
                        if (b == 0)
                        {
                            Console.WriteLine("Error: no se puede dividir por cero.");
                        }
                        else
                        {
                            Console.WriteLine($"Resultado: {a} / {b} = {a / b}");
                        }
                        break;
                }

                // ── ¿Repetir? ───────────────────────────────────────
                Console.Write("\n¿Deseás realizar otro cálculo? (s/n): ");

                // ToLower() convierte el string a minúsculas para aceptar S y s.
                // En C harías tolower() carácter a carácter.
                string respuesta = (Console.ReadLine() ?? string.Empty).ToLower();

                // Trim() elimina espacios en blanco al inicio y al final del string.
                continuar = respuesta.Trim() == "s";
            }

            Console.WriteLine("¡Hasta luego!");
        }
    }
}