internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== DICIONÁRIOS DE PRODUTOS ===");
        Dictionary<int, string> dicionario = new Dictionary<int, string>();

        // Adicionar elementos no dicionario
        dicionario.Add(2121,"Coca-Cola");
        dicionario.Add(3512,"X-Salada");
        dicionario.Add(9843,"X-Mussarela");
        dicionario.Add(3632,"X-Linguiça");

        // 3 - Percorrer todos os elementos de um dicionário
        Console.WriteLine();
        foreach (var item in dicionario)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }
    }
}