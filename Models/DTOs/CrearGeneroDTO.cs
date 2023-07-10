using System.ComponentModel.DataAnnotations;

namespace IntroEF_Avanzado.Models.DTOs
{
    public class CrearGeneroDTO
    {
        [StringLength(100)]
        public string Nombre { get; set; } = null!;
    }
}
