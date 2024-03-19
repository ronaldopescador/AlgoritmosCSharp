Console.Write("Digite um ano (d.C.): ");
int ano = Convert.ToInt32(Console.ReadLine());

bool bissexto = (ano % 400 == 0 || (ano % 4 == 0 && ano % 100 != 0));

if (bissexto)
{
    Console.WriteLine($"{ano} é um ano bissexto, com 366 dias.");
}
else
{
    Console.WriteLine($"{ano} é um ano normal, com 365 dias.");
}
