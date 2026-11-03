Console.WriteLine("... EstaCentro ...");
Console.Write("Digite o total de minutos estacionado: ");

string? entrada = Console.ReadLine();

if (int.TryParse(entrada, out int totalMinutos))
{
    if (totalMinutos < 0)
    {
        Console.WriteLine("Erro: O tempo nao pode ser negativo.");
    }
    else if (totalMinutos <= 60)
    {
        Console.WriteLine("Classificacao: Rotativa curta");
    }
    else if (totalMinutos <= 240)
    {
        Console.WriteLine("Classificacao: Rotativa padrao");
    }
    else
    {
        Console.WriteLine("Classificacao: Diaria");
    }
}
else
{
    Console.WriteLine("Erro: Digite um numero inteiro valido.");
}

Console.WriteLine("\nPressione qualquer tecla para sair...");
Console.ReadKey();