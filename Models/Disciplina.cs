using System.Collections.Generic;

namespace ProjetoEscolaWebApi.Models
{
    public class Disciplina
    {

        public Disciplina()
        {

        }
        public Disciplina(int id, string nome, int professorId)
        {
            this.id = id;
            this.professorId = professorId;
            this.nome = nome;

        }
        public int id { get; set; }
        public int professorId { get; set; }
        public Professor professor { get; set; }
        public string nome { get; set; }
        public IEnumerable<AlunoDisciplina> AlunosDisciplinas { get; set; }
    }
}