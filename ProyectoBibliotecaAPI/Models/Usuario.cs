using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ProyectoBibliotecaAPI.Models;

public class Usuario
{
    [Key]
    public int ID { get; set; }

    [Required]
    [StringLength(50)]
    public string Nombre { get; set; } = string.Empty;

    [Required]
    [EmailAddress]
    [StringLength(50)]
    public string Email { get; set; } = string.Empty;

    [Required]
    [StringLength(60)] 
    public string Contraseña { get; set; } = string.Empty;

    [Required]
    [StringLength(20)]
    public string Rol { get; set; } = "Usuario";

    public List<Prestamo> HistorialDePrestamos { get; set; } = new List<Prestamo>();

    [Column(TypeName = "jsonb")] 
    public string Preferencias { get; set; } = "{}"; 
}
