using EcommerceWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace EcommerceWebApp.Data
{
    public class ApplicationDbContext : DbContext //aqui eredemos de la clase DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            //esto es el contructor que hereda de DBContext este es el proposito de inicializar el 
            //contexto de la base de datos con esta configuracion especifica
            // base.... llama al contructor y le pasamos las opciones 
        }

        //agregamos la tabla Category
        public DbSet<Category> Categories { get; set; }

    }
}
