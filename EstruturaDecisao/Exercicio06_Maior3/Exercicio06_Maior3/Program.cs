Console.Write("Digite o primeiro número: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Digite o segundo número: ");
int num2 = int.Parse(Console.ReadLine());

Console.Write("Digite o terceiro número: ");
int num3 = int.Parse(Console.ReadLine());

if (num1 > num2)
{
    if (num1 > num3)
    {
        Console.WriteLine("O maior número é: {0} ", num1);
    }
    else
    {
        Console.WriteLine("O maior número é: {0} ", num3);
    }
}
else
{
    if (num2 > num3)
    {
        Console.WriteLine("O maior número é: {0} ", num2);
    }
    else
    {
        Console.WriteLine("O maior número é: {0} ", num3);
    }
}
