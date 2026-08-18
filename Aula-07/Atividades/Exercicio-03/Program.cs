internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== AGENDA TELEFÔNICA ===");
        Dictionary<string, string> contatos = new Dictionary<string, string>();


        contatos.Add("Wellinton","14-982789382");
        contatos.Add("Jussara","14-254715896");
        contatos.Add("Ratolino","14-259745368");

        Console.WriteLine();
        foreach (var item in contatos)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }

        Console.WriteLine();
        Console.WriteLine("=== PROCURANDO JUSSARA ===");
        bool contatoExiste = contatos.ContainsKey("Jussara");
        Console.WriteLine();
        if (contatoExiste)
        {
            Console.WriteLine($"Você encontrou o contato Jussara");
        }
        else
        {
            Console.WriteLine("Este contato não existe");
        }
        Console.WriteLine();
        Console.WriteLine("=== ALTERANDO NÚMERO DE JUSSARA ===");
        contatos["Jussara"] = "14-988189980";
        Console.WriteLine();
        foreach (var item in contatos)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }

        Console.WriteLine();
        Console.WriteLine("=== REMOVENDO JUSSARA===");
        contatos.Remove("Jussara");
        Console.WriteLine();
        foreach (var item in contatos)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }
    }
}