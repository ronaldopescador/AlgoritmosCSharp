const int QUANTIDADE_NOTAS = 2;
const double MEDIA_APROVADO = 6;

Console.Write("Digite a primeira nota: ");
double nota1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a segunda nota: ");
double nota2 = Convert.ToDouble(Console.ReadLine());

double media = (nota1 + nota2) / QUANTIDADE_NOTAS;
Console.WriteLine("Média {0:F2}: ", media);

if (media >= MEDIA_APROVADO)
    Console.WriteLine("Aluno aprovado!");
else
    Console.WriteLine("Aluno reprovado!");
