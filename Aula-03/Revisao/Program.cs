internal class Program
{
    private static void Main(string[] args)
    {
        // Criar uma variável
        // Sintaxe: tipo variável nome variável = valor

        // Tipos de dados Primários
        /* int -> Representação de Números Inteiros */
        int idade = 21;
        
        /* double -> Representação de Números Decimais */
        double salario =10352.25;
        float altura = 1.85f;
        decimal peso = 70.50m;

        /* string -> Representação de um texto alphanumerico */

        string nome = "Victor";
        string celular = "141122334455";
        string cpf = "123.456.789-05";

        /* bool -> Representação um Número Booleano (True or False) */

        bool estudante = true;
        bool temLimite = false; 

        /* DateTime -> Representação de data e Hora */
        
        DateTime cadastro = new DateTime(2026,08,04,09,15,32);
        DateOnly nascimento = new DateOnly(2010,01,20);

        /* *************************************************************************** */
        /* Operadores Matemáticos
        
        + -> Somar
        - -> Subtrair
        * -> Multiplicar
        / -> Divisão
        % -> Resto da Divisão
        ^ -> Exponenciação
        = -> Atribuição


        */
 
        int n1 = 10;
        int n2 = 3;
        double resultado = 0;

        // Calcular  a Soma: 
        resultado = n1 + n2;
        Console.WriteLine("A soma dos dois numeros é: " + resultado);

        // Calcular  a Subtracao: 
        resultado = n1 - n2;
        Console.WriteLine("A subtração dos dois numeros é: " + resultado);

        // Calcular  a Multiplicação: 
        resultado = n1 * n2;
        Console.WriteLine("A multiplicação dos dois numeros é: " + resultado);

        // Calcular  a Divisão: 
        resultado = n1 / n2;
        Console.WriteLine("A divisão dos dois numeros é: " + resultado);

         // Calcular resto da Divisão: 
        resultado = n1 % n2;
        Console.WriteLine("O resto da divisão dos dois numeros é: " + resultado);

         // Calcular a Potência: 
        resultado = n1 ^ n2;
        Console.WriteLine("O numero 1 elevado ao numero 2 é: " + resultado);

        Console.WriteLine("Valor de N1: " + n1);
        
        /** Operador de Incremento ++ **/
        n1++; // Aumento o Numero atual em + 1
        Console.WriteLine("Valor de N1: " + n1);

        /** Operador de Incremento += **/
        n1+=10; // n1 = n1 + 10;
        Console.WriteLine("Valor de N1: " + n1); 

        
        /** Operador de Decremento -- **/
        n1--; // Aumento o Numero atual em + 1
        Console.WriteLine("Valor de N1: " + n1);

        /** Operador de Decremento -= **/
        n1-=10; // n1 = n1 - 10;
        Console.WriteLine("Valor de N1: " + n1);

        /***********************************************************/
        /* Operadores Relacionais -> Realizam Comparações */
        /* 
        > -> Maior que
        < -> Menor que 
        >= -> Maior ou igual
        > -> Menor ou igual   
        == -> igual
        != -> Diferentes
        */

        idade = 13;
        Console.WriteLine("A idade informada é Maior que 18? " + (idade > 18));

        peso = 59;
        Console.WriteLine("O peso informado é Menor que 60 kg? " + (peso <= 60));

        estudante = false;
        Console.WriteLine("O nome informado é de um estudante? " + (estudante == true));

        /**************************************************************************************/
        // Operadores Logicos -> Permitem combinar duas ou mais condições */
        // && -> Operador Lógico "E"
        // || -> Operador Lógico "OU"
        // ! -> Operador de Negação.
        

        peso = 83;
        altura = 183;

        Console.WriteLine("Peso: " + peso + "Altura:" + altura);
        Console.Write((peso <= 100) && (altura > 180));

  
    }
}