namespace Sesi.Models
{
    public class Aluno
    {

        public string nome { get; set; }
        public string idade { get; set; }

        public Aluno(string nomeAluno, int idadeAluno)
        {
            this.nome = nomeAluno;
            this.idade = idadeAluno;
        }
    }
}