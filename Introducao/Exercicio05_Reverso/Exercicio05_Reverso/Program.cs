Console.Write("Digite um número de 4 dígitos: ");
int numero = Convert.ToInt32(Console.ReadLine());

int unidade = numero % 10; // Obtém o último dígito
int dezena = (numero / 10) % 10; // Obtém o terceiro dígito
int centena = (numero / 100) % 10; // Obtém o segundo dígito
int milhar = (numero / 1000) % 10; // Obtém o primeiro dígito

Console.WriteLine($"Número de trás para frente: {unidade}{dezena}{centena}{milhar}");