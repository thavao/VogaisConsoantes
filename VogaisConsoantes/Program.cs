/*1.faça um vetor de char de 10 posições e imprima:

a) somente as vogais

b) somente as consoantes*/

char[] letras = new char[10];

Console.WriteLine("Digite 10 caracteres");

for (int i = 0; i < 10; i++)
{
    Console.Write($"Digite o {i + 1}°: ");
    letras[i] = char.Parse(Console.ReadLine());
}

Console.Write("Vogais: ");

for (int i = 0;i < 10; i++)
{
    if (letras[i] == 'a' || letras[i] == 'e' || letras[i] == 'i' || letras[i] == 'o' || letras[i] == 'u')
    {
        Console.Write($" {letras[i]} ");
    }
}

Console.WriteLine();
Console.Write("Consoantes: ");

for (int i = 0; i < 10; i++)
{
    if (letras[i] != 'a' && letras[i] != 'e' && letras[i] != 'i' && letras[i] != 'o' && letras[i] != 'u')
    {
        Console.Write($" {letras[i]} ");
    }
}

Console.WriteLine();
Console.WriteLine("Pressione Enter para encerrar...");
Console.ReadLine();