Console.WriteLine("**Calculadora Simples**");
Console.WriteLine("1. Soma");
Console.WriteLine("2. Subtração");
Console.WriteLine("3. Multiplicação");
Console.WriteLine("4. Divisão");
Console.WriteLine("Digite a opção desejada: ");
int opcao = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o primeiro número: ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o segundo número: ");
double num2 = Convert.ToDouble(Console.ReadLine());

double resultado;

switch (opcao)
{
    case 1:
        resultado = num1 + num2;
        Console.WriteLine("Resultado da soma: {0}", resultado);
        break;
    case 2:
        resultado = num1 - num2;
        Console.WriteLine("Resultado da subtração: {0}", resultado);
        break;
    case 3:
        resultado = num1 * num2;
        Console.WriteLine("Resultado da multiplicação: {0}", resultado);
        break;
    case 4:
        if (num2 == 0)
        {
            Console.WriteLine("Divisão por zero! Tente novamente.");
        }
        else
        {
            resultado = num1 / num2;
            Console.WriteLine("Resultado da divisão: {0}", resultado);
        }
        break;
    default:
        Console.WriteLine("Opção inválida! Tente novamente.");
        break;
}