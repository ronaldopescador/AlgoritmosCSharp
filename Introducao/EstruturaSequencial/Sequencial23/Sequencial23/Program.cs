// Leitura da altura da sombra da pessoa
Console.Write("Digite a altura da sombra da pessoa: ");
double alturaSombraPessoa = double.Parse(Console.ReadLine());

// Leitura da altura da sombra do prédio
Console.Write("Digite a altura da sombra do prédio: ");
double alturaSombraPredio = double.Parse(Console.ReadLine());

// Leitura da altura da pessoa
Console.Write("Digite altura da pessoa: ");
double pessoaAltura = double.Parse(Console.ReadLine());

// Cálculo da altura do prédio
double alturaPredio = (alturaSombraPredio * pessoaAltura) / alturaSombraPessoa;

// Exibição da altura do prédio
Console.WriteLine($"Altura do prédio: {alturaPredio:F2} metros.");