// Leitura da quantidade de sanduíches
Console.Write("Digite a quantidade de sanduíches a fazer: ");
int quantidadeSanduiches = int.Parse(Console.ReadLine());

// Cálculo da quantidade total de queijo
double quantidadeQueijo = quantidadeSanduiches * 2 * 0.05;

// Cálculo da quantidade total de presunto
double quantidadePresunto = quantidadeSanduiches * 1 * 0.05;

// Cálculo da quantidade total de hambúrguer
double quantidadeHamburguer = quantidadeSanduiches * 1 * 0.1;

// Exibição da quantidade de cada ingrediente
Console.WriteLine($"Quantidade de queijo: {quantidadeQueijo:F2} kg.");
Console.WriteLine($"Quantidade de presunto: {quantidadePresunto:F2} kg.");
Console.WriteLine($"Quantidade de hambúrguer: {quantidadeHamburguer:F2} kg.");