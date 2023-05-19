using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeneroController : ControllerBase
    {
        private GeneroController handler;
        public GeneroController()
        {
            handler = new GeneroController();
        }

        [HttpGet]
        [Route("id_Genero")]
       
    }
}
