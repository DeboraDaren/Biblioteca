using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorController : ControllerBase
    {
        private AutorController handler;

        public AutorController()
        {
            handler = new AutorController();
        }

        //[HttpGet]
    }
}
