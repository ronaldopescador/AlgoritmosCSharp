Console.WriteLine("Digite a distância percorrida (em Km): ");
double distancia = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o tempo de viagem (em horas): ");
double tempo = Convert.ToDouble(Console.ReadLine());

double velocidadeMedia = distancia / tempo;

if (velocidadeMedia > 110)
{
    Console.WriteLine("Velocidade média {0:F2} Km/h, superior ao limite de 110 Km/h.", velocidadeMedia);
}
else
{
    Console.WriteLine("Velocidade média {0:F2} Km/h, dentro do limite de 110 Km/h.", velocidadeMedia);
}