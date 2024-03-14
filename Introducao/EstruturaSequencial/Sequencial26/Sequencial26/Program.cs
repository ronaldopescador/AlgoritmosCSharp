// Leitura do nome e dos pontos dos três primeiros colocados
Console.Write("Digite o nome do primeiro colocado: ");
string nomePrimeiroColocado = Console.ReadLine();

Console.Write("Digite a pontuação do primeiro colocado: ");
int pontuacaoPrimeiroColocado = int.Parse(Console.ReadLine());

Console.Write("Digite o nome do segundo colocado: ");
string nomeSegundoColocado = Console.ReadLine();

Console.Write("Digite a pontuação do segundo colocado: ");
int pontuacaoSegundoColocado = int.Parse(Console.ReadLine());

Console.Write("Digite o nome do terceiro colocado: ");
string nomeTerceiroColocado = Console.ReadLine();

Console.Write("Digite a pontuação do terceiro colocado: ");
int pontuacaoTerceiroColocado = int.Parse(Console.ReadLine());

// Cálculo da pontuação total
int pontuacaoTotal = pontuacaoPrimeiroColocado + pontuacaoSegundoColocado + pontuacaoTerceiroColocado;

// Cálculo da porcentagem do prêmio para cada colocado
double porcentagemPrimeiroColocado = (double)pontuacaoPrimeiroColocado / pontuacaoTotal;
double porcentagemSegundoColocado = (double)pontuacaoSegundoColocado / pontuacaoTotal;
double porcentagemTerceiroColocado = (double)pontuacaoTerceiroColocado / pontuacaoTotal;

// Cálculo do valor do prêmio para cada colocado
double valorPremioPrimeiroColocado = 500000 * porcentagemPrimeiroColocado;
double valorPremioSegundoColocado = 500000 * porcentagemSegundoColocado;
double valorPremioTerceiroColocado = 500000 * porcentagemTerceiroColocado;

// Exibição do valor do prêmio para cada colocado
Console.WriteLine($"{nomePrimeiroColocado}: {valorPremioPrimeiroColocado:F2}.");
Console.WriteLine($"{nomeSegundoColocado}: {valorPremioSegundoColocado:F2}.");
Console.WriteLine($"{nomeTerceiroColocado}: {valorPremioTerceiroColocado:F2}.");