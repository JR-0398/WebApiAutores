using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiAutoresVsCode.Models;

namespace WebApiAutoresVsCode.Controllers{

    [ApiController]
    [Route("api/libros")]
    public class LibrosController : ControllerBase{
        private readonly ApplicationDbContext context;

        public LibrosController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Libro>> Get(int id)
        {
            //Con .Include(x=> x.Autor) podemos incluir el autor
            return await context.Libros.Include(x=>x.Autor).FirstOrDefaultAsync(x=> x.Id == id);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Libro libro){
            //Verificamos que el exista el Id del autor del libro del cual creamos
            var existeAutor= await context.Autores.AnyAsync(x=> x.Id==libro.AutorId);

            //Si no existe el id del autor, nos devolvera un error 404
            if(!existeAutor){
                return BadRequest($"No existe el autor de Id: {libro.AutorId}");
            }
            //Si existe el id del autor procederemos a crear el libro.
            context.Add(libro);
            await context.SaveChangesAsync();
            return Ok();
        }
    }
}