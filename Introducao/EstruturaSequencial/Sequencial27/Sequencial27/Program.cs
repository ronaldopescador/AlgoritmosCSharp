// Leitura do valor das compras
Console.Write("Digite o valor da primeira compra: ");
double valorPrimeiraCompra = double.Parse(Console.ReadLine());

Console.Write("Digite o valor da segunda compra: ");
double valorSegundaCompra = double.Parse(Console.ReadLine());

Console.Write("Digite o valor da terceira compra: ");
double valorTerceiraCompra = double.Parse(Console.ReadLine());

Console.Write("Digite o valor da quarta compra: ");
double valorQuartaCompra = double.Parse(Console.ReadLine());

// Cálculo do total de pontos
double totalPontos = (valorPrimeiraCompra + valorSegundaCompra + valorTerceiraCompra + valorQuartaCompra) / 5.0;

// Exibição do total de pontos
Console.WriteLine($"Total de pontos acumulados: {totalPontos:F2} pontos.");