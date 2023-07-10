using IntroEF_Avanzado.Models.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IntroEF_Avanzado.Models.Configuraciones
{
    public class PeliculaActorConfig : IEntityTypeConfiguration<PeliculaActor>
    {
        public void Configure(EntityTypeBuilder<PeliculaActor> builder)
        {
            builder.HasKey (pa => new { pa.ActorId, pa.PeliculaId });//PK Compuesta
        }
    }
}
