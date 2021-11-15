using ITHS_Lektion2_WebApi.Entities;
using ITHS_Lektion2_WebApi.Repos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ITHS_Lektion2_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InterpreterController : ControllerBase
    {
        private readonly IInterpreterRepo _interpreterRepo;

        public InterpreterController(IInterpreterRepo interpreterRepo)
        {
            _interpreterRepo = interpreterRepo;
        }

        [HttpGet]
        public IActionResult GetInterpreters()
        {
            return Ok(_interpreterRepo.GetInterpreters());
        }

        [HttpGet("{id}")]
        public IActionResult GetInterpreterByID(int id)
        {
            Interpreter interpreter = _interpreterRepo.GetInterpreterByID(id);
            
            if (interpreter == null)
            {
                return NotFound();
            }

            return Ok(interpreter);
        }


        [HttpGet("language/{id}")]
        public IActionResult GetInterpretersByLanguageID(int id)
        {
            return Ok(_interpreterRepo.GetInterpreterByLanguageID(id));
        }
    }
}
