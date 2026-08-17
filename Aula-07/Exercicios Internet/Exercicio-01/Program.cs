internal class Program
{
    public class Cidade
    {
        public string? Nome {get;set;}
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("=== LISTA DE CIDADE BRASILEIRAS ===");

        // 1 - Iniciar uma nova lista
        List<Cidade> listaCidades = new List<Cidade>();

        Cidade cidade1 = new Cidade{Nome = "Bauru"};
        Cidade cidade2 = new Cidade{Nome = "Boituva"};
        Cidade cidade3 = new Cidade{Nome = "Líns"};
        Cidade cidade4 = new Cidade{Nome = "Rio Claro"};
        Cidade cidade5 = new Cidade{Nome = "São Paulo"};

        // 2 - Incluir Elementos na lista
        listaCidades.Add(cidade1);
        listaCidades.Add(cidade2);
        listaCidades.Add(cidade3);
        listaCidades.Add(cidade4);
        listaCidades.Add(cidade5);

        // 3 - Percorrer todos os elementos de uma lista
        foreach(var cidade in listaCidades)
        {
            Console.WriteLine($"{cidade.Nome}");
        }
    }
}