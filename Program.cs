// ============================================================
//  Ejercicio 1 – Invertir un número
//  Curso: Taller de Lenguajes I  |  Lenguaje: C#
// ============================================================

// "using" importa un espacio de nombres (namespace).
// Es equivalente al #include de C, pero para la biblioteca
// estándar de .NET. "System" contiene Console, int, string, etc.
using System;

// Un "namespace" agrupa clases relacionadas (como un módulo).
// En C no existe este concepto; en C# es una buena práctica
// siempre declarar uno.
namespace InvertirNumero
{
    // En C# TODO el código debe vivir dentro de una clase.
    // No hay funciones "sueltas" como en C.
    // "static" significa que la clase no se instancia; actúa
    // como contenedor de métodos de utilidad.
    internal static class Program
    {
        // Punto de entrada del programa.
        // Equivalente al  int main(void)  de C.
        // "static" → se llama sin crear un objeto.
        // "void"   → no retorna nada al sistema operativo
        //            (en C# también existe Main que retorna int,
        //             pero void es la forma más común).
        static void Main()
        {
            // ── 1. Leer la entrada del usuario ──────────────────────
            // Console.Write  → imprime sin salto de línea (como printf sin \n)
            // Console.WriteLine → imprime CON salto de línea (como printf con \n)
            Console.Write("Ingresá un número: ");

            // Console.ReadLine() lee toda una línea como string.
            // Devuelve string? (nullable) en .NET moderno; el
            // operador  ??  provee un valor por defecto si es null.
            // En C usarías fgets() o scanf(); aquí es más seguro
            // porque ReadLine nunca desborda el buffer.
            string entrada = Console.ReadLine() ?? string.Empty;

            // ── 2. Validar que la entrada sea un número entero ───────
            // int.TryParse intenta convertir el string a int.
            //   • Si tiene éxito → devuelve true y escribe el valor
            //     en la variable de salida "numero" (parámetro out).
            //   • Si falla   → devuelve false y "numero" queda en 0.
            //
            // En C harías: sscanf(entrada, "%d", &numero) != 1
            // o strtol() con manejo manual de errores.
            // TryParse es más seguro y expresivo.
            if (!int.TryParse(entrada, out int numero))
            {
                // La interpolación de strings usa el prefijo $ y {}.
                // Equivalente a printf("... %s ...\n", entrada) en C.
                Console.WriteLine($"Error: \"{entrada}\" no es un número entero válido.");

                // Devuelve el control al sistema (fin del programa).
                // Como el return al final de main() en C.
                return;
            }

            // ── 3. Verificar que el número sea mayor que 0 ───────────
            if (numero <= 0)
            {
                Console.WriteLine($"El número {numero} no es mayor a 0. No se realizará la inversión.");
                return;
            }

            // ── 4. Invertir el número ────────────────────────────────
            // Llamada al método auxiliar definido más abajo.
            // En C sería una llamada a función normal: Invertir(numero)
            int invertido = Invertir(numero);

            // Mostramos el resultado con interpolación de strings.
            Console.WriteLine($"Número original : {numero}");
            Console.WriteLine($"Número invertido: {invertido}");
        }

        // ── Método auxiliar ──────────────────────────────────────────
        // "private" → solo visible dentro de esta clase.
        // "static"  → no necesita instancia para ser llamado
        //             (igual que una función libre en C).
        // "int"     → tipo de retorno, idéntico a C.
        //
        // En C sería:   int Invertir(int n) { ... }
        private static int Invertir(int n)
        {
            // Variable local que acumulará el número invertido.
            int resultado = 0;

            // Algoritmo clásico de inversión de dígitos:
            //   extraemos el último dígito con % 10,
            //   lo "pegamos" a resultado desplazando los anteriores,
            //   y eliminamos ese dígito de n con / 10.
            // Este algoritmo es IDÉNTICO en C y en C#.
            while (n > 0)
            {
                int digito = n % 10;          // Último dígito
                resultado = resultado * 10 + digito; // Acumular
                n /= 10;                      // Quitar ese dígito
            }

            // "return" funciona igual que en C.
            return resultado;
        }
    }
}