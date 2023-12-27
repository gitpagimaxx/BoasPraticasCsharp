using Alura.Adopet.Console.Modelos;

namespace Alura.Adopet.Console.Interfaces;

public interface IRepository
{
    Task<HttpResponseMessage> CreatePetAsync(Pet pet);
    Task<IEnumerable<Pet>?> ListPetsAsync();
}
