double tempoViagem = 6;
double velocidadeMedia = 80;
double distancia = tempoViagem * velocidadeMedia;
double litrosConsumidos = distancia / 12;
Console.WriteLine("Distância percorrida: {0:F2} km", distancia);
Console.WriteLine("Litros de combustível consumidos: {0:F2} litros", litrosConsumidos);