/*
 * Nível 1 — Ficha do cliente
O sistema começa cadastrando o cliente. Peçam os dados abaixo e, no final, mostrem a ficha formatada.
•	Nome e nickname (texto).
•	Plataforma: PC, PS5, Xbox ou Switch (texto).
•	Ano em que virou cliente (número inteiro).
•	Saldo em reais (número com centavos).
Exemplo:
===== CADASTRO DO CLIENTE =====
Nome: Ana Souza
Nickname: AnaGamer
Plataforma (PC, PS5, Xbox ou Switch): PS5
Cliente desde (ano): 2024
Saldo (R$): 400
 
===== FICHA DO CLIENTE =====
Nome: Ana Souza
Nickname: AnaGamer
Plataforma: PS5
Cliente desde: 2024
Saldo: R$ 400,00
 */

string nomeCliente, nickName, plataformaDeJogo;
int anoQueVirouCliente;
double saldo;

Console.WriteLine("Cadastro do Cliente");

Console.WriteLine("digite seu nome:");
nomeCliente = Console.ReadLine();

Console.WriteLine("Digite seu Nickname: ");
nickName = Console.ReadLine();

Console.WriteLine("Digite sua plataforma: ");
plataformaDeJogo = Console.ReadLine();

Console.WriteLine("Digite o ano que virou cliente: ");
anoQueVirouCliente = int.Parse(Console.ReadLine());

Console.WriteLine("Digite seu saldo");
saldo = double.Parse(Console.ReadLine());

Console.WriteLine("== FICHA DO CLIENTE ==");
Console.WriteLine("nome:" + nomeCliente);
Console.WriteLine("seu nickname: " + nickName);
Console.WriteLine("plataforma: " + plataformaDeJogo);
Console.WriteLine("data de inicio: " + anoQueVirouCliente);
Console.WriteLine($"saldo: {saldo.ToString("F2")}");


/*
 * Nível 2 — Pode comprar?
O cliente quer saber se pode comprar um jogo. Perguntem o nome, a plataforma e o preço do jogo. Aqui é só uma consulta: o saldo não muda.
Regras de negócio:
•	Jogo de outra plataforma: não pode comprar, e o sistema avisa o motivo.
•	Mesma plataforma, mas o saldo não dá: mostra quanto falta.
•	Tudo certo: pode comprar, e mostra quanto sobraria.
•	Maiúsculas e minúsculas não importam: "ps5" é igual a "PS5".
Exemplos:
Nome do jogo: Astro Bot
Plataforma do jogo: PS5
Preço (R$): 250
Pode comprar Astro Bot! Sobrariam R$ 150,00.
Nome do jogo: Halo
Plataforma Pla jogo: Xbox
Preço (R$): 200
Halo é de Xbox e seu console é PS5. Não dá.
Nome do jogo: GTA VI
Plataforma do jogo: PS5
Preço (R$): 500
Saldo insuficiente. Faltam R$ 100,
Dicas:
•	texto.ToLower() deixa tudo minúsculo — ótimo pra comparar textos digitados.
•	&& significa "E": as duas condições precisam ser verdadeiras.
Pra discutir: a ordem dos if importa? Se testarem o saldo antes da plataforma, a mensagem pro cliente continua fazendo sentido?
 Joao
 */

string nomeJogo, plataformaJogoConsulta;
double saldoJogo, saldoRestante;

Console.WriteLine("Digite o nome do jogo:");
nomeJogo = Console.ReadLine();

Console.WriteLine("Digite a plataforma do jogo:");
plataformaJogoConsulta = Console.ReadLine();

Console.WriteLine("Digite o valor do jogo:");
saldoJogo = double.Parse(Console.ReadLine());


if (plataformaJogoConsulta.ToLower() != plataformaDeJogo.ToLower())
{
    Console.WriteLine($"{nomeJogo} é de {plataformaJogoConsulta}, e seu console é {plataformaDeJogo}. Não dá");
}
else if (saldoJogo > saldo && plataformaJogoConsulta == plataformaDeJogo)
{
    saldoRestante = saldoJogo - saldo;
    Console.WriteLine($"Saldo insuficente, falta para comprar {saldoRestante}");
}
else
{
    saldoRestante = saldo - saldoJogo;
    Console.WriteLine($"Pode comprar {nomeJogo}, seu saldo atual é {saldoRestante}");
}



/*
 * Nível 3 — Biblioteca de jogos
Perguntem quantos jogos o cliente já tem, criem um array desse tamanho e peçam o nome de cada jogo. Depois, mostrem a biblioteca numerada e o total de jogos.
•	Se o usuário digitar 0 ou um número negativo, considerem 1 jogo (a biblioteca não pode ficar vazia).
DICA
string[] biblioteca = new string[quantidadeJogos];
Exemplo:
Quantos jogos você já tem? 5
Nome do jogo 1: EA FC 26
Nome do jogo 2: God of War
Nome do jogo 3: Spider-Man 2
Nome do jogo 4: Gran Turismo 7
Nome do jogo 5: It Takes Two
 
===== BIBLIOTECA DE AnaGamer =====
1 - EA FC 26
2 - God of War
3 - Spider-Man 2
4 - Gran Turismo 7
5 - It Takes Two
Total de jogos: 5
Dicas:
•	string[] biblioteca = new string[quantidade]; cria um array vazio com essa quantidade de posições.
•	biblioteca.Length diz quantas posições o array tem.
Pra discutir: o array começa no índice 0, mas a tela mostra "Nome do jogo 1". Onde fica esse "+1" no código?

 */

