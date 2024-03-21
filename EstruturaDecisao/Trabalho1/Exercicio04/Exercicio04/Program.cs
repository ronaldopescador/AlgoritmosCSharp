Console.WriteLine("Digite seu peso em kg: ");
double peso = double.Parse(Console.ReadLine());

Console.WriteLine("Digite sua altura em metros: ");
double altura = double.Parse(Console.ReadLine());

double imc = peso / Math.Pow(altura, 2);

Console.WriteLine("Seu IMC é: {0:F2}", imc);

if (imc < 18.5)
{
    Console.WriteLine("Abaixo do peso");
}
else if (imc < 25)
{
    Console.WriteLine("Peso normal");
}
else if (imc < 30)
{
    Console.WriteLine("Sobrepeso");
}
else if (imc < 35)
{
    Console.WriteLine("Obeso leve");
}
else if (imc < 40)
{
    Console.WriteLine("Obeso moderado");
}
else
{
    Console.WriteLine("Obeso mórbido");
}