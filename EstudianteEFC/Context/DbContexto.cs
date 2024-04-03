using Dominio;
using Microsoft.EntityFrameworkCore;

namespace EstudianteEFC.Context
{
    public class DbContexto(DbContextOptions<DbContexto> opt) : DbContext(opt)
    {
        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Profesor> Profesores { get; set; }

        public DbSet<Matricula> Matriculas { get; set; }
    }
}
