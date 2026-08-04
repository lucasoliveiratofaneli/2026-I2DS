internal class Program
{
    private static void Main(string[] args)
    {
        // Exercicios 1
        int celsius;
        Console.Write("Digite a temperatura em Graus Celsius: ");
        celsius = int.Parse(Console.ReadLine());

        double fahrenheit = (celsius * 9 / 5) + 32;

        Console.WriteLine("A conversão de Celsius para Fahrenheit é: " + fahrenheit);

    }
}