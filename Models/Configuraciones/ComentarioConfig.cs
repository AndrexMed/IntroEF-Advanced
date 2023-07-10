using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PracticeAPIRestFull.Models.Entidades;

namespace IntroEF_Avanzado.Models.Configuraciones
{
    public class ComentarioConfig : IEntityTypeConfiguration<Comentario>
    {
        public void Configure(EntityTypeBuilder<Comentario> builder)
        {
            builder.Property(c => c.Contenido).HasMaxLength(500);
        }
    }
}
