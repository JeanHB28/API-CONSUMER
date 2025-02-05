using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ProyectoBibliotecaAPI.Models
{
  

    public class Prestamo
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("Usuario")]
        public int? UsuarioID { get; set; }

        [ForeignKey("Libro")]
        public int? LibroID { get; set; }

        public DateTime? FechaPrestamo { get; set; }
        public DateTime? FechaDevolucion { get; set; }

        [StringLength(50)]
        public string? Estado { get; set; }

        [StringLength(50)]
        public string? Renovaciones { get; set; }

        public Usuario? Usuario { get; set; }
        public Libro? Libro { get; set; }
    }

}
