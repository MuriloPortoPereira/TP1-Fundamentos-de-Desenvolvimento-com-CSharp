Console.WriteLine("... EstaCentro ...");

int rotativaCurta = 0;
int rotativaPadrao = 0;
int diaria = 0;

while (true)
{
    Console.Write("\nDigite em minutos (-1 para sair): ");

    string? entrada = Console.ReadLine();

    if (!int.TryParse(entrada, out int totalMinutos))
    {
        Console.WriteLine("Erro: Digite um numero valido.");
        continue;
    }

    if (totalMinutos == -1)
    {
        break;
    }

    if (totalMinutos < 0)
    {
        Console.WriteLine("Erro: O tempo nao pode ser negativo.");
        continue;
    }

    if (totalMinutos <= 60)
    {
        rotativaCurta++;
        Console.WriteLine("Classificacao: Rotativa curta");
    }
    else if (totalMinutos <= 240)
    {
        rotativaPadrao++;
        Console.WriteLine("Classificacao: Rotativa padrao");
    }
    else
    {
        diaria++;
        Console.WriteLine("Classificacao: Diaria");
    }
}

Console.WriteLine("\nRelatorio de Turno:");
Console.WriteLine($"Rotativa curta: {rotativaCurta}");
Console.WriteLine($"Rotativa padrao: {rotativaPadrao}");
Console.WriteLine($"Diaria: {diaria}");

Console.WriteLine("\nPressione qualquer tecla para sair...");
Console.ReadKey();