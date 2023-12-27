using Alura.Adopet.Console.Comandos;
using Alura.Adopet.Console.Interfaces;
using System.Reflection;

namespace Alura.Adopet.Console.Factories;

[DocComando(instrucao: "help", documentacao: "adopet help")]
public class Help : IComandos
{
    private readonly Dictionary<string, DocComando> docs;

    public Help()
    {
        docs = DocumentoDoSistema.ToDictionary(Assembly.GetExecutingAssembly());
    }

    public Task ExecutarAsync(string[] args)
    {
        InstrucaoHelp(args);
        return Task.CompletedTask;
    }

    private void InstrucaoHelp(string[] args)
    {
        if (args.Length == 1)
        {
            System.Console.WriteLine("adopet help <parametro> ou simplemente adopet help  " +
                 "comando que exibe informações de ajuda dos comandos.");
            System.Console.WriteLine("Adopet (1.0) - Aplicativo de linha de comando (CLI).");
            System.Console.WriteLine("Realiza a importação em lote de um arquivos de pets.");
            System.Console.WriteLine("Comando possíveis: ");

            foreach (var item in docs.Values)
            {
                System.Console.WriteLine(item.Documentacao);
            }
        }
        else if (args.Length == 2)
        {
            string comando = args[1];
            if (docs.ContainsKey(comando))
            {
                System.Console.WriteLine(docs[comando].Documentacao);
            }
        }
    }
}