/*                      Fundamentais 
 * **Exercício 1: Boas-vindas**

Crie uma função sem retorno chamada `ExibirBoasVindas` que não receba parâmetros e exiba no console a mensagem:
`"Bem-vindo ao curso de C#!"`. Chame a função duas vezes.
 */

using System.Net.Http.Headers;

void ExibirBoasVindas()
{
    Console.WriteLine("Bem vindo ao curso de C#");
}

ExibirBoasVindas();
ExibirBoasVindas();


/*
 * **Exercício 2: Dobro de um número**

Crie uma função chamada `Dobro` que receba um número inteiro e retorne o dobro dele. Exiba o resultado para os números 4, 15 e 100.
 */

int dobro (int x)
{
    int numeroDobrado = x * 2;
    return numeroDobrado;
}

Console.WriteLine(dobro(4));
Console.WriteLine(dobro(15));
Console.WriteLine(dobro(100));


/*
 * **Exercício 3: Par ou ímpar**

Crie uma função chamada `EhPar` que receba um número inteiro e retorne `true` se ele for par ou `false` se for ímpar.
Teste com os números 7 e 10, exibindo no console se cada um é par ou ímpar.
 */

bool ehPar(int numPar)
{
    
    if (numPar % 2 == 0)
    {
        Console.WriteLine("Esse numero é par: " + numPar);
        return true;
    }
    else
    {
        Console.WriteLine("Esse numero é impar: " + numPar);
        return false;
    }
    
}

ehPar(7);
ehPar(10);


/*
 * **Exercício 4: Saudação com curso**

Crie uma função sem retorno chamada `SaudarAluno` que receba o nome do aluno e o nome do curso. O curso deve ter o valor padrão `"Programação"`.
A função deve exibir: `"Olá, [nome]! Bem-vindo ao curso de [curso]."`. Chame a função uma vez informando só o nome e outra vez informando nome e curso.
 */

void saudarAluno(string nomeAluno, string nomeCurso = "Programação")
{
    Console.WriteLine($"Olá {nomeAluno}! Bem-vindo ao curso de {nomeCurso}");
}

saudarAluno("Alex");
saudarAluno("Isadora", "C# do Senai");


/*                  Médios
 * **Exercício 5: Situação do aluno**

Crie duas funções:

- `CalcularMedia`: recebe três notas (`double`) e retorna a média.
- `ObterSituacao`: recebe a média e retorna uma `string`:
    - `"Aprovado"` se a média for maior ou igual a 7
    - `"Recuperação"` se a média for maior ou igual a 5 e menor que 7
    - `"Reprovado"` se a média for menor que 5

Peça as três notas ao usuário, calcule a média e exiba a média e a situação.
 */


double calcularMedia(double valorNota1, double valorNota2, double valorNota3)
{
    return (valorNota1 + valorNota2 + valorNota3) / 3;
}


string obterSituacao(double mediaSituacao)
{
    if (mediaSituacao >= 7)
    {
        return "Aprovado!";
    }
    else if (mediaSituacao >= 5 && mediaSituacao < 7) {
        return "Recuperação";
    }
    else
    {
        return "Reprovado";
    }
}

double resultadoMedia1 = calcularMedia(8, 9.9, 9.7);
double resultadoMedia2 = calcularMedia(8.5, 4.6, 6.9);
double resultadoMedia3 = calcularMedia(3, 4, 2);

Console.WriteLine(obterSituacao(resultadoMedia1));
Console.WriteLine(obterSituacao(resultadoMedia2));
Console.WriteLine(obterSituacao(resultadoMedia3));


/*
 * **Exercício 6: Tabuada personalizada**
Crie uma função sem retorno chamada `ExibirTabuada` que receba um número inteiro e um limite (valor padrão = 10).
A função deve exibir a tabuada do número de 1 até o limite, no formato `5 x 1 = 5`. Teste chamando `ExibirTabuada(7)` e `ExibirTabuada(3, 5)`.
*/

void exibirTatuada(int valorInteiro, int valorPadrao = 10)
{
    Console.WriteLine($"\nTabuada do {valorInteiro}");
    for (int i = 0; i <= valorPadrao; i++)
    {
        int resultado = valorInteiro * i;
        Console.WriteLine($"{valorInteiro} x {i} = {resultado}");
    }
}
exibirTatuada(7);
exibirTatuada(5, 8);


/*
**Exercício 7: Desconto na loja**

Crie uma função chamada `AplicarDesconto` que receba o preço de um produto e o percentual de desconto (valor padrão = 10).
A função deve retornar o preço final com o desconto aplicado. Se o percentual for menor que 0 ou maior que 100, a função deve retornar o preço original sem desconto. Teste com:

- Preço 200 sem informar desconto
- Preço 200 com 25% de desconto
- Preço 200 com 150% de desconto (inválido)
 */

double aplicarDesconto(double precoProduto, double percentualDesconto = 10)
{
    
    double valorDesconto = (precoProduto * percentualDesconto) / 100;
    if (percentualDesconto < 0 || percentualDesconto > 100)
    {
        Console.WriteLine("Valor de desconto inválido");
        return precoProduto;
    }else
    {
        return precoProduto / percentualDesconto;
    }
}

Console.WriteLine("\n" + aplicarDesconto(200));
Console.WriteLine(aplicarDesconto(200, 25));
Console.WriteLine(aplicarDesconto(200, 150));


/*                  Difíceis
 * **Exercício 8: Números primos**

Crie duas funções:

- `EhPrimo`: recebe um número inteiro e retorna `true` se for primo e `false` caso contrário. Lembre-se: números menores que 2 não são primos.
- `ListarPrimos`: função sem retorno que recebe um limite e exibe todos os números primos de 2 até esse limite, **usando a função `EhPrimo`**.

Peça ao usuário um limite e exiba os primos até ele.
 */

bool ehPrimo(int numeroPrimo)
{
    if(numeroPrimo < 2)
    {
        Console.WriteLine("Numero não é primo");
        return false;
    }
    for (int i = 2; i * i <= numeroPrimo; i++)
    {
        if (i % numeroPrimo != 0)
        {
            Console.WriteLine("Numero é primo");
            return false;
        }
    }
    return true;
}

void listarPrimos(int numeroLimite)
{
    Console.WriteLine("Primos até " + numeroLimite + ":");

    for(int i = 2; i <= numeroLimite; i++)
    {
        if(ehPrimo(i)) Console.WriteLine(i + " ");
    }
    Console.WriteLine();   
}

Console.WriteLine("Digite o limite: ");
int limite = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o numero: ");

ehPrimo(1);