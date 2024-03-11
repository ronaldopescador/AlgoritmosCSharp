// Leitura do valor do total do abastecimento
Console.Write("Digite o valor total do abastecimento: ");
double valorPagamento = Convert.ToDouble(Console.ReadLine());

// Leitura do preço do litro da gasolina
Console.Write("Digite o preço do litro da gasolina: ");
double precoLitro = Convert.ToDouble(Console.ReadLine());

// Cálculo da quantidade de litros
double quantidadeLitros = valorPagamento / precoLitro;

// Exibição da quantidade de litros
Console.WriteLine($"O motorista conseguiu colocar {quantidadeLitros:F2} litros de gasolina no tanque.");
