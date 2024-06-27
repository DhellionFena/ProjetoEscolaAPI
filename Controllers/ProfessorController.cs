using Microsoft.AspNetCore.Mvc;
using ProjetoEscolaWebApi.Data;
using System.Threading.Tasks;
using ProjetoEscolaWebApi.Models;
using System;

namespace ProjetoEscolaWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfessorController : ControllerBase
    {

        private readonly IRepository _repo;
        public ProfessorController(IRepository repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public async Task<IActionResult> Get() {
             try
            {
                var result = await _repo.GetAllProfessoresAsync(true);
                return Ok(result);
            }
            catch (System.Exception e)
            {
                
                return BadRequest("Erro: " + e.Message);;
            }
        }
        [HttpGet("{profId}")]
        public async Task<IActionResult> GetByProfessorId(int profId) {
             try
            {
                var result = await _repo.GetProfessorAsyncById(profId, true);
                return Ok(result);
            }
            catch (System.Exception e)
            {
                
                return BadRequest("Erro: " + e.Message);
            }
        }

        [HttpGet("ByAluno/{alunoId}")]
        public async Task<IActionResult> GetByAlunoId(int alunoId) {
             try
            {
                var result = await _repo.GetProfessoresAsyncByAlunoId(alunoId, true);
                return Ok(result);
            }
            catch (System.Exception e)
            {
                
                return BadRequest("Erro: " + e.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> post(Professor model) {
             try
            {
                _repo.Add(model);

                if (await _repo.SaveChangesAsync())
                {
                    return Ok(model);
                }
            }
            catch (System.Exception e)
            {
                
                return BadRequest("Erro: " + e.Message);
            }

            return BadRequest("Erro não esperado.");
        }
        [HttpPut("{profId}")]
        public async Task<IActionResult> put(int profId, Professor model) {
             try
            {
                var professor = await _repo.GetProfessorAsyncById(profId, false);
                if (professor == null) return NotFound("Professor não encontrado.");
                if (professor.id != model.id) throw new Exception("Id de professor não corresponde ao que será atualizado.");
                _repo.Update(model);

                if (await _repo.SaveChangesAsync())
                {
                    return Ok(model);
                }
            }
            catch (System.Exception e)
            {
                
                return BadRequest("Erro: " + e.Message);
            }

            return BadRequest("Erro não esperado.");
        }

        [HttpDelete("{profId}")]
        public async Task<IActionResult> put(int profId) {
             try
            {
                var professor = await _repo.GetProfessorAsyncById(profId, false);
                if (professor == null) return NotFound("Professor não encontrado.");
                _repo.Delete(professor);

                if (await _repo.SaveChangesAsync())
                {
                    return Ok("Professor Deletado com Sucesso!");
                }
            }
            catch (System.Exception e)
            {
                
                return BadRequest("Erro: " + e.Message);
            }

            return BadRequest("Erro não esperado.");
        }
        
    }
}