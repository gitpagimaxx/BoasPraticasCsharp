using Alura.Adopet.Console.Modelos;

namespace Alura.Adopet.Console.Utilitarios;

public class LeitorArquivo
{
    public static async Task<List<Pet>> RealizaLeitura(string caminhoDoArquivo)
    {
        List<Pet> listaPet = new();

        using StreamReader sr = new(caminhoDoArquivo);

        while (!sr.EndOfStream)
        {
            listaPet.Add(PetAPartirDoCsv.ConverteDoTexto(await sr.ReadLineAsync()));
        }

        return listaPet;
    }
}