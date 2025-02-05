namespace ProyectoBibliotecaAPI.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Recomendacion
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("Usuario")]
        public int? UsuarioID { get; set; }

        [ForeignKey("Libro")]
        public int? LibroID { get; set; }

        [StringLength(50)]
        public string? TipoRecomendacion { get; set; }

        public DateTime? FechaGeneracion { get; set; }

        public Usuario? Usuario { get; set; }
        public Libro? Libro { get; set; }
    }

}
