// Leitura do tempo de empresa
Console.WriteLine("Digite o tempo de empresa do funcionário (em anos):");
int anosEmpresa = int.Parse(Console.ReadLine());

// Leitura dos projetos de grande porte
Console.WriteLine("Digite a quantidade de projetos de grande porte:");
int quantidadeProjetosGrandePorte = int.Parse(Console.ReadLine());

// Leitura dos projetos de médio porte
Console.WriteLine("Digite a quantidade de projetos de médio porte:");
int quantidadeProjetosMedioPorte = int.Parse(Console.ReadLine());

// Leitura dos projetos de pequeno porte
Console.WriteLine("Digite a quantidade de projetos de pequeno porte:");
int quantidadeProjetosPequenoPorte = int.Parse(Console.ReadLine());

// Cálculo da pontuação total
int pontosTotal = (anosEmpresa * 2) + (quantidadeProjetosGrandePorte * 10) + 
    (quantidadeProjetosMedioPorte * 5) + (quantidadeProjetosPequenoPorte * 2);

// Exibição da pontuação total
Console.WriteLine("A pontuação total do funcionário é: " + pontosTotal);
