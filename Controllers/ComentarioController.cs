using AutoMapper;
using IntroEF_Avanzado.Models.Data;
using IntroEF_Avanzado.Models.DTOs;
using Microsoft.AspNetCore.Mvc;
using PracticeAPIRestFull.Models.Entidades;

namespace IntroEF_Avanzado.Controllers
{
    [ApiController]
    [Route("api/peliculas/{peliculaId:int}/comentarios")]
    public class ComentarioController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper mapper;

        public ComentarioController(ApplicationDbContext context,
                                    IMapper mapper)
        {
            this._context = context;
            this.mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> Post(int peliculaId, CrearComentarioDTO crearComentarioDTO)
        {
            var comentario = mapper.Map<Comentario>(crearComentarioDTO);
            comentario.PeliculaId = peliculaId;
            _context.Add(comentario);
            await _context.SaveChangesAsync();
            return Ok();    
        }
    }
}
