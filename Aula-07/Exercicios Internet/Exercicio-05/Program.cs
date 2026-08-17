internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== PILHA DE AÇÕES ===");

        // 1 - Criar uma nova pilha vazia
        Stack<string> Acoes = new Stack<string>();

        // 2 - Adicionar elementos em uma pilha
        Acoes.Push("Digitar");
        Acoes.Push("Colar");
        Acoes.Push("Negrito");
        Acoes.Push("Apagar");

        // 3 - Percorrer todos os elementos de uma pilha
        Console.WriteLine();
        foreach (var editor in Acoes)
        {
            Console.WriteLine(editor);
        }

        // 4 - Remover um elemento da pilha
        string acaoRemovida1 = Acoes.Pop();
        Console.WriteLine();
        Console.WriteLine($"A ação retirada foi: {acaoRemovida1}");

        Console.WriteLine();
        foreach (var item in Acoes)
        {
            Console.WriteLine(item);
        }

        string acaoRemovida2 = Acoes.Pop();
        Console.WriteLine();
        Console.WriteLine($"A ação retirada foi: {acaoRemovida2}");

        Console.WriteLine();
        foreach (var item in Acoes)
        {
            Console.WriteLine(item);
        }
    }
}