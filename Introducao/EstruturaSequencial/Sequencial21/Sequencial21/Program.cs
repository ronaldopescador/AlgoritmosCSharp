// Leitura da quantidade de latas de 350 ml
Console.Write("Digite a quantidade de latas de 350 ml: ");
int quantidadeLata350 = int.Parse(Console.ReadLine());

// Leitura da quantidade de garrafas de 600 ml
Console.Write("Digite a quantidade de garrafas de 600 ml: ");
int quantidadeGarrafa600 = int.Parse(Console.ReadLine());

// Leitura da quantidade de garrafas de 2 litros
Console.Write("Digite a quantidade de garrafas de 2 litros: ");
int quantidadePet2 = int.Parse(Console.ReadLine());

// Cálculo da quantidade total de refrigerante em litros
double quantidadeLitros = (quantidadeLata350 * 0.35) + (quantidadeGarrafa600 * 0.6) + (quantidadePet2 * 2);

// Exibição da quantidade total de refrigerante em litros
Console.WriteLine($"Quantidade total de refrigerante em litros: {quantidadeLitros:F2}.");
