using Microsoft.AspNetCore.Mvc;
using Test1312.Interfaces;
using Test1312.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Test1312.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParticipationController : ControllerBase
    {
        private IParticipation _part;

            public ParticipationController(IParticipation part)
        {
               _part = part;
        }
        [HttpGet]
        public ActionResult<List<Participation>> GetParticipation()
        {
            return _part.GetParticipation();
        }


        [HttpPost]
        public ActionResult<Participation> CreateParticipation(Participation part)
        {
            _part.AddParticipation(part);
            return part;
        }


        [HttpPut("{id}")]
        public ActionResult<Participation> UpadateParticipation(Participation part)
        {
            _part.UpdateParticipation(part);
            return part; ;
        }


        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _part.DeleteParticipation(id);
        }
    }
}
