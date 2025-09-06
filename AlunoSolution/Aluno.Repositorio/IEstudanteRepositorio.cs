using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estudante.Dominio;

namespace Estudante.Repositorio
{
    // Interface
    public interface IEstudanteRepositorio
    {
        void Adicionar(Dominio.Aluno aluno);
        List<Dominio.Aluno> Listar();
    }

    // Implementação em memória
    public class EstudanteRepositorio : IEstudanteRepositorio
    {
        private static List<Dominio.Aluno> _alunos = new();

        public void Adicionar(Dominio.Aluno Aluno)
        {
            _alunos.Add(Aluno);
        }

        public List<Dominio.Aluno> Listar()
        {
            return _alunos;
        }
    }
}
