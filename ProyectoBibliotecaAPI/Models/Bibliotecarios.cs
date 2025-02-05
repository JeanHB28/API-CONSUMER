using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ProyectoBibliotecaAPI.Models
{
   
    public class Bibliotecario
    {
        [Key]
        public int ID { get; set; }

        [StringLength(50)]
        public string? Nombre { get; set; }

        [StringLength(50)]
        public string? Email { get; set; }

        [StringLength(50)]
        public string? Permisos { get; set; }

        [StringLength(50)]
        public string? BibliotecasAsignada { get; set; }
    }

}
