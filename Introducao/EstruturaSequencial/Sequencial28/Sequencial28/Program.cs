// Leitura do valor do cheque
Console.Write("Digite o valor do cheque: ");
double valorCheque = double.Parse(Console.ReadLine());

// Cálculo do valor do CPMF
double valorCPMF = valorCheque * 0.0038;

// Exibição do valor do CPMF
Console.WriteLine($"Valor do CPMF: {valorCPMF:F2}.");