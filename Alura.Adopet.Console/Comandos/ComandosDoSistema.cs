using Alura.Adopet.Console.Factories;
using Alura.Adopet.Console.Interfaces;
using System.Windows.Input;

namespace Alura.Adopet.Console.Comandos;

public class ComandosDoSistema
{
    private Dictionary<string, IComandos> comandosDoSistema = new()
    {
        { "import", new Importar() },
        { "help", new Help() },
        { "show", new Show() },
        { "list", new Listar() },
    };

    public IComandos? this[string key] => comandosDoSistema.ContainsKey(key) ? comandosDoSistema[key] : null;

}