using IntroEF_Avanzado.Models.Entidades;
using IntroEF_Avanzado.Models.Seeding;
using Microsoft.EntityFrameworkCore;
using PracticeAPIRestFull.Models.Entidades;
using System.Reflection;

namespace IntroEF_Avanzado.Models.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Genero> Generos => Set<Genero>();
        public DbSet<Actor> Actores => Set<Actor>();
        public DbSet<Pelicula> Peliculas => Set<Pelicula>();
        public DbSet<Comentario> Comentarios => Set<Comentario>();
        public DbSet<PeliculaActor> PeliculaActores => Set<PeliculaActor>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            SeddingInicial.Seed(modelBuilder);

        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            base.ConfigureConventions(configurationBuilder);

            configurationBuilder.Properties<string>().HaveMaxLength(100);
        }
    }
}
