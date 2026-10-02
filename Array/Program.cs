//Array armazena uma coleção de tamanho de elementos do mesmo tipo.

//criando um array e atribuindo valores diferentes

int[] numero = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

//Array sempre tem tamanho fixo
int[] numeros = new int[5]; 
for (int i = 0; i < numero.Length; i++)
{
    Console.WriteLine(numero[i]);
}

/*
 * Crie um programa que receba uma lista de 5 posições
 * Em seguida, calcule e exiba a soma de todos os elementos do array.
 */


int[] listaNumeros = new int[5];
int soma = 0;

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine("Digite um numero para a posição: " + i);
    listaNumeros[i] = int.Parse(Console.ReadLine());
    soma += listaNumeros[i];
    Console.WriteLine("A soma dos elementos nessa volta do loop é: " + soma);
}

Console.WriteLine("A soma dos elementos é: " + soma);