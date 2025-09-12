using Estudante.Dominio;
using Estudante.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudante.Servico
{
    // Interface
    public interface IEstudanteServico
    {
        void Adicionar(Dominio.EstudanteDominio aluno);
        List<Dominio.EstudanteDominio> Listar();
    }

    // Implementação
    public class EstudanteServico : IEstudanteServico
    {
        private readonly IEstudanteRepositorio _repositorio;

        public EstudanteServico(IEstudanteRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public void Adicionar(Dominio.EstudanteDominio aluno)
        {
            if (string.IsNullOrWhiteSpace(aluno.Nome))
                throw new Exception("O nome do aluno é obrigatório.");

            _repositorio.Adicionar(aluno);
        }

        public List<Dominio.EstudanteDominio> Listar()
        {
            return _repositorio.Listar();
        }
    }
}
