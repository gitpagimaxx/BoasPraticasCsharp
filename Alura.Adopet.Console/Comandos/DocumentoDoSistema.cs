using Alura.Adopet.Console.Factories;
using System.Reflection;

namespace Alura.Adopet.Console.Comandos;

public class DocumentoDoSistema
{
    public static Dictionary<string, DocComando> ToDictionary(Assembly assemblyComOTipoDocComando)
    {
        return assemblyComOTipoDocComando.GetTypes()
            .Where(t => t.GetCustomAttributes<DocComando>().Any())
            .Select(t => t.GetCustomAttribute<DocComando>()!)
            .ToDictionary(d => d.Instrucao);
    }
}