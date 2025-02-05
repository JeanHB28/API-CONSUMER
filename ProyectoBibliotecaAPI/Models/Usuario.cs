namespace ProyectoBibliotecaAPI.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Usuario
    {
        [Key]
        public int ID { get; set; }

        [StringLength(50)]
        public string? Nombre { get; set; }

        [StringLength(50)]
        public string? Email { get; set; }

        [StringLength(50)]
        public string? Contraseña { get; set; }

        [StringLength(50)]
        public string? HistorialDePrestamos { get; set; }

        [StringLength(50)]
        public string? Preferencias { get; set; }

        [StringLength(50)]
        public string? Rol { get; set; }
    }

}