using IntroEF_Avanzado.Models.Entidades;

namespace PracticeAPIRestFull.Models.Entidades
{
    public class Pelicula
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = null!;
        public bool enCines { get; set; }
        public DateTime FechaEstreno { get; set; }

        //HashSet no permite ordenar.
        public HashSet<Comentario> Comentarios { get; set; } = new HashSet<Comentario>(); //Relacion Uno a muchos

        public HashSet<Genero> Generos { get; set; } = new HashSet<Genero>(); //Muchos a muchos

        public List<PeliculaActor> PeliculaActores { get; set; } = new List<PeliculaActor>();

    }
}
