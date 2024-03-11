// Leitura da quantidade de camisetas pequenas
Console.Write("Digite a quantidade de camisetas pequenas: ");
int quantidadePequena = Convert.ToInt32(Console.ReadLine());

// Leitura da quantidade de camisetas médias
Console.Write("Digite a quantidade de camisetas médias: ");
int quantidadeMedia = Convert.ToInt32(Console.ReadLine());

// Leitura da quantidade de camisetas grandes
Console.Write("Digite a quantidade de camisetas grandes: ");
int quantidadeGrande = Convert.ToInt32(Console.ReadLine());

// Cálculo do valor total da venda
double valorTotal = quantidadePequena * 10 + quantidadeMedia * 12 + quantidadeGrande * 15;

// Exibição do valor total da venda
Console.WriteLine($"O valor total da venda é {valorTotal:F2}.");