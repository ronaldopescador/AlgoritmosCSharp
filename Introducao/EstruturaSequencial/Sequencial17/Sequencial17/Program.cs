// Leitura da temperatura em Celsius
Console.Write("Digite a temperatura em Celsius: ");
double temperaturaCelsius = double.Parse(Console.ReadLine());

// Conversão de Celsius para Fahrenheit
double temperaturaFahrenheit = (temperaturaCelsius * 9 / 5) + 32;

// Exibição da temperatura em Fahrenheit
Console.WriteLine($"Temperatura em Fahrenheit: {temperaturaFahrenheit:F2}°F.");
