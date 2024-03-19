Console.Write("Digite o primeiro número: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o segundo número: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o terceiro número: ");
int num3 = Convert.ToInt32(Console.ReadLine());

// Ordena os números em ordem ascendente
if (num1 > num2)
{
    int temp = num1;
    num1 = num2;
    num2 = temp;
}
if (num2 > num3)
{
    int temp = num2;
    num2 = num3;
    num3 = temp;
}
if (num1 > num2)
{
    int temp = num1;
    num1 = num2;
    num2 = temp;
}

Console.WriteLine($"Os números em ordem ascendente são: {num1}, {num2}, {num3}");