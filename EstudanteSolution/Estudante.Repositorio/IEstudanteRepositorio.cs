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
        void Adicionar(Dominio.EstudanteDominio aluno);
        List<Dominio.EstudanteDominio> Listar();
    }

    // Implementação em memória
    public class EstudanteRepositorio : IEstudanteRepositorio
    {
        private readonly EstudanteDbContext _context;

        public EstudanteRepositorio(EstudanteDbContext context)
        {
            _context = context;
        }

        public void Adicionar(EstudanteDominio estudante)
        {
            _context.Estudantes.Add(estudante);
            _context.SaveChanges();
        }

        public List<EstudanteDominio> Listar()
        {
            return _context.Estudantes.ToList();
        }
    }
}
