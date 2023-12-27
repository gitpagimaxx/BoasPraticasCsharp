using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Utilitarios;

namespace BoasPraticasCsharp.Tests
{
    public class PetAPartirDoCsvTest
    {
        [Fact]
        public void QuandoStringForValidaDeveRetornarUmPet()
        {
            string linha = "456b24f4-19e2-4423-845d-4a80e8854a41;Lima Limão;1";

            Pet pet = linha.ConverteDoTexto();

            Assert.NotNull(pet);
        }

        [Fact]
        public void QuandoStringForNula()
        {
            // arrange
            string? linha = null;

            // act + assert
            Assert.ThrowsAny<ArgumentException>(() => linha.ConverteDoTexto());
        }

        [Fact]
        public void QuandoStringForVazia()
        {
            string linha = "";

            Assert.ThrowsAny<ArgumentException>(() => linha.ConverteDoTexto());
        }

        [Fact]
        public void QuandoStringTiverMenosQueTresPropriedades()
        {
            string? linha = "456b24f4-19e2-4423-845d-4a80e8854a41;Lima Limão";

            Assert.Throws<ArgumentException>(() => linha?.ConverteDoTexto());
        }

        [Fact]
        public void QuandoGuidEstiverErradoLancarException()
        {
            string? linha = "456b24f4-19e2-4423-845d;Lima Limão;2";

            Assert.Throws<ArgumentException>(() => linha?.ConverteDoTexto());
        }

        [Fact]
        public void QuandoTipoPetForInvalido()
        {
            string? linha = "456b24f4-19e2-4423-845d-4a80e8854a41;Lima Limão;3";

            Assert.ThrowsAny<ArgumentException>(() => linha?.ConverteDoTexto());
        }
    }
}