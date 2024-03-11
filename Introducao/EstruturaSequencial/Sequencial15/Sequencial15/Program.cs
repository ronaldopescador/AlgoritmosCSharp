// Leitura do valor total da conta
Console.Write("Digite o valor total da conta: ");
double valorTotal = Convert.ToDouble(Console.ReadLine());

// Calcular valor restante que será pago pelo Felipe
double resto = valorTotal % 3;
double valorDivisivel = valorTotal - resto;

// Cálculo do valor a ser pago por Carlos e André
double valorParte = valorDivisivel / 3;

// Cálculo do valor a ser pago por Felipe
double valorFelipe = valorParte + resto;

// Exibição do valor a ser pago por cada amigo
Console.WriteLine($"Carlos: {valorParte:F2}.");
Console.WriteLine($"André: {valorParte:F2}.");
Console.WriteLine($"Felipe: {valorFelipe:F2}.");