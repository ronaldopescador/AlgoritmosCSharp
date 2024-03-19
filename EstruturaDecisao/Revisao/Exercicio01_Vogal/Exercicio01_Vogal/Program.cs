Console.Write("Digite uma letra: ");
char letra = Console.ReadKey().KeyChar;

Console.WriteLine();

if (letra >= 'A' && letra <= 'Z')
{
    switch (letra)
    {
        case 'A':
        case 'E':
        case 'I':
        case 'O':
        case 'U':
            Console.WriteLine($"A letra {letra} é uma vogal.");
            break;
        default:
            Console.WriteLine($"A letra {letra} é uma consoante.");
            break;
    }
}
else
{
    Console.WriteLine($"{letra} é outro caracter");
}
