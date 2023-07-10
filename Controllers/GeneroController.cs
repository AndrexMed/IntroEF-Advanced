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
    public class GeneroController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper mapper;

        public GeneroController(ApplicationDbContext context,
                                IMapper mapper)
        {
            this._context = context;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Genero>>> Get()
        {
            return await _context.Generos.ToListAsync();
        }

        [HttpPost]
        public async Task<IActionResult> Post(CrearGeneroDTO generoDTO)
        {
            //var genero = new Genero
            //{
            //    Nombre = generoDTO.Nombre
            //};
            var genero = mapper.Map<Genero>(generoDTO); //Mapeo automatico

            _context.Add(genero);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPost("CrearVarios")]
        public async Task<IActionResult> Post(CrearGeneroDTO[] generoDTO)
        {
            var generos = mapper.Map<Genero[]>(generoDTO);
            _context.AddRange(generos);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
