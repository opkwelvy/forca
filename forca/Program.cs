
//Criação do vertor
string[] palavras = { "olho", "tapete", "banana", "valorant", "smartphone", "computador" };
//Criação do método random, que cria uma forma de puxar um número aleatório
Random nAleatorio = new Random();
//Adicionando o uma palavra aleatória na variavel número
int numero = nAleatorio.Next(palavras.Length);
//Escolha da palavra aleatória
string palavra = palavras[numero];
Console.WriteLine("-------------------------------------------------------------------------------------");
Console.WriteLine("SEJA BEM VINDO AO JOGO DA FORCA!");
Console.WriteLine("Adivinhe a palavra e ganhe meus parabéns :p");
Console.WriteLine("-------------------------------------------------------------------------------------");

//Montagem da palavra cifrada
string travessao = string.Concat(Enumerable.Repeat("_", palavra.Length));
//Transformando a palavra em um vetor de caracteres
char[] palavraVetor = palavra.ToCharArray();
char[] travessaoVetor = travessao.ToCharArray();

//Sistema de dicas
if (palavra == palavras[0])
{
    Console.WriteLine("Dica: Parte do corpo humano*");
}
else if (palavra == palavras[1])
{
    Console.WriteLine("Dica: Decoração*");
}
else if (palavra == palavras[2])
{
    Console.WriteLine("Dica: Fruta*");
}
else if (palavra == palavras[3])
{
    Console.WriteLine("Dica: Jogo*");
}
else if (palavra == palavras[4])
{
    Console.WriteLine("Dica: Eletrônico*");
}
else if (palavra == palavras[5])
{
    Console.WriteLine("Dica: Eletrônico*");
}
//Sistema de looping para o usuário não sair enquanto não terminar.

Console.WriteLine("-------------------------------------------------------------------------------------");
Console.WriteLine("Escolha uma letra e aperte 'ENTER' ");
Console.WriteLine("Caso coloque uma palavra inteira, apenas a primeira letra será considerada");
Console.WriteLine(travessaoVetor);
Console.WriteLine("-------------------------------------------------------------------------------------");
bool desafio = false;
int progresso = 0;
while (desafio != true)
{

    //Pesquisei uma forma de transformar o dado de entrada que é string para char
    string letra = Console.ReadLine();
    char caractere = letra[0];
    //For passando por todo o vetor verificando se algum é igual
    for (int i = 0; i < palavraVetor.Length; i++)
    { 
        if (caractere == palavraVetor[i])
        {
            travessaoVetor[i] = caractere;
            progresso = progresso + 1;
        }
    }
    if (progresso == palavraVetor.Length)
    {
        break;
    }
    Console.WriteLine(travessaoVetor);
    Console.WriteLine("-------------------------------------------------------------------------------------");
    Console.WriteLine("Escolha uma letra e aperte 'ENTER' ");
}
Console.WriteLine("Parabéns você acertou a palavra!!");
Console.WriteLine(travessaoVetor);