using WebApiAutoresVsCode.Models;

namespace   WebApiAutoresVsCode.Models
{
    public class Libro{
        public int Id { get; set; } 
        public string Titulo { get; set; }
        public int AutorId { get; set; }
        public Autor Autor { get; set; } //Propiedad de Navegacion, poder cargar la data del autor que escribi el libro
        
    }
}