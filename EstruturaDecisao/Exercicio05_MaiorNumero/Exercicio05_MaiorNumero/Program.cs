Console.Write("Digite o primeiro número: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Digite o segundo número: ");
int num2 = int.Parse(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine("O maior número é: {0} ", num1);
}
else
{
    Console.WriteLine("O maior número é: {0} ", num2);
}

