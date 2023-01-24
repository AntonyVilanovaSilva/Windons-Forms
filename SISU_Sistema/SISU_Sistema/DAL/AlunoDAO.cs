using SISU_Sistema.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISU_Sistema.DAL
{
    public class AlunoDAO
    {
        private string enderecoArquivo;

        public AlunoDAO()
        {

            enderecoArquivo = "Aluno.txt";


        } 

        public void inserir(Aluno aluno)
        {





        }
        public List<Aluno> getTodosAlunos()
        {
            List<Aluno> novalista = new List<Aluno>();
            StreamReader sr = new StreamReader(enderecoArquivo);

        }
    }
}
