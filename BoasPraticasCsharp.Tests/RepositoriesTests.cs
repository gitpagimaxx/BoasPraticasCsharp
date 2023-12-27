using Alura.Adopet.Console.Repository;

namespace BoasPraticasCsharp.Tests
{
    public class RepositoriesTests
    {
        [Fact]
        public async Task RetornarUmaListaNaoVazia()
        {
            // arrange

            // act
            var lista = await Repositories.ListPetsAsync();

            // assert
            Assert.NotNull(lista);
            Assert.NotEmpty(lista);
        }

        //[Fact]
        //public async Task QuandoAPIForaDeveRetornarUmaExcecao()
        //{
        //    // arrange

        //    // act + assert
        //    await Assert.ThrowsAnyAsync<Exception>(() => Repositories.ListPetsAsync());
        //}
    }
}