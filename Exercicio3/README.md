# Exercício 3 — Estrutura e ciclo de vida do .NET

## Contexto

Antes de seguir para a lógica de negócio do estacionamento, seu mentor quer confirmar que você entende o que de fato acontece quando um programa C# é compilado e executado, não só que os comandos funcionam. Ele pede que você explore a estrutura de arquivos gerada pelo próprio .NET ao construir o projeto e explique cada peça envolvida.

## Tarefa

1. A partir do projeto AmbienteEstacionamento do Exercício 1, rode dotnet build e liste, no relatório, os arquivos gerados dentro da pasta bin/Debug/net10.0 (o assembly .dll, o .pdb, o .deps.json e o .runtimeconfig.json).
2. Escreva um parágrafo técnico (6 a 10 linhas) identificando o papel de cada um destes componentes do ecossistema .NET nesse processo: o SDK, o compilador (Roslyn), o CLR e a Base Class Library (BCL).
3. Descreva, em ordem, o ciclo de vida completo do programa desde a edição do arquivo Program.cs até a execução: escrita do código-fonte, compilação para IL pelo compilador, carregamento do assembly pelo CLR, compilação JIT para código de máquina e execução.

## Checklist

- [ ] A partir do projeto AmbienteEstacionamento do Exercício 1, rode dotnet build e liste, no relatório, os arquivos gerados dentro da pasta bin/Debug/net10.0 (o assembly .dll, o .pdb, o .deps.json e o .runtimeconfig.json).
- [ ] Escreva um parágrafo técnico (6 a 10 linhas) identificando o papel de cada um destes componentes do ecossistema .NET nesse processo: o SDK, o compilador (Roslyn), o CLR e a Base Class Library (BCL).
- [ ] Descreva, em ordem, o ciclo de vida completo do programa desde a edição do arquivo Program.cs até a execução: escrita do código-fonte, compilação para IL pelo compilador, carregamento do assembly pelo CLR, compilação JIT para código de máquina e execução.

## Evidências e observações

_Adicionar aqui os comandos, resultados e observações relevantes._
