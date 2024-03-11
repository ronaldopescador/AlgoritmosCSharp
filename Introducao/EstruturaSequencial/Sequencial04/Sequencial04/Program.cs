// Leitura do nome da pessoa
Console.Write("Digite o nome da pessoa: ");
string nome = Console.ReadLine();

// Leitura da idade da pessoa
Console.Write("Digite a idade da pessoa: ");
int idade = Convert.ToInt32(Console.ReadLine());

// Cálculo dos dias de vida
int diasVida = idade * 365;

// Exibição do nome, idade e dias de vida da pessoa
Console.WriteLine($"{nome} tem {idade} anos e {diasVida} dias de vida.");
