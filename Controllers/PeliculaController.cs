using AutoMapper;
using IntroEF_Avanzado.Models.Data;
using IntroEF_Avanzado.Models.DTOs;
using IntroEF_Avanzado.Models.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PracticeAPIRestFull.Models.Entidades;

namespace IntroEF_Avanzado.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PeliculaController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper mapper;

        public PeliculaController(ApplicationDbContext context, IMapper mapper)
        {
            this._context = context;
            this.mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> Post(CrearPeliculaDTO crearPeliculaDTO)
        {
            var pelicula = mapper.Map<Pelicula>(crearPeliculaDTO);

            if (pelicula.Generos is not null)
            {
                foreach (var genero in pelicula.Generos)
                {
                    _context.Entry(genero).State = EntityState.Unchanged;
                }
            }
            if(pelicula.PeliculaActores is not null)
            {
                for (int i = 0; i < pelicula.PeliculaActores.Count; i++)
                {
                    pelicula.PeliculaActores[i].Orden = i + 1;
                }
            }

            _context.Add(pelicula);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
