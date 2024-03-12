Console.Write("Digite o primeiro número: ");
double num1 = double.Parse(Console.ReadLine());

Console.Write("Digite o segundo número: ");
double num2 = double.Parse(Console.ReadLine());

Console.Write("Digite o terceiro número: ");
double num3 = double.Parse(Console.ReadLine());

double resultado = num1 + num2 * num3 - num2;

Console.WriteLine($"O resultado é: {resultado}");

