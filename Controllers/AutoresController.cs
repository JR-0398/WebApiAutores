using System;
using Microsoft.AspNetCore.Mvc;
using WebApiAutoresVsCode.Models;

namespace WebApiAutoresVsCode.Controllers
{
    [ApiController]
    [Route("api/autores")]
    public class AutoresController:ControllerBase{
        
        [HttpGet]
        public ActionResult<List<Autor>> Get(){
             return new List<Autor>(){
                new Autor(){Id=1, Nombre="Juan"},
                new Autor(){Id=2, Nombre="Jose"}
             };
        }
    }
}