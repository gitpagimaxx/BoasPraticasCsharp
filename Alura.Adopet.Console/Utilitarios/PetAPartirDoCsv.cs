using Alura.Adopet.Console.Modelos;

namespace Alura.Adopet.Console.Utilitarios;

public static class PetAPartirDoCsv
{
    public static Pet ConverteDoTexto(this string? linha)
    {
        if (linha is null)
            throw new ArgumentNullException("O texto não pode ser vazio");

        string[] props = linha.Split(";");

        if (props.Length != 3)
            throw new ArgumentException("A linha deve conter 3 propriedades");

        bool isValid = Guid.TryParse(props[0], out Guid guid);
        if (!isValid)
            throw new ArgumentException("Guid deve ser ser válido");

        if (!Enum.IsDefined(typeof(TipoPet), int.Parse(props[2])))
            throw new ArgumentException("O tipo de pet informado não existe");

        TipoPet tipoPet = props[2] == "1" ? TipoPet.Gato : TipoPet.Cachorro;

        return new(guid, props[1], tipoPet);
    }
}