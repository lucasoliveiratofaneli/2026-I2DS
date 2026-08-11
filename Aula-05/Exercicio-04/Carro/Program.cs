internal class Program
{
    private static void Main(string[] args)
    {
        // Primeiro Carro
        Carro carro1 = new Carro();
        carro1.Marca = "Honda";
        carro1.Modelo = "Civic G10";
        carro1.Velocidade = 200;

        // Segundo Carro
        Carro carro2 = new Carro();
        carro2.Marca = "Porsche";
        carro2.Modelo = "Macan";
        carro2.Velocidade = 200;

        // Terceiro Carro
        Carro carro3 = new Carro();
        carro3.Marca = "Lamborguini";
        carro3.Modelo = "Urus";
        carro3.Velocidade = 210;

        // Exibindo os Carros
        Console.WriteLine("=== CARROS ===");

        Console.WriteLine("\nCarro 1");
        Console.WriteLine($"Marca: {carro1.Marca}");
        Console.WriteLine($"Modelo: {carro1.Modelo}");
        Console.WriteLine($"Velocidade: {carro1.Velocidade} Km/h");
        Console.WriteLine($"Acelerando: {carro1.Acelerar()} Km/h");
        Console.WriteLine($"Desacelerando: {carro1.Desacelerar()} Km/h");

        Console.WriteLine("\nCarro 2");
        Console.WriteLine($"Marca: {carro2.Marca}");
        Console.WriteLine($"Modelo: {carro2.Modelo}");
        Console.WriteLine($"Velocidade: {carro2.Velocidade} Km/h");
        Console.WriteLine($"Acelerando: {carro2.Acelerar()} Km/h");
        Console.WriteLine($"Desacelerando: {carro2.Desacelerar()} Km/h");

        Console.WriteLine("\nCarro 3");
        Console.WriteLine($"Marca: {carro3.Marca}");
        Console.WriteLine($"Modelo: {carro3.Modelo}");
        Console.WriteLine($"Velocidade: {carro3.Velocidade} Km/h");
        Console.WriteLine($"Acelerando: {carro3.Acelerar()} Km/h");
        Console.WriteLine($"Desacelerando: {carro3.Desacelerar()} Km/h");

    }

    public class Carro
    {
        public string Marca {get; set;}
        public string Modelo {get; set;}
        public int Velocidade {get; set;}

        public int Acelerar()
        {
            return Velocidade + 10;
        }

        public int Desacelerar()
        {
            return Velocidade - 10;
        }
    }

    
}