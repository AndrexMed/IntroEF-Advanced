using AutoMapper;
using IntroEF_Avanzado.Models.DTOs;
using IntroEF_Avanzado.Models.Entidades;
using PracticeAPIRestFull.Models.Entidades;

namespace IntroEF_Avanzado.Models.Utilidades
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<CrearGeneroDTO, Genero>();
            CreateMap<CrearActorDTO, Actor>();
            CreateMap<CrearPeliculaDTO, Pelicula>()
                .ForMember(ent => ent.Generos, dto => dto.MapFrom(campo => campo.Generos.Select(id => new Genero { Id = id})));

            CreateMap<PeliculaActorDTO, PeliculaActor>();

            CreateMap<CrearComentarioDTO, Comentario>();
        }
    }
}
