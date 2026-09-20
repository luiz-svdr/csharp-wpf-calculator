# C# WPF Calculator

Projeto de estudo em C# (.NET/WPF): uma calculadora com histórico de operações para desktop, com foco em lógica de programação, tratamento de erros e organização de código.

## Tecnologias

C#, .NET, WPF, XAML.

## Estrutura

```
MyCalcHistory/
├── Resources/
│   └── ProjectDictionary.xaml
├── Services/
│   └── CalculadoraService.cs
├── App.xaml
├── MainWindow.xaml
```

## Funcionalidades

Interface com display e botões numéricos, de função (AC, +/-, %) e de operação (+, -, *, /, =), com estilos customizados (bordas arredondadas, cores diferenciadas por tipo de botão) centralizados no ProjectDictionary.

Captura dos cliques concatenando a expressão digitada diretamente no display.

CalculadoraService responsável por interpretar a expressão digitada, separando números e operadores (tokenização) e convertendo os números para double.

## Próximas etapas

Resolver a expressão respeitando a precedência de operadores (multiplicação/divisão antes de soma/subtração), consumir o CalculadoraService no clique do botão "=" e exibir o resultado no display.

Projeto em desenvolvimento contínuo como estudo de C# e WPF.
