using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using ProyectoBibliotecaAPI.Models;

namespace ProyectoBibliotecaAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}
        public DbSet<Libro> Libros { get; set; }
        public DbSet<Bibliotecario> Bibliotecario { get; set; }
        public DbSet<Prestamo> Prestamos { get; set; }
        public DbSet<Recomendacion> Recomendacion { get; set; }
        public DbSet<Reserva> Reserva { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

    }
}
