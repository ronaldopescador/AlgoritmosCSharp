Console.Write("Digite o dia de nascimento: ");
int dia = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o mês de nascimento: ");
int mes = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o ano de nascimento: ");
int ano = Convert.ToInt32(Console.ReadLine());

// Calcula o dia da semana usando o algoritmo de Zeller
int a = (14 - mes) / 12;
int y = ano - a;
int m = mes + 12 * a - 2;
int d = (dia + y + y / 4 - y / 100 + y / 400 + (31 * m) / 12) % 7;

string diaSemana;

switch (d)
{
    case 0:
        diaSemana = "Domingo";
        break;
    case 1:
        diaSemana = "Segunda-feira";
        break;
    case 2:
        diaSemana = "Terça-feira";
        break;
    case 3:
        diaSemana = "Quarta-feira";
        break;
    case 4:
        diaSemana = "Quinta-feira";
        break;
    case 5:
        diaSemana = "Sexta-feira";
        break;
    case 6:
        diaSemana = "Sábado";
        break;
    default:
        diaSemana = "Inválido";
        break;
}
Console.WriteLine($"Você nasceu em um(a) {diaSemana}.");
