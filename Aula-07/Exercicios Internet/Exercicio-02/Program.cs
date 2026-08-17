internal class Program
{
    public class Numeros
    {
        public int? Numero {get;set;}
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("=== LISTA NUMEROS ===");

        // 1 - Iniciar uma nova lista
        List<Numeros> listaNumeros = new List<Numeros>();

        Numeros numero1 = new Numeros{Numero = 10};
        Numeros numero2 = new Numeros{Numero = 25};
        Numeros numero3 = new Numeros{Numero = 8};
        Numeros numero4 = new Numeros{Numero = 42};
        Numeros numero5 = new Numeros{Numero = 15};
        Numeros numero6 = new Numeros{Numero = 30};

        // 2 - Incluir Elementos na lista
        listaNumeros.Add(numero1);
        listaNumeros.Add(numero2);
        listaNumeros.Add(numero3);
        listaNumeros.Add(numero4);
        listaNumeros.Add(numero5);
        listaNumeros.Add(numero6);

        // 3 - Percorrer todos os elementos de uma lista
        foreach(var numero in listaNumeros)
        {
            Console.WriteLine($"{numero.Numero}");
        }

        Console.WriteLine("");
        Console.WriteLine("=== LISTA MODIFICADA ===");
        // 4 - Alterar um elemento da lista
        listaNumeros[1].Numero = 100;
        listaNumeros.RemoveAt(5);
        Console.WriteLine();

        foreach(var numero in listaNumeros)
        {
            Console.WriteLine($"{numero.Numero}");
        }
    }
}