Console.Write("Digite sua idade: ");
int idade = int.Parse(Console.ReadLine());

if (idade < 15)
{
    Console.WriteLine("Você é uma criança!");
}
else if (idade <= 29)
{
    Console.WriteLine("Você é um jovem!");
}
else
{
    Console.WriteLine("Você é um adulto!");
}

