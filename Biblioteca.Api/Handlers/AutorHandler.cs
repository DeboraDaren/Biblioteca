using Biblioteca.Api.Domain;

namespace Biblioteca.Api.Handlers
{
    public class AutorHandler
    {
        public static List<Genero> Genero = new List<Genero>();

        public IAsyncResult GetByld(long id)
        {
            Genero? genero = generos.Where(genero => genero.Id == id).FirstOrDefault();
            if (genero == null)
            {
                return;
            }
        }
    }
}
