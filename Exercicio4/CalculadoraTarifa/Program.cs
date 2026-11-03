int totalMinutos = 87;
double valorHora = 3.50;
double tetoDiario = 84.00;

int horas = totalMinutos / 60;
int minutosRestantes = totalMinutos % 60;

Console.WriteLine($"Tempo estacionado: {horas}h {minutosRestantes}min");

int horasCobradas = horas;

if (minutosRestantes > 0)
{
    horasCobradas++;
}

double valorTotal = horasCobradas * valorHora;

Console.WriteLine($"Horas cobradas: {horasCobradas}");
Console.WriteLine($"Valor calculado: R$ {valorTotal:F2}");

if (valorTotal > tetoDiario)
{
    Console.WriteLine("O valor é maior que o teto diario.");
}
else if (valorTotal < tetoDiario)
{
    Console.WriteLine("O valor é menor que o teto diario.");
}
else
{
    Console.WriteLine("O valor é igual ao teto diario.");
}

Console.WriteLine("\nPressione qualquer tecla para sair...");
Console.ReadKey();