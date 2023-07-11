using AutoMapper;
using IntroEF_Avanzado.Models.Data;
using IntroEF_Avanzado.Models.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PracticeAPIRestFull.Models.Entidades;

namespace IntroEF_Avanzado.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ActorController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper mapper;

        public ActorController(ApplicationDbContext context, IMapper mapper)
        {
            this._context = context;
            this.mapper = mapper;
        }

        [HttpGet("nombre")]
        public async Task<ActionResult<IEnumerable<Actor>>> Get(string nombreActor)
        {
            //Version1
            return await _context.Actores.Where(a => a.Nombre == nombreActor).ToListAsync();
        }

        [HttpGet("nombre/v2")]
        public async Task<ActionResult<IEnumerable<Actor>>> GetV2(string nombreActor)
        {
            //Version2 - Contains
            return await _context.Actores.Where(a => a.Nombre.Contains(nombreActor)).ToListAsync();
        }

        [HttpGet("FechaNacimiento/rango")]
        public async Task<ActionResult<IEnumerable<Actor>>> GetFechaRango(DateTime inicio, DateTime fin)
        {
            return await _context.Actores
                .Where(a => a.FechaNacimiento >= inicio && a.FechaNacimiento <= fin).ToListAsync();
        }

        //[HttpGet("{id:int")]
        //public async Task<ActionResult<IEnumerable<Actor>>> GetActor(int id)
        //{
        //    var actor = await _context.Actores.FirstOrDefaultAsync(a => a.Id == id);

        //    if (actor == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(actor);
        //}

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Actor>>> Get()
        {
            return await _context.Actores.ToListAsync();
        }

        [HttpPost]
        public async Task<IActionResult> Post(CrearActorDTO crearActorDTO)
        {
            var actor = mapper.Map<Actor>(crearActorDTO);
            _context.Add(actor);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
