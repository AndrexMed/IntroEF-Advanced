namespace IntroEF_Avanzado.Models.DTOs
{
    public class CrearActorDTO
    {
        public string Nombre { get; set; } = null!;
        public decimal Fortuna { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}
