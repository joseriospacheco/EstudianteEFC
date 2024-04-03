using Dominio;
using EstudianteEFC.Context;
using Microsoft.AspNetCore.Mvc;

namespace EstudianteEFC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudiantesController : ControllerBase
    {

        private readonly DbContexto _context;


        public EstudiantesController(DbContexto context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<Estudiante>> Get()
        {

            return _context.Estudiantes.ToList();

        }

        [HttpPost]
        public ActionResult Post([FromBody] Estudiante estudiante)
        {
            _context.Estudiantes.Add(estudiante);

            _context.SaveChanges();

            return Ok("POST");

        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id) {


           var estudianteEncontrado = _context.Estudiantes.Find(id);

            if (estudianteEncontrado is not null) {
                _context.Remove(estudianteEncontrado);
                _context.SaveChanges();

                return Ok();
            }


            return NotFound();
           
        }

    }
}
