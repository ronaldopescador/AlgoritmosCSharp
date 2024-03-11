// Leitura do número de blusas
Console.Write("Digite o número de blusas: ");
int numeroBlusas = int.Parse(Console.ReadLine());

// Leitura da quantidade de novelos de lã utilizados
Console.Write("Digite a quantidade de novelos de lã utilizados: ");
int quantidadeNovelos = int.Parse(Console.ReadLine());

// Cálculo da quantidade de novelos por blusa
double novelosPorBlusa = (double)quantidadeNovelos / numeroBlusas;

// Exibição da quantidade de novelos por blusa
Console.WriteLine($"Novelos por blusa: {novelosPorBlusa:F2}.");