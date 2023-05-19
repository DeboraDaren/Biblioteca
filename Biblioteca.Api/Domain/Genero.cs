using System.Text.Json.Serialization;

namespace Biblioteca.Api.Domain
{
    public class Genero
    {
        [JsonPropertyName("id_genero")]
        public int Id { get; set; }

        [JsonPropertyName("Editora")]
        public string Nome { get; set; }

        [JsonPropertyName("Ano_Publicacao")]
        public int Ano_Publicacao { get; set; }
    }
}
