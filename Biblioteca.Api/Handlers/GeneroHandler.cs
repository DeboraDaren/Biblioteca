using Biblioteca.Api.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.Api.Handlers
{
    public class GeneroHandler : ControllerBase //"Recebe do Autor"
    {
        private static List<Genero> Genero = new List<Genero>();

        public IActionResult GetByld(long Id)
        {

        }
    }
}
