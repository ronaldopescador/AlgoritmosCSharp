// Leitura do dia
Console.Write("Digite o dia: ");
int dia = Convert.ToInt32(Console.ReadLine());

// Leitura do mês
Console.Write("Digite o mês: ");
int mes = Convert.ToInt32(Console.ReadLine());

// Cálculo do número de dias passados
int diasPassados = (mes - 1) * 30 + dia;

// Exibição do número de dias passados
Console.WriteLine($"Se passaram {diasPassados} dias desde o início do ano.");
