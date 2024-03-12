Console.Write("Digite um valor: ");
double valor = double.Parse(Console.ReadLine());
double fator;
if (valor >= 100)
{
    fator = 0.1; 
}
else
{
    fator = 0.05; 
}
double resultado = valor - valor * fator;
Console.WriteLine($"O resultado é: " + resultado);

