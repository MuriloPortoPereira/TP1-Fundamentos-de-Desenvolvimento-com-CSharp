int opcao;

do
{
    Console.WriteLine("\n... EstaCentro ...");
    Console.WriteLine("1. Calcular taxa");
    Console.WriteLine("2. Converter horas e minutos");
    Console.WriteLine("3. Classificar permanencia");
    Console.WriteLine("4. Sair");
    Console.Write("\nEscolha uma opcao: ");

    // (Negativa.TenteConverter(InputDoUsuario(), Saida OPCAO seleciona))
    if (!int.TryParse(Console.ReadLine(), out opcao))
    {
        Console.WriteLine("Opcao invalida!");
        continue;
    }

    switch (opcao)
    {
        case 1:
            int minutosTarifa = LerMinutos();
            double valor = CalcularTarifa(minutosTarifa, 3.50);

            Console.WriteLine($"Valor: R$ {valor:F2}");

            if (valor > 84.00)
                Console.WriteLine("Maior que o teto diario.");
            else if (valor < 84.00)
                Console.WriteLine("Menor que o teto diario.");
            else
                Console.WriteLine("Igual ao teto diario.");
            break;

        case 2:
            int minutosDuracao = LerMinutos();
            MostrarDuracao(minutosDuracao);
            break;

        case 3:
            int minutosClassificacao = LerMinutos();
            Console.WriteLine(Classificar(minutosClassificacao));
            break;

        case 4:
            Console.WriteLine("Encerrando...");
            break;

        default:
            Console.WriteLine("Opcao invalida!");
            break;
    }

} while (opcao != 4);


int LerMinutos()
{
    while (true)
    {
        Console.Write("Digite os minutos: ");

        if (int.TryParse(Console.ReadLine(), out int minutos)
            && minutos >= 0)
        {
            return minutos;
        }

        Console.WriteLine("Digite um numero valido!");
    }
}

void MostrarDuracao(int minutos)
{
    int horas = minutos / 60;
    int restantes = minutos % 60;

    Console.WriteLine($"{horas}h {restantes}min");
}

double CalcularTarifa(int minutos, double valorHora)
{
    int horas = minutos / 60;
    int restantes = minutos % 60;

    if (restantes > 0)
    {
        horas++;
    }

    return horas * valorHora;
}

string Classificar(int minutos)
{
    if (minutos <= 60)
    {
        return "Rotativa curta";
    }
    else if (minutos <= 240)
    {
        return "Rotativa padrao";
    }
    else
    {
        return "Diaria";
    }
}