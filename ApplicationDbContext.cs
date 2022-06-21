using System;
using Microsoft.EntityFrameworkCore;
using WebApiAutoresVsCode.Models;

namespace WebApiAutoresVsCode
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Autor> Autores { get; set; }
    }
}