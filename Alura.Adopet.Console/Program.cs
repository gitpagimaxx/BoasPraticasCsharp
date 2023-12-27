﻿using Alura.Adopet.Console.Comandos;
using Alura.Adopet.Console.Interfaces;

Console.ForegroundColor = ConsoleColor.Green;
try
{
    ComandosDoSistema comandos = new();
    string comando = args[0].Trim();
    IComandos? cmd = comandos[comando];

    if (cmd is not null) 
        await cmd.ExecutarAsync(args);
    else 
        Console.WriteLine("Comando inválido!");
}
catch (Exception ex)
{
    // mostra a exceção em vermelho
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Aconteceu um exceção: {ex.Message}");
}
finally
{
    Console.ForegroundColor = ConsoleColor.White;
}