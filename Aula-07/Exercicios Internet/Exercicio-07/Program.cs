using System.Reflection.Metadata;

internal class Program
{
    public class Produtos
    {
        public int? Id {get;set;}
        public string? Nome {get;set;}
        public double Preco {get; set;} 
    }
    private static void Main(string[] args)
    {   
        Produtos prod1 = new Produtos {
            Id = 1287, 
            Nome = "Doly Guaraná", 
            Preco = 5.99
        };
        Produtos prod2 = new Produtos {
            Id = 6435, 
            Nome = "Suco Tang de Groselha", 
            Preco = 3.99
        };
        Produtos prod3 = new Produtos {
            Id = 2839, 
            Nome = "Motorola", 
            Preco = 1000.00
        };
        Produtos prod4 = new Produtos {
            Id = 3198, 
            Nome = "Bombrio", 
            Preco = 21.99
        };
        Produtos prod5 = new Produtos {
            Id = 9685, 
            Nome = "Lanche Natural", 
            Preco = 50.99
        };

        // Criar um lista de colaboradores
        List<Produtos> listaProd = new List<Produtos>();
        listaProd.Add(prod1);
        listaProd.Add(prod2);
        listaProd.Add(prod3);
        listaProd.Add(prod4);
        listaProd.Add(prod5);


        Console.WriteLine("\n=== LISTA ORDENADA POR PREÇO ===");
        var listaPreco = listaProd.OrderBy(c => c.Preco).ToList();
        ImprimirLista(listaPreco);

        Console.WriteLine("\n=== LISTA DE PRODUTOS MAIORES QUE R$ 50,00 ===");
        var listaPrecoAlto = listaProd
        .Where(colab => colab.Preco >= 50)
        .OrderBy(colab => colab.Preco)
        .ToList();
        
        ImprimirLista(listaPrecoAlto);



    }


    public static void ImprimirLista(List<Produtos> lista)
    {
        Console.WriteLine();
        foreach (var produtos in lista)
        {
            Console.WriteLine($"Produtos Encontrados: Nome: {produtos.Nome} - Preço R$: {produtos.Preco:F2}");
        }
    }
}