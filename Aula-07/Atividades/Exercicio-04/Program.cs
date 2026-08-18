internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== fila de atendimento ===");

        Queue<string> filaDoPao = new Queue<string>();

        filaDoPao.Enqueue ("João");         // 0
        filaDoPao.Enqueue ("Maria");        // 1
        filaDoPao.Enqueue ("Carlos");       // 2
        filaDoPao.Enqueue ("Ana");          // 3
        filaDoPao.Enqueue ("Pedro");        // 4

        Console.WriteLine();
        foreach (var pessoa in filaDoPao)
        {
            Console.WriteLine(pessoa);
        }

        string pessoaRetirada = filaDoPao.Dequeue();
        Console.WriteLine();
        Console.WriteLine($"O Nome chamado foi: {pessoaRetirada}");

        filaDoPao.Enqueue("Lucas");

        Console.WriteLine();
        foreach (var pessoa in filaDoPao)
        {
            Console.WriteLine(pessoa);
        }
    }
}