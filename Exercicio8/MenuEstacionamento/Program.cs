// MenuEstacionamento - EstaCentro
// Usei switch para separar as opcoes e do-while para repetir o menu.
// Criei metodos para reutilizar os calculos e a classificacao.
// Usei while para registrar os veiculos e -1 para encerrar a contagem.
int opcao;
int rotativaCurta = 0;
int rotativaPadrao = 0;
int diaria = 0;

do
{
    Console.WriteLine("\n... EstaCentro ...");
    Console.WriteLine("1. Calcular taxa");
    Console.WriteLine("2. Converter horas e minutos");
    Console.WriteLine("3. Classificar permanencia");
    Console.WriteLine("4. Sobre");
    Console.WriteLine("5. Sair");
    Console.Write("\nEscolha uma opcao: ");

    if (!int.TryParse(Console.ReadLine(), out opcao))
    {
        Console.WriteLine("Opcao invalida!");
        continue;
    }

    switch (opcao)
    {
        case 1:
            {
                int minutosTarifa = LerMinutos();
                double valor = CalcularTarifa(minutosTarifa, 3.50);

                Console.WriteLine($"Valor: R$ {valor:F2}");

                if (valor > 84.00)
                {
                    Console.WriteLine("Maior que o teto diario.");
                }
                else if (valor < 84.00)
                {
                    Console.WriteLine("Menor que o teto diario.");
                }
                else
                {
                    Console.WriteLine("Igual ao teto diario.");
                }

                break;
            }

        case 2:
            {
                int minutosDuracao = LerMinutos();
                MostrarDuracao(minutosDuracao);
                break;
            }

        case 3:
            {
                while (true)
                {
                    Console.Write("\nDigite os minutos (-1 para voltar): ");

                    if (!int.TryParse(Console.ReadLine(), out int minutos))
                    {
                        Console.WriteLine("Numero invalido!");
                        continue;
                    }

                    if (minutos == -1)
                    {
                        break;
                    }

                    if (minutos < 0)
                    {
                        Console.WriteLine("Tempo invalido!");
                        continue;
                    }

                    string categoria = Classificar(minutos);
                    Console.WriteLine($"Classificacao: {categoria}");

                    if (categoria == "Rotativa curta")
                    {
                        rotativaCurta++;
                    }
                    else if (categoria == "Rotativa padrao")
                    {
                        rotativaPadrao++;
                    }
                    else
                    {
                        diaria++;
                    }
                }

                Console.WriteLine("\n... Relatorio Turno ...");
                Console.WriteLine($"Rotativa curta: {rotativaCurta}");
                Console.WriteLine($"Rotativa padrao: {rotativaPadrao}");
                Console.WriteLine($"Diaria: {diaria}");

                break;
            }

        case 4:
            {
                Console.WriteLine("\n... Dados de Ambiente ...");
                Console.WriteLine($"Versao do .NET: {Environment.Version}");
                Console.WriteLine($"Sistema operacional: {Environment.OSVersion}");
                Console.WriteLine($"Diretorio atual: {Environment.CurrentDirectory}");
                Console.WriteLine("O mesmo codigo funciona no Windows e Linux porque o .NET possui um ambiente de execucao para cada sistema.");
                break;
            }

        case 5:
            {
                Console.WriteLine("Encerrando...");
                break;
            }

        default:
            {
                Console.WriteLine("Opcao invalida!");
                break;
            }
    }

} while (opcao != 5);

int LerMinutos()
{
    while (true)
    {
        Console.Write("Digite os minutos: ");

        if (int.TryParse(Console.ReadLine(), out int minutos) && minutos >= 0)
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
