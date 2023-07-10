namespace PracticeAPIRestFull.Models.Entidades
{
    public class Comentario
    {
        public int Id { get; set; }
        public string? Contenido { get; set; }
        public bool Recomendar { get; set; }

        //Relacion muchos a uno
        public int PeliculaId { get; set; }
        public Pelicula Pelicula { get; set; } = null!;
    }
}
