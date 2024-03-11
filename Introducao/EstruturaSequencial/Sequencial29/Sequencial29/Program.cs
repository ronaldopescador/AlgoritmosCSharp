// Declarando as variáveis
double a, b, x;

// Leitura dos coeficientes a e b
Console.WriteLine("Digite o valor de a: ");
a = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor de b: ");
b = double.Parse(Console.ReadLine());

// Cálculo da coordenada x
x = -b / a;

// Exibição das coordenadas
Console.WriteLine("O ponto toca o eixo x na coordenada (" + x + ", 0).");