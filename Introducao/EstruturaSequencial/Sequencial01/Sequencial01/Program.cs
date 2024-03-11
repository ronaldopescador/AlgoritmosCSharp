// Ler a largura do terreno     
Console.Write("Digite a largura do terreno: ");
double largura = Convert.ToDouble(Console.ReadLine());

// Ler o comprimento do terreno do usuário
Console.Write("Digite o comprimento do terreno: ");
double comprimento = Convert.ToDouble(Console.ReadLine());

// Calcular a área do terreno
double areaTerreno = largura * comprimento;

// Exibir a área do terreno
Console.WriteLine($"A área do terreno é de {areaTerreno:F2} m².");