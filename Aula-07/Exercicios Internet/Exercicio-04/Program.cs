internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== FILA DE ATENDIMENTO ===");

        // 1 - Cria uma nova fila vazia
        Queue<string> filaExpo = new Queue<string>();

        // 2 - Adicionar elementos na fila
        filaExpo.Enqueue ("Roger");        // 0
        filaExpo.Enqueue ("Vitin");        // 1
        filaExpo.Enqueue ("Cagol");        // 2
        filaExpo.Enqueue ("Esquivel");     // 3

        // 3 - Percorrer elementos de uma fila
        Console.WriteLine();
        foreach (var pessoa in filaExpo)
        {
            Console.WriteLine(pessoa);
        }

        Console.WriteLine("=== FILA ATUALIZADA ===");
        // 4 - Retirar um elemento da lista
        string pessoaRetirada1 = filaExpo.Dequeue();
        Console.WriteLine();
        Console.WriteLine($"O Nome chamado foi: {pessoaRetirada1}");
        string pessoaRetirada2 = filaExpo.Dequeue();
        Console.WriteLine();
        Console.WriteLine($"O Nome chamado foi: {pessoaRetirada2}");

        filaExpo.Enqueue("Clarêncio Pessimista");
        filaExpo.Enqueue("Doly");

        Console.WriteLine();
        foreach (var pessoa in filaExpo)
        {
            Console.WriteLine(pessoa);
        }
    }
}