using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Estudante.Dominio;

namespace Estudante.Repositorio
{
    public class EstudanteDbContext : DbContext
    {
        public EstudanteDbContext(DbContextOptions<EstudanteDbContext> options)
            : base(options)
        {
        }

        // DbSet = tabela de estudantes
        public DbSet<EstudanteDominio> Estudantes { get; set; }
    }
}
