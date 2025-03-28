﻿// Declaracao de variaveis
string nomeDigitado;
string sobrenomeDigitado;


Console.Write("Precione uma tecla para continuar...");
Console.ReadKey(true);

Console.Clear();

Console.WriteLine("---Dados Pessoais---");

Console.Write("nome: ");
nomeDigitado = Console.ReadLine()!;

Console.Write("sobrenome: ");
sobrenomeDigitado = Console.ReadLine()!;

Console.WriteLine(nomeDigitado);
Console.WriteLine(sobrenomeDigitado);

Console.WriteLine($"Boa noite, {nomeDigitado} {sobrenomeDigitado}!");
