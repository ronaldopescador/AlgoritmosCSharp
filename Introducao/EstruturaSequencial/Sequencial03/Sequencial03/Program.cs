// Leitura da quantidade de pães franceses
Console.Write("Digite a quantidade de pães franceses vendidos: ");
int quantidadePao = Convert.ToInt32(Console.ReadLine());

// Leitura da quantidade de broas vendidas
Console.Write("Digite a quantidade de broas vendidas: ");
int quantidadeBroa = Convert.ToInt32(Console.ReadLine());

// Cálculo do valor total das vendas de pães
double totalPao = quantidadePao * 0.60;

// Cálculo do valor total das vendas de broas
double totalBroa = quantidadeBroa * 6.50;

// Cálculo do valor total das vendas
double valorTotalVendas = totalPao + totalBroa;

// Cálculo do valor a ser guardado na poupança (10% do total)
double valorPoupanca = valorTotalVendas * 0.10;

// Exibição do valor total das vendas
Console.WriteLine($"Valor total das vendas: R${valorTotalVendas:F2}");

// Exibição do valor a ser guardado na poupança
Console.WriteLine($"Valor a ser guardado na poupança: R${valorPoupanca:F2}");
