using System;
using System.Collections.Generic;
using System.Linq; // Necessário para usar o OrderBy

class FuncionarioInfo
{
    public string Nome { get; set; }
    public double Salario { get; set; }

    public FuncionarioInfo(string nome, double salario)
    {
        Nome = nome;
        Salario = salario;
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== DICIONÁRIO FUNCIONÁRIOS ===");
        Dictionary<int, FuncionarioInfo> funcionario = new Dictionary<int, FuncionarioInfo>();

        // Adicionar elementos no dicionário
        funcionario.Add(93426, new FuncionarioInfo("Arnaldo", 1200.00));
        funcionario.Add(38721, new FuncionarioInfo("Heitor", 1700.00));
        funcionario.Add(73793, new FuncionarioInfo("Elenildo", 5000.00));
        funcionario.Add(12763, new FuncionarioInfo("Caio", 76000.00));
        funcionario.Add(29732, new FuncionarioInfo("Renevaldo", 1000.00));

        // Percorrer todos os elementos de um dicionário
        Console.WriteLine();
        foreach (var item in funcionario)
        {
            Console.WriteLine($"{item.Key} - {item.Value.Nome} - R$ {item.Value.Salario}");
        }

        Console.WriteLine("\n=== LISTA ORDENADA POR SALÁRIO ===");
        
        // Correção: Acessa c.Value.Salario e extrai apenas o FuncionarioInfo com o Select
        var listaSalario = funcionario.OrderBy(c => c.Value.Salario)
        .Select(c => c.Value)
        .ToList();                              
        ImprimirLista(listaSalario);
    }

    // Correção: Método movido para fora do Main
    public static void ImprimirLista(List<FuncionarioInfo> lista)
    {
        Console.WriteLine();
        foreach (var colab in lista)
        {
            Console.WriteLine($"Nome: {colab.Nome} - Salário R$: {colab.Salario:F2}");
        }
    }
}

