// Ler a quantidade de cavalos comprados
Console.Write("Digite a quantidade de cavalos comprados: ");
int quantidadeCavalos = Convert.ToInt32(Console.ReadLine());

// Calcular a quantidade de ferraduras
int quantidadeFerraduras = quantidadeCavalos * 4;

// Exibir a quantidade de ferraduras
Console.WriteLine($"São necessárias {quantidadeFerraduras} ferraduras para equipar todos os cavalos.");
