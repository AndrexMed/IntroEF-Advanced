using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PracticeAPIRestFull.Models.Entidades;
using System.Reflection.Emit;

namespace IntroEF_Avanzado.Models.Configuraciones
{
    public class PeliculaConfig : IEntityTypeConfiguration<Pelicula>
    {
        public void Configure(EntityTypeBuilder<Pelicula> builder)
        {
            builder.Property(p => p.FechaEstreno).HasColumnType("date");
        }
    }
}
