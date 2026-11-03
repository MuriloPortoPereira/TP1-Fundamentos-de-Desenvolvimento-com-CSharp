using System;

Console.WriteLine($"Sistema operacional: {Environment.OSVersion}");
Console.WriteLine($"Versão do .NET: {Environment.Version}");
Console.WriteLine($"Diretório atual: {Environment.CurrentDirectory}");

Console.WriteLine("\nPressione qualquer tecla para sair...");
Console.ReadKey(true);
