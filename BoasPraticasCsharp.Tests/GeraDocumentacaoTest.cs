using Alura.Adopet.Console.Comandos;
using Alura.Adopet.Console.Factories;
using System.Reflection;

namespace BoasPraticasCsharp.Tests;

public class GeraDocumentacaoTest
{
    [Fact]
    public void QuandoExistemComandosDeveRetornarDicNaoVazio()
    {
        //arrange
        Assembly assemblyComOTipoDocComando = Assembly.GetAssembly(typeof(DocComando))!;

        // act
        Dictionary<string, DocComando> dicionario = DocumentoDoSistema.ToDictionary(assemblyComOTipoDocComando);

        // assert
        Assert.NotNull(dicionario);
        Assert.NotEmpty(dicionario);
        Assert.Equal(4, dicionario.Count);
    }
}