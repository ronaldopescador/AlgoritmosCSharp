// Leitura do raio da base da caixa d'água
Console.Write("Digite o raio da base da caixa d'água (em metros): ");
double raioBase = double.Parse(Console.ReadLine());

// Leitura da altura da caixa d'água
Console.Write("Digite a altura da caixa d'água (em metros): ");
double altura = double.Parse(Console.ReadLine());

// Cálculo do volume da caixa d'água
double volume = 3.14 * Math.Pow(raioBase, 2) * altura;

// Exibição do volume da caixa d'água
Console.WriteLine($"Volume da caixa d'água: {volume:F2} metros cúbicos.");