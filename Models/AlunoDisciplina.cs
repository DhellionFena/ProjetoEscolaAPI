namespace ProjetoEscola_WebAPI.Models
{
    public class AlunoDisciplina
    {

        public AlunoDisciplina()
        {

        }

        public AlunoDisciplina(int alunoId, Aluno aluno, int disciplinaId, Disciplina disciplina)
        {
            this.alunoId = alunoId;
            this.aluno = aluno;
            this.disciplinaId = disciplinaId;
            this.disciplina = disciplina;

        }
        public int alunoId { get; set; }
        public Aluno aluno { get; set; }
        public int disciplinaId { get; set; }
        public Disciplina disciplina { get; set; }
    }
}