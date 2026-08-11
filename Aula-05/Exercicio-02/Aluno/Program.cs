internal class Program
{
    private static void Main(string[] args)
    {
        // Primeiro Aluno
        Aluno aluno1 = new Aluno();
        aluno1.RM = 7822;
        aluno1.Nome = "Gilberto Gil";
        aluno1.Nascimento = new DateOnly(01, 01, 01);
        aluno1.Email = "gilbertogildelas@gmail.com";

        // Segundo Aluno
        Aluno aluno2 = new Aluno();
        aluno2.RM = 6767;
        aluno2.Nome = "Rony Rustico";
        aluno2.Nascimento = new DateOnly(02, 02, 02);
        aluno2.Email = "ronynho67@gmail.com";

        // Terceiro Aluno
        Aluno    aluno3 = new Aluno();
        aluno3.RM = 9999;
        aluno3.Nome = "Jeffinho";
        aluno3.Nascimento = new DateOnly(03, 03, 03);
        aluno3.Email = "jeffinhodoly@gmail.com";

        // Exibindo os Alunos na Tela
        Console.WriteLine("==== ALUNOS ====");
        Console.WriteLine($"\nAluno 01: {aluno1.Nome} | Autor: {aluno1.Email}");
        Console.WriteLine($"\nAluno 02: {aluno2.Nome} | Autor: {aluno2.Email}");
        Console.WriteLine($"\nAluno 03: {aluno3.Nome} | Autor: {aluno3.Email}");
    }

    public class Aluno
    {
        public int RM {get; set;}
        public string Nome {get; set;}
        public DateOnly Nascimento {get; set;}
        public string Email {get; set;}
    }
}