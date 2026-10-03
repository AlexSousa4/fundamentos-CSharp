//Funcoes (ou metodos) 
//sao blocos de codigos que executam uma tarefa especifica
//podem ou nao receber parametros ou podem nao retornar valores


//void - (sem retorno)
//Saudacao() - sem parametro -> ()


void Saudacao()
{
    Console.WriteLine("Olá, seja bem vindo");
}

Saudacao(); //chamada da funcao


//Funcao com retorno 
//espera-se algo de volta, por isso a palavra return;

//soma recebe 2 parametros do tipo inteiro, pois como ela retorna alguma coisa
//ela pede dentro dos parametros da funcao os 2 parametros do tipo int
int soma(int a, int b)
{
    return a + b;
}


int resultado = soma (1, 2);

Console.WriteLine(resultado);

int resultado2 = soma (548465542, 5468547);

Console.WriteLine(resultado2.ToString("F2"));


void SaudacaoNome(string nome)
{
    Console.WriteLine($"Olá, seja bem vindo - {nome}");
}

SaudacaoNome("Alex");
SaudacaoNome("Carlos");
SaudacaoNome("Matheus");
SaudacaoNome("Isadora");

//Crie uma funcao CalcularMedia que receba 2 parametros
//e retorne a media deles

//a funcao vai retornar algo? se sim de qual tipo? R: nesse caso do calcular media retorna um tipo double
//caso contrário deixa void

//a funcao vai ter parametro? se sim quais e de quais tipos? R: nesse caso de calcular media ele recebe parametros do tipo int ou double,
//fica ao criterio do que foi pedido
//caso contrario deixa ()


double calcularMedia(double num1, double num2)
{
    double calculo = (num1 + num2) / 2;
    return calculo;
}

Console.WriteLine(calcularMedia(1, 99));


