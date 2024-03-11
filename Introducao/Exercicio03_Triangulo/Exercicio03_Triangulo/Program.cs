// Cálculo da área de um triângulo

// Obtendo a base do triângulo do usuário
Console.WriteLine("Digite a base do triângulo:");
double baseTriangulo = Convert.ToDouble(Console.ReadLine());

// Obtendo a altura do triângulo do usuário
Console.WriteLine("Digite a altura do triângulo:");
double alturaTriangulo = Convert.ToDouble(Console.ReadLine());

// Calculando a área do triângulo
double areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;

// Exibindo a área do triângulo
Console.WriteLine("A área do triângulo é: {0:F2}", areaTriangulo);