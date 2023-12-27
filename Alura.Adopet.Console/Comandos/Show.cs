using Alura.Adopet.Console.Interfaces;
using Alura.Adopet.Console.Utilitarios;

namespace Alura.Adopet.Console.Factories;

[DocComando(instrucao: "show", documentacao: "adopet show <arquivo>")]
public class Show : IComandos
{
    public Show()
    {
    }

    public Task ExecutarAsync(string[] args)
    {
        _ = this.InstrucaoShow(args);
        return Task.CompletedTask;
    }

    private async Task InstrucaoShow(string[] args)
    {
        System.Console.WriteLine("----- Importados -----");
        var lista = await LeitorArquivo.RealizaLeitura(args[1]);

        foreach (var item in lista)
        {
            System.Console.WriteLine(item);
        }
    }

}