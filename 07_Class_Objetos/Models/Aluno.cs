
//O namespace é um nome em que usaremos para fazer referência quando usarmos
namespace Sesi.model
{

    //Declarando a class Aluno
    public class Aluno
    {

        //Declarando os atributos (propriedades) da class Aluno

        public string nome { get; set; }
        public string idade { get; set; }

        public string turma { get; set; }

        //Declarando um atribuido privado

        private int nrFaltas { get; set; }

        //Criando um método

        public void Apresentar(){
            
        }
    }
}