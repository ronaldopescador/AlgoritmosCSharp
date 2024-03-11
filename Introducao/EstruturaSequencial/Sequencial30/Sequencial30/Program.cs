// Leitura do tempo de empresa
Console.WriteLine("Digite o tempo de empresa do funcionário (em anos):");
int anosEmpresa = int.Parse(Console.ReadLine());

// Leitura dos projetos de grande porte
Console.WriteLine("Digite a quantidade de projetos de grande porte:");
int quantidadeProjetosGrande = int.Parse(Console.ReadLine());

// Leitura dos projetos de médio porte
Console.WriteLine("Digite a quantidade de projetos de médio porte:");
int quantidadeProjetosMedio = int.Parse(Console.ReadLine());

// Leitura dos projetos de pequeno porte
Console.WriteLine("Digite a quantidade de projetos de pequeno porte:");
int quantidadeProjetosPequeno = int.Parse(Console.ReadLine());

// Cálculo da pontuação total
int pontosTotal = (anosEmpresa * 2) + (quantidadeProjetosGrande * 10) + 
    (quantidadeProjetosMedio * 5) + (quantidadeProjetosPequeno * 2);

// Exibição da pontuação total
Console.WriteLine("A pontuação total do funcionário é: " + pontosTotal);
