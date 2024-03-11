// Conversão de moedas 

// Obtendo o valor a ser convertido do usuário
Console.WriteLine("Digite o valor a ser convertido:");
double valorConverter = Convert.ToDouble(Console.ReadLine());

// Obtendo a moeda de origem do usuário
Console.WriteLine("Digite a moeda de origem:");
string moedaOrigem = Console.ReadLine();

// Obtendo a moeda de destino do usuário
Console.WriteLine("Digite a moeda de destino:");
string moedaDestino = Console.ReadLine();

// Obtendo a taxa de câmbio do usuário
Console.WriteLine("Digite a taxa de câmbio:");
double taxaCambio = Convert.ToDouble(Console.ReadLine());

// Calculando o valor convertido
double valorConvertido = valorConverter * taxaCambio;

// Exibindo o valor convertido
Console.WriteLine("O valor convertido em {0} é: {1:F2}", moedaDestino, valorConvertido);
