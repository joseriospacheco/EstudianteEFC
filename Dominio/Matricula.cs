using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Matricula
    {
        public int Id { get; set; } 
        public Estudiante Estudiante { get; set; }
        public int EstudianteId { get; set; }

        public Profesor Profesor { get; set; }
        public int ProfesorId { get; set; }


    }
}
