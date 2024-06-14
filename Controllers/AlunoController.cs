using Microsoft.AspNetCore.Mvc;
using ProjetoEscolaWebApi.Data;

namespace ProjetoEscolaWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        public AlunoController(IRepository repo)
        {
            
        }
        [HttpGet]
        public IActionResult Get() {
            return Ok("Dhellion teste");
        }
    }
}