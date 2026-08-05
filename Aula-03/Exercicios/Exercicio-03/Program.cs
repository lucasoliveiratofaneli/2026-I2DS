internal partial class Program
{
    private static void Main(string[] args)
    {
        string nome = "Lucas";
        Console.WriteLine("Olá, " + nome);


        int num1;
        int num2;
        int num3;

        Console.Write("Digite a Primeira Nota: ");
        num1 = int.Parse(Console.ReadLine());

        Console.Write("Digite a Segunda Nota: ");
        num2 = int.Parse(Console.ReadLine());

        Console.Write("Digite a Terceira Nota: ");
        num3 = int.Parse(Console.ReadLine());

        double media = (num1 + num2 + num3) /3;
        Console.WriteLine("Sua média é: " + media);

        if(media >= 7)
        {
            Console.WriteLine("Situação: Aprovado");
        }
        else if (media >= 5)
        {
            Console.WriteLine("Situação: Recuperação");
        }
        else
        {
            Console.WriteLine("Situação: Reprovado");
        }

    }
}