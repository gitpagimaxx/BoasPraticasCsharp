using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Services;
using System.Net.Http.Json;

namespace Alura.Adopet.Console.Repository
{
    public class Repositories
    {
        static HttpClient client = ServiceCollection.ConfiguraHttpClient();

        public static async Task<HttpResponseMessage> CreatePetAsync(Pet pet)
        {
            return await client.PostAsJsonAsync("pet/add", pet);
        }

        public static async Task<IEnumerable<Pet>?> ListPetsAsync()
        {
            HttpResponseMessage response = await client.GetAsync("pet/list");
            return await response.Content.ReadFromJsonAsync<IEnumerable<Pet>>();
        }
    }
}