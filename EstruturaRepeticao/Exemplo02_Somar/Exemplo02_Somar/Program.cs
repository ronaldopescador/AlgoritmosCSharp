//Solicitar e somar uma quantidade de valores
Console.WriteLine("Quantidade de valores a serem somados:");
int quantidade = Convert.ToInt32(Console.ReadLine());
int contador = 1;
double soma = 0;
while (contador <= quantidade)
{
    Console.WriteLine($"Digite o valor {contador}:");
    double valor = Convert.ToDouble(Console.ReadLine());
    soma += valor;
    contador++;
}
Console.WriteLine($"A soma dos valores é: {soma}");