Console.WriteLine("Quantos jogos você já tem?");
int qtdJogos = int.Parse(Console.ReadLine());
string[] bibliotecaJogos = new string[qtdJogos];
string gameName;


for (int i = 0; i < qtdJogos; i++)
{
    Console.WriteLine("Nome do jogo " + (i + 1));
    gameName = Console.ReadLine();
    bibliotecaJogos[i] = gameName;

}

for (int i = 0; i < bibliotecaJogos.Length; i++)
{
    Console.WriteLine($"{(i + 1)} - {bibliotecaJogos[i]}");
}




/*
 * Nível 4 — Já tenho esse jogo?
O cliente digita o nome de um jogo e o sistema procura na biblioteca, pra evitar compra repetida.
•	Maiúsculas e minúsculas não importam.
•	Achou o jogo? Parem de procurar — não precisa olhar o resto do array.

DICA
Comparar apenas por minusculo
 if (biblioteca[i].ToLower() == jogoProcurado.ToLower())
Exemplos:
Qual jogo você quer verificar? spider-man 2
Você já tem spider-man 2! Não precisa comprar de novo.
Qual jogo você quer verificar? Astro Bot
Astro Bot não está na sua biblioteca.
Dicas:
•	Usem uma variável bool que começa como false e vira true quando achar o jogo.
•	break interrompe o for.
Pra discutir: por que a mensagem "não está na sua biblioteca" precisa ficar FORA do for? O que acontece se ela ficar dentro?

 */
Console.WriteLine("informe o nome do jogo que quer verificar");
string nomeJogoProcura = Console.ReadLine();

for (int i = 0; i < bibliotecaJogos.Length; i++)
{
    bool temJogo = false;
    if (nomeJogoProcura.ToLower() == bibliotecaJogos[i].ToLower())
    {
        Console.WriteLine("Você já possui esse jogo: " + nomeJogoProcura);
        temJogo = true;
        break;

    }
    else if (nomeJogoProcura.ToLower() != bibliotecaJogos[i].ToLower())
    {
        Console.WriteLine("Você não possui esse jogo " + nomeJogoProcura);
        break;
    }
}

/*
 * 
Nível 5 — Quanto já gastou
Para cada jogo da biblioteca, perguntem quanto o cliente pagou. Guardem os valores num array de números do mesmo tamanho da biblioteca.
Regras de negócio:
•	Mostrar o total gasto e a média por compra.
•	Gastou mais de R$ 500,00? É cliente VIP.
•	Não é VIP? Mostrar quanto falta pra virar.
Exemplo:
Quanto você pagou em EA FC 26? R$ 300
Quanto você pagou em God of War? R$ 150
Quanto você pagou em Spider-Man 2? R$ 250
Quanto você pagou em Gran Turismo 7? R$ 120
Quanto você pagou em It Takes Two? R$ 80
-------------------------
Total gasto: R$ 900,00
Média por compra: R$ 180,00
Status: cliente VIP!
Se não for VIP (exemplo):
Status: cliente comum. Faltam R$ 150,00 para virar VIP.
Pra discutir: a média deve ser calculada dentro ou depois do for? E quem gastou exatamente R$ 500,00 é VIP?
 */

double soma = 0;
double media = 0;
double valorOriginal;
int clienteVip = 500;
double[] valoresJogos = new double[bibliotecaJogos.Length];

for (int i = 0; i < bibliotecaJogos.Length; i++)
{
    Console.WriteLine("Quanto você pagou em " + nomeJogoProcura + "?");
    valorOriginal = double.Parse(Console.ReadLine());
    valoresJogos[i] = valorOriginal;
}

foreach (double valor in valoresJogos)
{
    soma += valor;
    media = soma / qtdJogos;
}

Console.WriteLine("Você gastou um total de: " + soma);
Console.WriteLine("A média dos valores é: " + media);

if (soma > clienteVip)
{
    Console.WriteLine("Status: Cliente vip!");

}
else if (soma == clienteVip)
{
    Console.WriteLine("Falta exatos 1 real para voce virar vip, seu pobre");
}
else
    Console.WriteLine("voce não é vip.\n Faltam:" + (clienteVip - soma));

/*
 * Nível 6 — O jogo mais caro
Sem perguntar nada novo, descubram qual foi o jogo mais caro que o cliente comprou e mostrem o nome e o valor.
Exemplo:
Jogo mais caro: EA FC 26 (R$ 300,00)
Dicas:
•	O valor está num array e o nome está em outro. O que os dois têm em comum? O índice.
•	Guardem o índice do mais caro, e não só o valor.
Pra discutir: se dois jogos custaram o mesmo valor máximo, qual deles o programa de vocês mostra? Por quê?

 */


double valorMaior = 0;
string jogoMaior = "";
for (int i = 0; i < valoresJogos.Length; i++)
{
    if (valoresJogos[i] > valorMaior)
    {
        valorMaior = valoresJogos[i];
        jogoMaior = bibliotecaJogos[i];
    }
}

Console.WriteLine($"O valor maior é {valorMaior} R${jogoMaior}");