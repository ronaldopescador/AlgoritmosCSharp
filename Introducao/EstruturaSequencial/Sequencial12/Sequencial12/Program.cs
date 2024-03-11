// Leitura do salário do funcionário
Console.Write("Digite o salário do funcionário: ");
double salarioInicial = Convert.ToDouble(Console.ReadLine());

// Cálculo do valor do aumento
double aumento = salarioInicial * 15 / 100;

// Cálculo do salário com o aumento, reaujustado
double salarioReajustado = salarioInicial + aumento;

// Cálculo do valor do imposto
double imposto = salarioReajustado * 8 / 100;

// Cálculo do salário final
double salarioFinal = salarioReajustado - imposto;

// Exibição do salário inicial
Console.WriteLine($"Salário inicial: {salarioInicial:F2}.");

// Exibição do salário com aumento
Console.WriteLine($"Salário com aumento: {salarioReajustado:F2}.");

// Exibição do salário final
Console.WriteLine($"Salário final: {salarioFinal:F2}.");