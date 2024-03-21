Console.WriteLine("Digite um número inteiro: ");
int numero = Convert.ToInt32(Console.ReadLine());

if (numero > 0)
{
    Console.WriteLine("O número {0} é positivo.", numero);
}
else if (numero < 0)
{
    Console.WriteLine("O número {0} é negativo.", numero);
}
else
{
    Console.WriteLine("O número {0} é zero.", numero);
}