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
        /*
         * Este método se ejecuta cuando se está construyendo el modelo de datos. 
         * Aquí defines reglas personalizadas, relaciones, restricciones, nombres de tablas, etc.
         */
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Acción", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Ciencia Ficción", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Historia", DisplayOrder = 3 },
                new Category { Id = 4, Name = "Terror", DisplayOrder = 4 },
                new Category { Id = 5, Name = "Romance", DisplayOrder = 5 },
                new Category { Id = 6, Name = "Animación", DisplayOrder = 6 },
                new Category { Id = 7, Name = "Comedia", DisplayOrder = 7 }
                );
        }
        
            
        

    }
}
