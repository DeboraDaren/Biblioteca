using System.Text.Json.Serialization;

namespace Biblioteca.Api.Domain
{
    public class Autor
    {
        [JsonPropertyName("Titulo")]
        public string titulo { get; set; }

        [JsonPropertyName("Autor")]
        public string autor { get; set; }

        [JsonPropertyName("Genero")]
        public string genero { get; set; }

        [JsonPropertyName("Editora")]
        public string editora { get; set; }

    }
}
