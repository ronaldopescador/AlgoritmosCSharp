Console.Write("Digite o número do dia da semana:");
int diaDaSemana = Convert.ToInt32(Console.ReadLine());
switch (diaDaSemana)
{
    case 1:
        Console.WriteLine("Segunda-feira");
        break;
    case 2:
        Console.WriteLine("Terça-feira");
        break;
    case 3:
        Console.WriteLine("Quarta-feira");
        break;
    // ...
    default:
        Console.WriteLine("Dia inválido");
        break;
}

