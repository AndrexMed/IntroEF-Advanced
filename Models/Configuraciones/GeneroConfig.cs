using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PracticeAPIRestFull.Models.Entidades;

namespace IntroEF_Avanzado.Models.Configuraciones
{
    public class GeneroConfig : IEntityTypeConfiguration<Genero>
    {
        public void Configure(EntityTypeBuilder<Genero> builder)
        {
            var CienciaFiccion = new Genero { Id = 5, Nombre = "Ciencia Ficcion" };
            var Animacion = new Genero { Id = 6, Nombre = "Animacion" };

            builder.HasData(CienciaFiccion, Animacion);
        }
    }
}
