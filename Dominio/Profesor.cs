using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Profesor
    {
        public required int Id { get; set; }
        public required string Documento { get; set; }
        public required string Nombres { get; set; }
        public required string Profesion { get; set; }
        public required decimal Salario { get; set; }
        public bool Activo { get; set; } = true;
    }
}
