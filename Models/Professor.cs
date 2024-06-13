namespace ProjetoEscola_WebAPI.Models
{
    public class Professor
    {

        public Professor()
        {
            
        }
        public Professor(int id, string nome, string sobrenome)
        {
            this.id = id;
            this.nome = nome;
            this.sobrenome = sobrenome;
            // this.disciplina = disciplina;

        }
        public int id { get; set; }
        public string nome { get; set; }
        public string sobrenome { get; set; }

        //public string disciplina { get; set; }
    }
}