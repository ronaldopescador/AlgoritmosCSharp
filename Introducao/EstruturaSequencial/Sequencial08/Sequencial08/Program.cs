// Leitura da primeira nota
Console.Write("Digite a primeira nota: ");
double nota1 = Convert.ToDouble(Console.ReadLine());

// Leitura da segunda nota
Console.Write("Digite a segunda nota: ");
double nota2 = Convert.ToDouble(Console.ReadLine());

// Leitura da terceira nota
Console.Write("Digite a terceira nota: ");
double nota3 = Convert.ToDouble(Console.ReadLine());

// Cálculo da média ponderada
double mediaPonderada = (nota1 * 1 + nota2 * 2 + nota3 * 3) / 6;

// Exibição da média ponderada
Console.WriteLine($"A média ponderada do aluno é {mediaPonderada:F2}.");