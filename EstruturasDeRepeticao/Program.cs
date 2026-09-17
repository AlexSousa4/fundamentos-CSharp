
// 1. Contador Crescente** · `while`

//Use um laço `while` para imprimir os números de 1 a 10.
// */

//int numeros = 0;
//while (numeros < 10)
//{
//    numeros = numeros + 1;
//    Console.WriteLine(numeros);
//}


// 2. Senha Correta** · `while`
//Peça uma senha ao usuário. Enquanto ele não digitar `123`, exiba `"Senha incorreta!"` e peça novamente. Quando acertar, exiba `"Acesso liberado!"`.
// */

//Console.WriteLine("Digite a sua senha: ");
//int senha = int.Parse(Console.ReadLine());
//while (senha != 123)
//{

//    Console.WriteLine("Senha incorreta! Digite Novamente: ");
//    senha = int.Parse(Console.ReadLine());
//}
//Console.WriteLine("Acesso liberado!");


//3. Executar o Processo · `do-while`
//Exiba a mensagem `"Executando o processo..."` e pergunte se o usuário deseja executar novamente.
//Se ele digitar `s` ou `S`, repita. Caso contrário, exiba `"Processo encerrado!"`.
// */

//string usuario;
//do
//{
//    Console.WriteLine("Executando o processo...");
//    Console.WriteLine("Deseja executar novamente? Digite S ou N");
//    usuario = Console.ReadLine();
//}
//while (usuario == "S" || usuario == "s");


//4. Somador de Números `do-while`

//Peça números inteiros ao usuário e vá somando todos. O laço para quando o usuário digitar `0`. No final, exiba a soma total.
// */

//int numeroDecisivo;
//int numero1;
//int numero2;
//int resultado;

//do
//{
//    Console.WriteLine("Digite o primeiro numero: ");
//    numero1 = int.Parse(Console.ReadLine());
//    Console.WriteLine("Digite o segundo numero: ");
//    numero2 = int.Parse(Console.ReadLine());

//    resultado = numero1 + numero2;
//    Console.WriteLine(resultado);

//    Console.WriteLine("Digite zero para sair ou outro numero para continuar.");
//    numeroDecisivo = int.Parse(Console.ReadLine());

//} while (numeroDecisivo != 0);


//5. Tabuada· `for`

//Peça um número ao usuário e exiba a tabuada dele, de 1 a 10.
// */

//Console.WriteLine("Digite qual tabuada você quer a conta: ");
//int numero = int.Parse(Console.ReadLine());
//int resultadoTabuada;


//for (int i = 0; i <= 10; i++)
//{
//    resultadoTabuada = numero * i;
//    Console.WriteLine($"{numero} x {i} = {resultadoTabuada}");
//}

//6. Soma de 1 a 100· `for`
//Use um laço `for` para somar todos os números de 1 a 100 e exiba o resultado.
//*/

//int numeroSoma;
//int numeroResultado100 = 0;
//for (int i = 0; i <= 100; i++)
//{
//    numeroSoma = numeroResultado100 + i;
//    Console.WriteLine(numeroSoma);
//}

//7. Validação de Senha
//Crie um cadastro que peça uma senha ao usuário. Use `do-while` para garantir que ela tenha **no mínimo 8 caracteres**.
//Enquanto for curta, exiba `"Senha muito curta. A senha deve ter no mínimo 8 caracteres."` e peça novamente. Quando for válida, exiba `"Senha cadastrada com sucesso!"`.
//*Dica: `senha.Length` devolve a quantidade de caracteres.*
// */

//Console.WriteLine("Digite a senha: ");
//string senhaValidacao = Console.ReadLine();
//do
//{
//    Console.WriteLine("Senha muito curta. A senha deve ter no mínimo 8 caracteres.");
//    Console.WriteLine("Digite a senha novamente: ");
//    senhaValidacao = Console.ReadLine();
//}
//while (senhaValidacao.Length < 8);
//Console.WriteLine("Senha cadastrada com sucesso.");


/*
8. Cálculo de Fatorial
Peça um número inteiro não negativo e calcule o seu fatorial.
O fatorial de `n` (escrito `n!`) é o produto de todos os inteiros positivos até `n`. Exemplo: `5! = 5 × 4 × 3 × 2 × 1 = 120`.
*Dica: comece com uma variável de resultado valendo 1 e vá multiplicando.*
 */


int numeroInteiroNaoNegativo = 5;
int resultadoFatorial;

for (int i = 0; i <= numeroInteiroNaoNegativo; i++)
{
    numeroInteiroNaoNegativo = numeroInteiroNaoNegativo --;

    resultadoFatorial = numeroInteiroNaoNegativo * i;

    Console.WriteLine(resultadoFatorial);
}


////EXERCICIOS EM SALA DE AULA

//int contador = 1;

//while (contador <= 5)
//{

//    Console.WriteLine($"Repetição Número: {contador}");
//    contador++;
//}

//Console.WriteLine("Brutal, its over!");

////Use um laço While para exibir apenas numeros pares
////de 1 até 20.

//int numeros = 1;

//while (numeros <= 20)
//{
//    if (numeros % 2 == 0)
//    {
//        Console.WriteLine($"Numero {numeros} é par");
//    }
//    numeros++;
//}

////faça um laço while que o contador inicie em 30 e termine em 0

//int numero30 = 30;

//while (numero30 >= 0)
//{
//    Console.WriteLine($"Contando... {numero30}");
//    numero30--;
//}


////do while Testa a condição depois de executar o bloco.
////  dessa forma sera executado ao menos 1x.

//int age = 1;
//do
//{
//    Console.WriteLine($"Repetição do número{age}");

//} while(age > 5);



//O usuario deve enviar a senha corretamente. Enquanto ele errar
//solicite para enviar a senha novamente. A senha deve ser Senai 134

//Console.WriteLine("Digite a sua senha.");
//string senha = Console.ReadLine();
//string senhaCorreta = "Senai134";
//do
//{
//    Console.WriteLine("Senha Incorreta Tente novamente");
//    senha = Console.ReadLine();

//} while (senha != senhaCorreta);
//Console.WriteLine("aprovada");