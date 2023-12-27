using Alura.Adopet.Console.Interfaces;
using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Repository;

namespace Alura.Adopet.Console.Factories;

[DocComando(instrucao: "list", documentacao: "adopet list")]
public class Listar : IComandos
{
    public Listar()
    {
    }

    public Task ExecutarAsync(string[] args)
    {
        this.InstrucaoListar();
        return Task.CompletedTask;
    }

    private async void InstrucaoListar()
    {
        System.Console.WriteLine("----- Lista de Pets importados no sistema -----");

        IEnumerable<Pet>? pets = await Repositories.ListPetsAsync();

        foreach (var pet in pets ?? new List<Pet>())
        {
            System.Console.WriteLine(pet);
        }
    }
}