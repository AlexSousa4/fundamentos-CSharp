//Exercicios Fundamentais

/*
1. Verificador de Maioridade

Crie um programa que declare uma variável **`idade`**. 

Use uma estrutura **`if/else`** para verificar se a idade é **maior ou igual a 18**. 

O programa deve imprimir "*Você é maior de idade*" se a condição for verdadeira, e "*Você é menor de idade*" caso contrário
 */

Console.WriteLine("Digite a sua idade: ");
int idade = int.Parse(Console.ReadLine());

if (idade >= 18)
{
    Console.WriteLine("Você é maior de Idade");
}
else
{
    Console.WriteLine("Você é menor de idade");
}

/*
2. Verificador de Número (Positivo, Negativo ou Zero)
Crie um programa que declare uma variável **`numero`**; 
Utilize uma estrutura **`if/else if/else`** para verificar e imprimir uma das seguintes mensagens:
"*O número é positivo.*", "*O número é negativo.*" ou "*O número é zero.*".
 */

Console.WriteLine("Digite um numero: ");
int numero = int.Parse(Console.ReadLine());

if (numero > 0)
{
    Console.WriteLine("Numero é positivo");
}
else if (numero < 0)
{
    Console.WriteLine("Numero é negativo");
}
else 
{
    Console.WriteLine("Numero é zero");
}


/*
3. Classificação de Aluno
Crie um programa que use a classe para pedir ao usuário que digite a nota de um aluno (um valor **`double`**). 
Em seguida, use uma estrutura **`if/else`** simples para imprimir "Aprovado" se a nota for maior ou igual a 7.0, e "Reprovado" caso contrário
 */

Console.WriteLine("Digite a nota do aluno: ");
double notaAluno = double.Parse(Console.ReadLine());

if (notaAluno > 7.0)
{
    Console.WriteLine("Aprovado");
}
else
{
    Console.WriteLine("Reprovado");
}


//Exercicios Intermediarios

/*
4. Classificação por Faixa Etária
Peça a idade do usuário e classifique: até 12 anos → `"Criança"`, de 13 a 17 → `"Adolescente"`, 18 ou mais → `"Adulto"`.
Use condicional encadeada (`else if`).
 */

Console.WriteLine("Digite a idade: ");
int idadeEtaria = int.Parse(Console.ReadLine());

if (idadeEtaria > 18)
{
    Console.WriteLine("Adulto");
}
else if (idadeEtaria > 12)
{
    Console.WriteLine("Adolescente");
}
else
{
    Console.WriteLine("Criança");
}


/*
5. Status de Tarefa
Declare uma variável **`boolean tarefaConcluida`**. 
Usando uma estrutura **`if/else`**, exiba a mensagem "A tarefa está pendente!" se a variável for **`false`**, 
e "A tarefa foi finalizada com sucesso!" se for **`true`**.
 */

bool tarefaConcluida = false;
if (tarefaConcluida == true)
{
    Console.WriteLine("A tarefa foi finalizada com sucesso!");
}
else
{
    Console.WriteLine("A tarefa está pendente");
}

/*
6. Nota Válida (operador &&)
Peça uma nota ao usuário. Use o operador `&&` para verificar se ela está dentro do intervalo válido (entre 0 e 10).
Exiba `"Nota válida"` ou `"Nota inválida"`.
 */

Console.WriteLine("Digite uma nota: ");
double nota = double.Parse(Console.ReadLine());
if (nota > 0 && nota < 10)
{
    Console.WriteLine("Nota válida");
}
else
{
    Console.WriteLine("Nota inválida");
}

/*
7. Aprovação de Empréstimo
Para aprovar um empréstimo, um banco exige que o cliente tenha um salário mensal de pelo menos R$ 2.000,00 e não possua restrições de crédito. 
Crie um programa com as variáveis **`double salarioMensal`**; e **`boolean possuiRestricao`** .
Use o operador lógico "E" (**`&&`**) em uma estrutura **`if`** para determinar e imprimir "Empréstimo aprovado." ou "Empréstimo negado."
 */

double salarioMensal = 2500;
bool possuiRestricao = false;

if (salarioMensal > 2000 && possuiRestricao == false)
{
    Console.WriteLine("Empréstimo aprovado.");
}
else
{
    Console.WriteLine("Empréstimo Negado.");
}

/*
8. Classificação de Média Escolar Completa
Crie um programa que solicita ao usuário que digite uma nota (um valor
**`double`**). Utilizando uma estrutura **`if/ else if /else`**, classifique a nota da seguinte forma:
- Se a nota for 7.0 ou maior, imprima "Aprovado!".
- Se a nota for maior ou igual a 5.0, mas menor que 7.0, imprima "Recuperação.".
- Se a nota for menor que 5.0, imprima "Reprovado.".
 */

Console.WriteLine("Digite uma nota: ");
double notas = double.Parse(Console.ReadLine());

if (notas >= 7.0)
{
    Console.WriteLine("Aprovado");
}
else if (notas >= 5.0)
{
    Console.WriteLine("Recuperação");
}
else
{
    Console.WriteLine("Reprovado");
}

//Exercicios Avançados

/*
9. Par ou Ímpar com Operador Ternário**
Declare uma variável **`numero`**; Utilizando o operador ternário (**`? :`**), crie uma variável String resultado que receba o texto "Par" se o número for par, ou "Ímpar" se for ímpar.
Ao final, imprima o resultado.
**Dica:** O operador de módulo **`%`** (resto da divisão), apresentado no material, é perfeito para isso.
 */

int numeros = 5;

string resultado = (numeros % 2 == 0) ? "Par" : "Impar";

Console.WriteLine(resultado);


/*
10. Cálculo de Desconto Progressivo

Uma loja oferece descontos baseados no valor da compra. Crie um programa que declare uma variável

`double valorCompra = 150.0;` e aplique as seguintes regras usando `if/else if/else`:

- Compras acima de R$ 200,00 têm 20% de desconto.
- Compras entre R$ 100,00 (inclusive) e R$ 200,00 (exclusive) têm 10% de desconto.
- Compras abaixo de R$ 100,00 não têm desconto.
    
    O programa deve usar os operadores aritméticos para calcular e exibir o valor final a ser pago.
 */

double valorCompra = 101.0;

if (valorCompra > 250.00)
{
    valorCompra = valorCompra - (valorCompra * 0.20);
    Console.WriteLine($"Você recebeu 20% de desconto, valor da compra: R${valorCompra}");
}
else if(valorCompra >= 100.0 && valorCompra <= 200.0)
{
    valorCompra = valorCompra - (valorCompra * 0.10);
    Console.WriteLine($"Você recebeu 10% de desconto, valor da compra: R${valorCompra}");
}
else
{
    Console.WriteLine("Não tem desconto");
}