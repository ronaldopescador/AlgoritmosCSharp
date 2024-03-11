// Leitura da quantidade de litros de refresco
Console.Write("Digite a quantidade de litros de refresco: ");
double litrosRefresco = double.Parse(Console.ReadLine());

// Cálculo da quantidade de água
double litrosAgua = litrosRefresco * (8.0 / 10.0);

// Cálculo da quantidade de suco de maracujá
double litrosSucoMaracuja = litrosRefresco * (2.0 / 10.0);

// Exibição da quantidade de água e suco de maracujá
Console.WriteLine($"Quantidade de água: {litrosAgua:F2} litros.");
Console.WriteLine($"Quantidade de suco de maracujá: {litrosSucoMaracuja:F2} litros.");