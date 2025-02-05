namespace ProyectoBibliotecaAPI.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Reserva
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("Usuario")]
        public int? UsuariosID { get; set; }

        [ForeignKey("Libro")]
        public int? LibroID { get; set; }

        public DateTime? FechaReserva { get; set; }

        [StringLength(50)]
        public string? Estados { get; set; }

        [StringLength(50)]
        public string? Prioridad { get; set; }

        public Usuario? Usuario { get; set; }
        public Libro? Libro { get; set; }
    }

}
