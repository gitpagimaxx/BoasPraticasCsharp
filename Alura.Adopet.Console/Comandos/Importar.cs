using Alura.Adopet.Console.Interfaces;
using Alura.Adopet.Console.Repository;
using Alura.Adopet.Console.Services;
using Alura.Adopet.Console.Utilitarios;

namespace Alura.Adopet.Console.Factories;

[DocComando(instrucao: "import", documentacao: "adopet import <arquivo> comando que realiza a importação do arquivo de pets.")]
public class Importar : IComandos
{
    public Importar()
    {
    }

    public async Task ExecutarAsync(string[] args)
    {
        await InstrucaoImportar(args);
    }

    private async Task InstrucaoImportar(string[] args)
    {
        System.Console.WriteLine("----- Serão importados os dados abaixo -----");
        var lista = await LeitorArquivo.RealizaLeitura(args[1]);

        foreach (var pet in lista)
        {
            System.Console.WriteLine(pet);

            try
            {
                var resposta = Repositories.CreatePetAsync(pet);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }

        System.Console.WriteLine("Importação concluída!");
    }
}