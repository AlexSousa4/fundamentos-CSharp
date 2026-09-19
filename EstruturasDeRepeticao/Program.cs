
// 1. Contador Crescente** · `while`

//Use um laço `while` para imprimir os números de 1 a 10.
// */

int numeros = 0;
while (numeros < 10)
{
    numeros = numeros + 1;
    Console.WriteLine(numeros);
}


// 2. Senha Correta** · `while`
//Peça uma senha ao usuário. Enquanto ele não digitar `123`, exiba `"Senha incorreta!"` e peça novamente. Quando acertar, exiba `"Acesso liberado!"`.
// */

Console.WriteLine("Digite a sua senha: ");
int senha = int.Parse(Console.ReadLine());
while (senha != 123)
{

    Console.WriteLine("Senha incorreta! Digite Novamente: ");
    senha = int.Parse(Console.ReadLine());
}
Console.WriteLine("Acesso liberado!");


//3. Executar o Processo · `do-while`
//Exiba a mensagem `"Executando o processo..."` e pergunte se o usuário deseja executar novamente.
//Se ele digitar `s` ou `S`, repita. Caso contrário, exiba `"Processo encerrado!"`.
// */

string usuario;
do
{
    Console.WriteLine("Executando o processo...");
    Console.WriteLine("Deseja executar novamente? Digite S ou N");
    usuario = Console.ReadLine();
}
while (usuario == "S" || usuario == "s");


//4. Somador de Números `do-while`

//Peça números inteiros ao usuário e vá somando todos. O laço para quando o usuário digitar `0`. No final, exiba a soma total.
// */

int numeroDecisivo;
int numeroSomaTotal;
int resultado = 0;

do
{
    Console.WriteLine("Digite o primeiro numero: ");
    numeroSomaTotal = int.Parse(Console.ReadLine());
    resultado += numeroSomaTotal;

    Console.WriteLine("Digite zero para sair ou outro numero para continuar.");
    numeroDecisivo = int.Parse(Console.ReadLine());

} while (numeroDecisivo != 0);
Console.WriteLine(resultado);

//5. Tabuada· `for`

//Peça um número ao usuário e exiba a tabuada dele, de 1 a 10.
// */

Console.WriteLine("Digite qual tabuada você quer a conta: ");
int numero = int.Parse(Console.ReadLine());
int resultadoTabuada;


for (int i = 0; i <= 10; i++)
{
    resultadoTabuada = numero * i;
    Console.WriteLine($"{numero} x {i} = {resultadoTabuada}");
}

//6. Soma de 1 a 100· `for`
//Use um laço `for` para somar todos os números de 1 a 100 e exiba o resultado.
//*/

int numeroSoma;
int numeroResultado100 = 0;
for (int i = 0; i <= 100; i++)
{
    numeroSoma = numeroResultado100 + i;
    Console.WriteLine(numeroSoma);
}

//7. Validação de Senha
//Crie um cadastro que peça uma senha ao usuário. Use `do-while` para garantir que ela tenha **no mínimo 8 caracteres**.
//Enquanto for curta, exiba `"Senha muito curta. A senha deve ter no mínimo 8 caracteres."` e peça novamente. Quando for válida, exiba `"Senha cadastrada com sucesso!"`.
//*Dica: `senha.Length` devolve a quantidade de caracteres.*
// */

Console.WriteLine("Digite a senha: ");
string senhaValidacao = Console.ReadLine();
do
{
    Console.WriteLine("Senha muito curta. A senha deve ter no mínimo 8 caracteres.");
    Console.WriteLine("Digite a senha novamente: ");
    senhaValidacao = Console.ReadLine();
}
while (senhaValidacao.Length < 8);
Console.WriteLine("Senha cadastrada com sucesso.");


