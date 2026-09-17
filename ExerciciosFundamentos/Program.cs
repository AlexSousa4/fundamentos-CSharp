
//Exercícios Fundamentais

/*
1. Exibir uma Mensagem

Escreva um programa que use o comando Console.WriteLine()
para exibir a frase "Olá, Mundo!" no console.
*/

Console.WriteLine("1. Exibir uma Mensagem");

Console.WriteLine("Olá Mundo!");

/*
2. Declarar e Usar uma Variável

Crie um programa que declare uma variável inteira chamada numero com o valor 10. Em seguida, imprima o valor dessa variável no console.
*/

Console.WriteLine("2. Declarar e Usar uma Variável");

int numero = 10;
Console.WriteLine(numero);

/*
3. Fazer uma Soma

Escreva um programa que declare duas variáveis inteiras, a = 5 e b = 3.
Calcule a soma das duas e imprima o resultado.
 */

Console.WriteLine("3. Fazer uma Soma");

int a = 5;
int b = 10;

int resultado = a + b;

Console.WriteLine(resultado);

/*
4. Produto de dois números

Declare duas variáveis, num1 = 8 e num2 = 7.
Calcule o produto (multiplicação) entre elas e imprima o resultado.
*/

Console.WriteLine("4. Produto de dois números");

int num1 = 8;
int num2 = 7;

int produto = num1 * num2;

Console.WriteLine(produto);

//Exercícios Intermediários
/*
5. Saudação Personalizada

Crie um programa que declare uma variável `String` chamada `nome` com o valor `"Ana"`.
Depois, exiba uma mensagem de boas-vindas, como `"Olá, Ana!"`.
 */

Console.WriteLine("5. Saudação Personalizada");

string nome = "ana";

Console.WriteLine($"Olá {nome}!");

/*
6. Calcular o Dobro

Declare uma variável inteira valor.
Em seguida, calcule o dobro desse número utilizando a variável e exiba o resultado.
 */

Console.WriteLine("6. Calcular o Dobro");

int valor = 5;
int dobro = valor * 2;

Console.WriteLine(dobro);

/*
7. Média de três números

Escreva um programa que recebe três números e imprime a média aritmética deles.
*/

Console.WriteLine("7. Média de três números");

Console.WriteLine("Digite o primeiro número: ");
double numero1 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo número: ");
double numero2 = double.Parse(Console.ReadLine()); ;
Console.WriteLine("Digite o terceiro número: ");
double numero3 = double.Parse(Console.ReadLine()); ;

double somaValores = numero1 + numero2 + numero3;

double media = somaValores / 3;

Console.WriteLine(media);

/*
8. Ficha de Cadastro

Peça ao usuário que digite, um de cada vez, o seu **nome**, a sua **idade** e a sua **cidade**.
Depois, monte uma única frase com as três informações
 */

Console.WriteLine("8. Ficha de Cadastro");

Console.WriteLine("Digite o seu nome: ");
string nomeUsuario = Console.ReadLine();

Console.WriteLine("Digite a sua idade: ");
int idadeUsuario = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a sua cidade: ");
string cidadeUsuario = Console.ReadLine();

Console.WriteLine($"{nomeUsuario} tem {idadeUsuario} e mora em {cidadeUsuario}.");

/*
9. Comparar Dois Números

Escreva um programa que declare duas variáveis inteiras, x = 10 e y = 20.
O programa deve comparar se `x` é menor que `y` (`<`) e imprimir o resultado (`true` ou `false`) no console.
 */

Console.WriteLine("9. Comparar Dois Números");

int x = 10;
int y = 20;

if (x < y)
{
    Console.WriteLine("true");
}
else
    Console.WriteLine("false");


/*
10. Verificação de Idade para Votar

Peça ao usuário para digitar sua idade. O programa deve usar um operador de comparação para verificar se a idade é maior ou igual a 16 e imprimir o resultado
(`true` ou `false`).
- **Extra:** Adicione um comentário de uma linha (`//`) explicando o que a comparação faz.
 */

Console.WriteLine("10. Verificação de Idade para Votar");

Console.WriteLine("Digite a sua idade: ");
int idade = int.Parse(Console.ReadLine());

//Comparador que pergunta se a idade é maior ou igual que 16
bool idadeVF = true;
if (idade >= 16)
{
    idadeVF = true;
    Console.WriteLine("True");
}
else
    idadeVF = false;
    Console.WriteLine("False");

/*
11. Usando o Operador Lógico "E" (&&)

Declare uma variável int temperatura = 28. Escreva uma expressão lógica que verifique se a
`temperatura` é maior que 25 **E** menor que 30. Imprima o resultado `true` ou `false` no console.
 */

Console.WriteLine("11. Usando o Operador Lógico \"E\" (&&)");

int temperatura = 28;
if (temperatura > 25 && temperatura < 30)
{
    Console.WriteLine("True");
}
else Console.WriteLine("False");

/*
12. Usando o Operador Lógico "OU" (||)

Declare uma variável booleana temCartao = true e uma variável double compra = 50.0.
O cliente ganha um desconto se temCartao for verdadeiro OU se o valor da compra for maior que 100.0.
Escreva a expressão lógica e imprima o resultado (
`true` ou `false`).
 */

Console.WriteLine("12. Usando o Operador Lógico \"OU\" (||)");

bool temCartao = true;
double compra = 50.0;

if (temCartao == true || compra > 100)
{
    Console.WriteLine("True");
}
else Console.WriteLine("False");