using P1_IRepository;
using Microsoft.AspNetCore.Mvc;
using P1_Data.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RPG_P1_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorController : ControllerBase
    {
        //fields
        private readonly IRepository _Repo;
        private readonly ILogger<ActorController> _Logger;


        //constructor

        public ActorController(IRepository repo, ILogger<ActorController> logger)
        {
            _Logger = logger;
            _Repo = repo;
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Actor>>> GetActor()
        {
            IEnumerable<Actor> actors; 
            try
            {   actors = await _Repo.GetActorsAsync();   }
            catch (Exception ex)
            {
                _Logger.LogError(ex, ex.Message);
                return StatusCode(500);
            }
           
            return actors.ToList();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
