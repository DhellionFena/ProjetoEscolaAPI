namespace ProjetoEscola_WebAPI.Models
{
    public class Disciplina
    {

        public Disciplina()
        {

        }
        public Disciplina(int id, int professorId, Professor professor, string nome)
        {
            this.id = id;
            this.ProfessorId = professorId;
            this.Professor = professor;
            this.nome = nome;

        }
        public int id { get; set; }
        public int ProfessorId { get; set; }
        public Professor Professor { get; set; }
        public string nome { get; set; }
    }
}