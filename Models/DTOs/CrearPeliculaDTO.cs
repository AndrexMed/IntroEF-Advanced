namespace IntroEF_Avanzado.Models.DTOs
{
    public class CrearPeliculaDTO
    {
        public string Titulo { get; set; } = null!;
        public bool enCines { get; set; }
        public DateTime FechaEstreno { get; set; }
        public List<int> Generos { get; set; } = new List<int>();
        public List<PeliculaActorDTO> PeliculaActores { get; set; } = new List<PeliculaActorDTO>();
    }
}
