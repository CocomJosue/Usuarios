using System.ComponentModel.DataAnnotations;

namespace ActividadGS.Models;

public class Usuario
{
    [Key]
    public int IdUsuario { get; set; }
    public string ApPaterno { get; set; }
    public string ApMaterno { get; set; }
    public string Nombre { get; set; }
    public int Edad {  get; set; }
}