/*
8. Cálculo de Fatorial
Peça um número inteiro não negativo e calcule o seu fatorial.
O fatorial de `n` (escrito `n!`) é o produto de todos os inteiros positivos até `n`. Exemplo: `5! = 5 × 4 × 3 × 2 × 1 = 120`.
*Dica: comece com uma variável de resultado valendo 1 e vá multiplicando.*
 */


int numeroInteiroNaoNegativo = 5;
int resultadoFatorial = 1;

for (int i = 1; i <= numeroInteiroNaoNegativo; i++)
{

    resultadoFatorial = resultadoFatorial * i;

    Console.WriteLine(resultadoFatorial);
}


/*
9. Jogo de Adivinhação

O programa sorteia um número inteiro entre 1 e 100. O jogador tenta adivinhar qual é.
A cada tentativa, informe se o número secreto é **maior** ou **menor** que o palpite. O jogo termina quando o jogador acerta. No final, mostre quantas tentativas foram necessárias.

*Dica: `int numeroSecreto = new Random().Next(1, 101);`*
 */

Console.WriteLine("Bem-vindo ao Jogo de Adivinhação!");
int palpite;
int numeroSecreto = new Random().Next(1, 101);
int tentativas = 0;
do
{
    Console.WriteLine("Digite o número que você acha que é o secreto:");
    palpite = int.Parse(Console.ReadLine());
    if (numeroSecreto < palpite)
    {
        Console.WriteLine("O numero é menor que o palpite, tente novamente");
    }
    else if (numeroSecreto > palpite)
    {
        Console.WriteLine("O numero é maior que o palpite, tente novamente");
    }
    else
    {
        Console.WriteLine($"Parabéns! Você acertou o número secreto {numeroSecreto} em {tentativas} tentativas.");
    }
    tentativas++;
} while (palpite != numeroSecreto);


/*
 10. Calculadora Interativa

Desenvolva uma calculadora com as quatro operações básicas. O programa deve:

1. Exibir um menu com as opções (somar, subtrair, multiplicar, dividir, sair).
2. Pedir ao usuário para escolher uma operação.
3. Pedir dois números.
4. Exibir o resultado.
5. Voltar ao menu, repetindo até que o usuário escolha "Sair".

*Dica: use `do-while` para o menu e `if/else` ou `switch` para as operações.*
 */

int operacao = 0;
int resultadoEx10;
int numero1;
int numero2;
while (operacao != 5)
{
    Console.WriteLine("Bem vindo a Calculadora!");
    Console.WriteLine("Digite qual operação deseja realizar: ");
    Console.WriteLine("1. Somar");
    Console.WriteLine("2. Subtrair");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    Console.WriteLine("5. Sair");
    operacao = int.Parse(Console.ReadLine());


    switch (operacao)
    {
        case 1:
            Console.WriteLine("Soma");
            Console.WriteLine("Digite o primeiro número:");
            numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            numero2 = int.Parse(Console.ReadLine());
            resultado = numero1 + numero2;
            Console.WriteLine($"O resultado da soma é: {resultado}\n");
            break;
        case 2:
            Console.WriteLine("Subtração");
            Console.WriteLine("Digite o primeiro número:");
            numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            numero2 = int.Parse(Console.ReadLine());
            resultado = numero1 - numero2;
            Console.WriteLine($"O resultado da subtração é: {resultado}\n");
            break;
        case 3:
            Console.WriteLine("Multiplicação");
            Console.WriteLine("Digite o primeiro número:");
            numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            numero2 = int.Parse(Console.ReadLine());
            resultado = numero1 * numero2;
            Console.WriteLine($"O resultado da multiplicação é: {resultado}\n");
            break;
        case 4:
            Console.WriteLine("Divisão");
            Console.WriteLine("Digite o primeiro número:");
            numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            numero2 = int.Parse(Console.ReadLine());
            resultado = numero1 / numero2;
            Console.WriteLine($"O resultado da divisão é: {resultado}\n");
            break;
        case 5:
            // Lógica para sair
            break;
    }

}

