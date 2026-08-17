using System;

class Program
{
    static void Main()
    {
        // Criação da expressão lambda utilizando Func<int, int, int>
        Func<int, int, int> multiplicar = (x, y) => x * y;

        // Teste 1: Números pequenos positivos
        int resultado1 = multiplicar(5, 4);
        Console.WriteLine($"Teste 1: 5 * 4 = {resultado1}");

        // Teste 2: Multiplicação envolvendo zero
        int resultado2 = multiplicar(12, 0);
        Console.WriteLine($"Teste 2: 12 * 0 = {resultado2}");

        // Teste 3: Multiplicação com número negativo
        int resultado3 = multiplicar(-3, 7);
        Console.WriteLine($"Teste 3: -3 * 7 = {resultado3}");
    }
}
