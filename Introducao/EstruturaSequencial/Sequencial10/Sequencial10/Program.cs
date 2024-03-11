// Leitura do coordenado x do primeiro ponto
Console.Write("Digite o coordenado x do primeiro ponto: ");
double x1 = Convert.ToDouble(Console.ReadLine());

// Leitura do coordenado y do primeiro ponto
Console.Write("Digite o coordenado y do primeiro ponto: ");
double y1 = Convert.ToDouble(Console.ReadLine());

// Leitura do coordenado x do segundo ponto
Console.Write("Digite o coordenado x do segundo ponto: ");
double x2 = Convert.ToDouble(Console.ReadLine());

// Leitura do coordenado y do segundo ponto
Console.Write("Digite o coordenado y do segundo ponto: ");
double y2 = Convert.ToDouble(Console.ReadLine());

// Cálculo da diferença entre os coordenados x
double diferencaX = x2 - x1;

// Cálculo da diferença entre os coordenados y
double diferencaY = y2 - y1;

// Cálculo da distância entre os pontos
double distancia = Math.Sqrt(Math.Pow(diferencaX, 2) + Math.Pow(diferencaY, 2));

// Exibição da distância entre os pontos
Console.WriteLine($"A distância entre os pontos é de {distancia:F2}.");