//Operadores lógicos e Condicionais


//Logicos nos permitem juntar perguntas
bool a = true;
bool b = false;


// && - E
//True se as duas condições forem verdadeiras
//False se as duas condições forem falsas
bool resultado = a && b;
Console.WriteLine(resultado);

// || - OU
//True se apenas uma das condições forem true
//False se as duas condições forem falsas
resultado = a || b;
Console.WriteLine(resultado);

// ! - NÃO
resultado = !a;
Console.WriteLine(resultado);


//Condicionais
//Adulto, Criança, Idoso

int idade = 61;
if (idade < 18)
{
    Console.WriteLine("Criança");
}
else if (idade >= 18 && idade <= 60)
{
    Console.WriteLine("Você é maior de idade");
}
else
{
    Console.WriteLine("Você é idoso");
}
