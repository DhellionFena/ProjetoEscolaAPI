using Microsoft.AspNetCore.Mvc;
using ProjetoEscolaWebApi.Data;
using System.Threading.Tasks;
using ProjetoEscolaWebApi.Models;
using System;

namespace ProjetoEscolaWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        private readonly IRepository _repo;
        public AlunoController(IRepository repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public async Task<IActionResult> Get() {
             try
            {
                var result = await _repo.GetAllAlunosAsync(false);
                return Ok(result);
            }
            catch (System.Exception e)
            {
                
                return BadRequest("Erro: " + e.Message);;
            }
        }
        [HttpGet("{alunoId}")]
        public async Task<IActionResult> GetByAlunoId(int alunoId) {
             try
            {
                var result = await _repo.GetAlunoAsyncById(alunoId, true);
                return Ok(result);
            }
            catch (System.Exception e)
            {
                
                return BadRequest("Erro: " + e.Message);
            }
        }

        [HttpGet("ByDisciplina/{disciplinaId}")]
        public async Task<IActionResult> GetByDisciplinaId(int disciplinaId) {
             try
            {
                var result = await _repo.GetAlunosAsyncByDisciplinaId(disciplinaId, false);
                return Ok(result);
            }
            catch (System.Exception e)
            {
                
                return BadRequest("Erro: " + e.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> post(Aluno model) {
             try
            {
                _repo.Add(model);

                if (await _repo.SaveChangesAsync())
                {
                    return Ok(model.nome + " Adicionado Com Sucesso!");
                }
            }
            catch (System.Exception e)
            {
                
                return BadRequest("Erro: " + e.Message);
            }

            return BadRequest("Erro não esperado.");
        }
        [HttpPut("{alunoId}")]
        public async Task<IActionResult> put(int alunoId, Aluno model) {
             try
            {
                var aluno = await _repo.GetAlunoAsyncById(alunoId, false);
                if (aluno == null) return NotFound("Aluno não encontrado.");
                if (aluno.id != model.id) throw new Exception("Id de aluno não corresponde ao que será atualizado.");
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

        [HttpDelete("{alunoId}")]
        public async Task<IActionResult> put(int alunoId) {
             try
            {
                var aluno = await _repo.GetAlunoAsyncById(alunoId, false);
                if (aluno == null) return NotFound("Aluno não encontrado.");
                _repo.Delete(aluno);

                if (await _repo.SaveChangesAsync())
                {
                    return Ok("Aluno Deletado com Sucesso!");
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