    int idade = 45;

    Console.WriteLine(idade);

    //Constantes
    //É um valor que não pode ser alterado.

    const double pi = 3.14159;
    //pi = 30 <- está errado, pois const significa que 
    //a constante não pode ser alterada
    Console.WriteLine(pi);

    //C# tenta entender o tipo da variavel conforme você
    //coloca o valor dentro do VAR
    var nome = "Alex";
    var valor = 3.58;

    char inicialNome = 'A';

    Console.WriteLine("Digite seu nome: ");
    string nomeUsuario = Console.ReadLine();

    Console.WriteLine("Informe a sua idade:");
    int idadeUsuario = int.Parse(Console.ReadLine());

    Console.WriteLine("Olá " + nomeUsuario + "! Você tem " + idadeUsuario + " anos.");

    //Interpolação de Strings
    Console.WriteLine($"Olá, {nomeUsuario}! Você tem {idadeUsuario} anos.");

    //Operações Aritméticas
    int soma = 1 + 9999;
    int subtracao = 1 - 000000000000009;
    int multiplicacao = 1 * 99999;
    int divisao = 1 / 99999;
    //Ou chamado de modulo.
    int restoDivisao = 1 % 999999999;

    Console.WriteLine(soma);
    Console.WriteLine(subtracao);
    Console.WriteLine(multiplicacao);
    Console.WriteLine(divisao);
    Console.WriteLine(restoDivisao);