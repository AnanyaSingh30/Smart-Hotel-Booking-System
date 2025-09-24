using Microsoft.AspNetCore.Mvc;
using SmartHotelManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Controllers

{

    [ApiController]

    [Route("api/[controller]")]

    public class HotelController : ControllerBase

    {

        private readonly ILogger<HotelController> _logger;
        private readonly HotelDBContext _context;

        public HotelController(HotelDBContext context, ILogger<HotelController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet("hotels")]

        public async Task<IEnumerable<Hotel>> Get()

        {

            return await _context.Hotels.ToListAsync();

        }

        [HttpPost("createHotel")]

        public async Task<IActionResult> CreateHotel([FromBody] Hotel hotel)
        {

            await _context.Hotels.AddAsync(hotel);
            await _context.SaveChangesAsync();

            return Ok(hotel);

        }

    }

}

