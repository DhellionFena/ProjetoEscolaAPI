using Microsoft.AspNetCore.Mvc;

namespace ProjetoEscola_WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() {
            return Ok("Dhellion teste");
        }
    }
}