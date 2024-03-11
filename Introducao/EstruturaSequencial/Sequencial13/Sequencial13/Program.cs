// Leitura do número inteiro
Console.Write("Digite um número inteiro (até três dígitos): ");
int numero = Convert.ToInt32(Console.ReadLine());

// Extração da centena
int centena = numero / 100;

// Extração da dezena
int dezena = (numero % 100) / 10;

// Extração da unidade
int unidade = numero % 10;

// Exibição da centena, dezena e unidade
Console.WriteLine($"Centena: {centena}");
Console.WriteLine($"Dezena: {dezena}");
Console.WriteLine($"Unidade: {unidade}");