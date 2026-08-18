internal class Program
{

    public class Aluno
    {
        public string Nome {get;set;}
        public int Idade {get;set;}
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("=== LISTA DE ALUNOS ===");
        List<Aluno> listaAlunos = new List<Aluno>();

        Aluno aluno1 = new Aluno{Nome = "Lúcio", Idade = 16};
        Aluno aluno2 = new Aluno{Nome = "Cristiano", Idade = 17};
        Aluno aluno3 = new Aluno{Nome = "Reinaldo", Idade = 16};
        Aluno aluno4 = new Aluno{Nome = "Beto", Idade = 16};
        Aluno aluno5 = new Aluno{Nome = "Lauro", Idade = 15};

        listaAlunos.Add(aluno1);
        listaAlunos.Add(aluno2);
        listaAlunos.Add(aluno3);
        listaAlunos.Add(aluno4);
        listaAlunos.Add(aluno5);

        foreach(var aluno in listaAlunos)
        {
            Console.WriteLine($"{aluno.Nome} - {aluno.Idade}");
        }

        Console.WriteLine("=== IDADE ALTERADA ===");
        listaAlunos[1].Idade = 16;
        Console.WriteLine();

        foreach(var aluno in listaAlunos)
        {
            Console.WriteLine($"{aluno.Nome} - {aluno.Idade}");
        }

        Console.WriteLine("=== KINGNALDO REMOVIDO ===");      
        listaAlunos.Remove(aluno3);
        Console.WriteLine();
        foreach(var aluno in listaAlunos)
        {
            Console.WriteLine($"{aluno.Nome} - {aluno.Idade}");
        }
    }
}