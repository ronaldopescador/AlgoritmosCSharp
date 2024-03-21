Console.WriteLine("Digite o salário atual do funcionário: ");
double salarioAntigo = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o código do cargo do funcionário: ");
int codigoCargo = int.Parse(Console.ReadLine());

double aumento;

switch (codigoCargo)
{
    case 91:
        aumento = salarioAntigo * 0.1;
        break;
    case 92:
        aumento = salarioAntigo * 0.2;
        break;
    case 93:
        aumento = salarioAntigo * 0.3;
        break;
    default:
        aumento = salarioAntigo * 0.355;
        break;
}
double novoSalario = salarioAntigo + aumento;

Console.WriteLine("Salário antigo: {0:F2}", salarioAntigo);
Console.WriteLine("Aumento: {0:F2}", aumento);
Console.WriteLine("Novo salário: {0:F2}", novoSalario);