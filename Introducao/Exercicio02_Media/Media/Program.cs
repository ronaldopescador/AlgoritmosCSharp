// Cálculo de média 

// Obtendo a primeira nota do usuário
Console.WriteLine("Digite a primeira nota:");
double nota1 = Convert.ToDouble(Console.ReadLine());

// Obtendo a segunda nota do usuário
Console.WriteLine("Digite a segunda nota:");
double nota2 = Convert.ToDouble(Console.ReadLine());

// Calculando a média
double media = (nota1 + nota2) / 2;

// Exibindo a média
Console.WriteLine("A média é: {0:F2}", media);