// Leitura do raio da pizza
Console.Write("Digite o raio da pizza: ");
double raio = Convert.ToDouble(Console.ReadLine());

// Cálculo da área da pizza
double area = 3.14 * (raio * raio);

// Exibição da área da pizza
Console.WriteLine($"A área da pizza é de {area:F2} cm².");