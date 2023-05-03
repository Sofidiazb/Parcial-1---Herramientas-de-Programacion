using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Parcial1.Models;

namespace Parcial1.Data
{
    public class CursoContext : DbContext
    {
        public CursoContext (DbContextOptions<CursoContext> options)
            : base(options)
        {
        }

        public DbSet<Parcial1.Models.Curso> Curso { get; set; } = default!;

        public DbSet<Parcial1.Models.Estudiante> Estudiante { get; set; } = default!;
    }
}
