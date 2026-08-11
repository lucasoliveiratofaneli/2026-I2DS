internal class Program
{
    private static void Main(string[] args)
    {
        // Primeiro funcionário
        Funcionario funcionario1 = new Funcionario();
        funcionario1.Nome = "Beto Carrero";
        funcionario1.IdadeAtual = 64;
        funcionario1.Salario = 5600.50;
        funcionario1.Registro = 116;

        // Segundo funcionário
        Funcionario funcionario2 = new Funcionario();
        funcionario2.Nome = "Péricles Pessoa";
        funcionario2.IdadeAtual = 25;
        funcionario2.Salario = 670.50;
        funcionario2.Registro = 116;

        // Terceiro funcionário
        Funcionario funcionario3 = new Funcionario();
        funcionario3.Nome = "Robsclaudo Junior";
        funcionario3.IdadeAtual = 90;
        funcionario3.Salario = 10000;
        funcionario3.Registro = 1212;

        //Exibindo Funcionários
        Console.WriteLine("==== FUNCIONÁRIOS ====");

        Console.WriteLine("\nFuncionário1");
        Console.WriteLine($"Nome: {funcionario1.Nome}");
        Console.WriteLine($"Idade: {funcionario1.IdadeAtual}");
        Console.WriteLine($"Registro: {funcionario1.Registro}");
        Console.WriteLine($"Salário R$: {funcionario1.Salario:F2}");

        Console.WriteLine("\nFuncionário2");
        Console.WriteLine($"Nome: {funcionario2.Nome}");
        Console.WriteLine($"Idade: {funcionario2.IdadeAtual}");
        Console.WriteLine($"Registro: {funcionario2.Registro}");
        Console.WriteLine($"Salário R$: {funcionario2.Salario:F2}");

        Console.WriteLine("\nFuncionário1");
        Console.WriteLine($"Nome: {funcionario3.Nome}");
        Console.WriteLine($"Idade: {funcionario3.IdadeAtual}");
        Console.WriteLine($"Registro: {funcionario3.Registro}");
        Console.WriteLine($"Salário R$: {funcionario3.Salario:F2}");

        // Envelhencendo os funcionários
        funcionario1.Envelhecer(13);
        funcionario2.Envelhecer(22);
        funcionario3.Envelhecer(30);

        // Exibindo as novas idades
        Console.WriteLine("\n==== APÓS ENVELHECER ===");
        Console.WriteLine($"{funcionario1.Nome}: {funcionario1.IdadeAtual} anos");
        Console.WriteLine($"{funcionario2.Nome}: {funcionario2.IdadeAtual} anos");
        Console.WriteLine($"{funcionario3.Nome}: {funcionario3.IdadeAtual} anos");
    }

    public class Pessoa
    {
        public string Nome {get; set;}
        public int IdadeAtual {get;set;}
        
        public void Envelhecer(int anos)
        {
            IdadeAtual += anos; // IdadeAtual = IdadeAtual + anos 
        }
    }

    public class Funcionario : Pessoa
    {
        public double Salario {get;set;}
        public int Registro {get;set;}
    }
}