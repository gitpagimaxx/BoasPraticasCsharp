namespace Alura.Adopet.Console.Factories;

[AttributeUsage(AttributeTargets.Class)]
public class DocComando : Attribute
{
    public DocComando(string instrucao, string documentacao)
    {
        Instrucao = instrucao;
        Documentacao = documentacao;
    }

    public string Instrucao { get; }
    public string Documentacao { get; }
}