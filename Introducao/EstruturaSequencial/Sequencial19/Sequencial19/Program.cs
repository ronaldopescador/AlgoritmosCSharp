// Leitura do número de frangos
Console.Write("Digite o número de frangos: ");
int numeroFrangos = int.Parse(Console.ReadLine());

// Cálculo do custo total dos anéis com chip
double custoAnelIdentificacao = numeroFrangos * 4.0;

// Cálculo do custo total dos anéis de alimento
double custoAnelAlimento = numeroFrangos * 2 * 3.5;

// Cálculo do custo total
double custoTotal = custoAnelIdentificacao + custoAnelAlimento;

// Exibição do custo total
Console.WriteLine($"Custo total: R${custoTotal:F2}.");
