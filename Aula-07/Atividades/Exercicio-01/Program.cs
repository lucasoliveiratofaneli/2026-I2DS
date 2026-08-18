internal class Program
{

    public class Fruta
    {
        public string? Nome {get;set;}
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("===  LISTA DE FRUTAS ===");

        List<Fruta> listaFrutas = new List<Fruta>();

        Fruta fruta1 = new Fruta{Nome = "Laranja"};
        Fruta fruta2 = new Fruta{Nome = "Abacaxi"};
        Fruta fruta3 = new Fruta{Nome = "Banana"};
        Fruta fruta4 = new Fruta{Nome = "Pera"};
        Fruta fruta5 = new Fruta{Nome = "Caqui"};
        Fruta fruta6 = new Fruta{Nome = "Maça"};

        listaFrutas.Add(fruta1);
        listaFrutas.Add(fruta2);
        listaFrutas.Add(fruta3);
        listaFrutas.Add(fruta4);
        listaFrutas.Add(fruta5);

        foreach(var fruta in listaFrutas)
        {
            Console.WriteLine($"{fruta.Nome}");
        }

        Console.WriteLine("=== NOVA FRUTA ADICIONADA A LISTA ===");

        listaFrutas.Add(fruta6);

        foreach(var fruta in listaFrutas)
        {
            Console.WriteLine($"{fruta.Nome}");
        }





    }
}