// Leitura do número de horas normais trabalhadas
Console.Write("Digite o número de horas normais trabalhadas: ");
int horasNormais = int.Parse(Console.ReadLine());

// Leitura do número de horas extras trabalhadas
Console.Write("Digite o número de horas extras trabalhadas: ");
int horasExtras = int.Parse(Console.ReadLine());

// Cálculo do salário bruto
double salarioBruto = horasNormais * 10 + horasExtras * 15;

// Cálculo do desconto de impostos
double descontoImpostos = salarioBruto * 0.1;

// Cálculo do salário líquido
double salarioLiquido = salarioBruto - descontoImpostos;

// Exibição do salário bruto e líquido
Console.WriteLine($"Salário bruto: {salarioBruto:F2}.");
Console.WriteLine($"Desconto de impostos: {descontoImpostos:F2}.");
Console.WriteLine($"Salário líquido: {salarioLiquido:F2}.");
