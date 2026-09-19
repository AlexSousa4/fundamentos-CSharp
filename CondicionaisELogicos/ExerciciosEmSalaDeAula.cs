using System;
using System.Collections.Generic;
using System.Text;



class ExerciciosEmSalaDeAula
{
    public static void Main(string[] args)
    {
        //EXERCICIOS EM SALA DE AULA
        //Use um laço While para exibir apenas numeros pares
        //de 1 até 20.

        int numerosWhile = 1;

        while (numerosWhile <= 20)
        {
            if (numerosWhile % 2 == 0)
            {
                Console.WriteLine($"Numero {numerosWhile} é par");
            }
            numerosWhile++;
        }

        //faça um laço while que o contador inicie em 30 e termine em 0

        int numero30 = 30;

        while (numero30 >= 0)
        {
            Console.WriteLine($"Contando... {numero30}");
            numero30--;
        }


        //do while Testa a condição depois de executar o bloco.
        //  dessa forma sera executado ao menos 1x.

        int age = 1;
        do
        {
            Console.WriteLine($"Repetição do número{age}");

        } while (age > 5);



        //O usuario deve enviar a senha corretamente. Enquanto ele errar
        //solicite para enviar a senha novamente. A senha deve ser Senai 134

        Console.WriteLine("Digite a sua senha.");
        string senhaUsuario = Console.ReadLine();
        string senhaCorreta = "Senai134";
        do
        {
            Console.WriteLine("Senha Incorreta Tente novamente");
            senhaUsuario = Console.ReadLine();

        } while (senhaUsuario != senhaCorreta);
        Console.WriteLine("aprovada");


        //utilizando for exiba os numeros de 0 até 20, imprimindo de 2 em 2

        int numerosPares = 20;
        for (int i = 0; i <= numerosPares; i += 2)
        {
            Console.WriteLine(i);
        }


    }
}