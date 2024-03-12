Console.Write("Digite o primeiro número: ");
int numero1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Digite o segundo número: ");
int numero2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Digite o terceiro número: ");
int numero3 = Convert.ToInt32(Console.ReadLine());
if (numero1 == numero2 && numero1 == numero3)
    Console.WriteLine("Todos os números são iguais.");
if ((numero1 == numero2 && numero1 != numero3) ||
    (numero1 == numero3 && numero1 != numero2) ||
    (numero2 == numero3 && numero2 != numero1))
    Console.WriteLine("Dois dos números são iguais.");
if (numero1 != numero2 && numero1 != numero3 &&
    numero2 != numero3)
    Console.WriteLine("Nenhum dos números é igual.");

