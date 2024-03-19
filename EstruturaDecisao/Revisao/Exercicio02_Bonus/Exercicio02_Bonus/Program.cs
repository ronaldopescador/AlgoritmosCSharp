Console.Write("Digite o salário do funcionário: ");
double salario = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o tempo de trabalho (em anos): ");
int tempoTrabalho = Convert.ToInt32(Console.ReadLine());

double bonus;

if (salario <= 400)
{
    bonus = salario * 0.15;
}
else if (salario <= 1000)
{
    bonus = salario * 0.12;
}
else
{
    bonus = salario * 0.05;
}

if (tempoTrabalho >= 3)
{
    double bonusExtra = salario * 0.10;
    bonus += bonusExtra;
}

double salarioTotal = salario + bonus;

Console.WriteLine($"Bônus: {bonus:F2}");
Console.WriteLine($"Salário total: {salarioTotal:F2}");
