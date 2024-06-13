using Microsoft.AspNetCore.Mvc;

namespace ProjetoEscola_WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfessorController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get() {
            try
            {
                return Ok("Apenas um teste");
            }
            catch (System.Exception e)
            {
                
                return BadRequest("Erro: " + e.Message);;
            }
            
        }
        
    }
}