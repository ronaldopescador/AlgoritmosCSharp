// Ler a quantidade de dias
Console.Write("Digite a quantidade de dias: ");
int diasTotais = Convert.ToInt32(Console.ReadLine());

// Calcular anos
int anos = diasTotais / 360;

// Calcular dias restantes após os anos
int diasRestantes = diasTotais % 360;

// Calcular meses
int meses = diasRestantes / 30;

// Calcular dias restantes após os meses
int dias = diasRestantes % 30;

// Exibir o resultado
Console.WriteLine($"{diasTotais} dias equivalem a:");
Console.WriteLine($"{anos} ano(s)");
Console.WriteLine($"{meses} mês(es)");
Console.WriteLine($"{dias} dia(s)");