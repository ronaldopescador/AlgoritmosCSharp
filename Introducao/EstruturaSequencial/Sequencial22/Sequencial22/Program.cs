// Leitura da quantidade de cada tipo de moeda
Console.Write("Digite a quantidade de moedas de 1 centavo: ");
int quantidadeMoedas1Centavo = int.Parse(Console.ReadLine());

Console.Write("Digite a quantidade de moedas de 5 centavos: ");
int quantidadeMoedas5Centavos = int.Parse(Console.ReadLine());

Console.Write("Digite a quantidade de moedas de 10 centavos: ");
int quantidadeMoedas10Centavos = int.Parse(Console.ReadLine());

Console.Write("Digite a quantidade de moedas de 25 centavos: ");
int quantidadeMoedas25Centavos = int.Parse(Console.ReadLine());

Console.Write("Digite a quantidade de moedas de 50 centavos: ");
int quantidadeMoedas50Centavos = int.Parse(Console.ReadLine());

Console.Write("Digite a quantidade de moedas de 1 real: ");
int quantidadeMoedas1Real = int.Parse(Console.ReadLine());

// Cálculo do valor total economizado
double valorTotal = (quantidadeMoedas1Centavo * 0.01) + (quantidadeMoedas5Centavos * 0.05) +
    (quantidadeMoedas10Centavos * 0.1) + (quantidadeMoedas25Centavos * 0.25) +
    (quantidadeMoedas50Centavos * 0.5) + (quantidadeMoedas1Real * 1);

// Exibição do valor total economizado
Console.WriteLine($"Valor total economizado: {valorTotal:F2}.");