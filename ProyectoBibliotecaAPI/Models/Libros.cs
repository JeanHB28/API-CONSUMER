using System;
using System.ComponentModel.DataAnnotations;

namespace ProyectoBibliotecaAPI.Models
{
    
    public class Libro
    {
        [Key]
        public int ID { get; set; }

        [StringLength(50)]
        public string? Titulo { get; set; }

        [StringLength(50)]
        public string? Autor { get; set; }

        [StringLength(50)]
        public string? Género { get; set; }

        public DateTime? AñoDePublicación { get; set; }

        [StringLength(50)]
        public string? Editorial { get; set; }

        [StringLength(50)]
        public string? Disponibilidad { get; set; }

        public int? Calificación { get; set; }

        [StringLength(50)]
        public string? Popularidad { get; set; }
    }

}
