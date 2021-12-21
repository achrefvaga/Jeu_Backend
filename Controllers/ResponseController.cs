using Microsoft.AspNetCore.Mvc;
using Test1312.Interfaces;
using Test1312.Model;
using Test1312.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Test1312.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResponseController : ControllerBase
    {
        private IResponse _resp;

        public ResponseController(IResponse resp)
        {
            _resp = resp;
        }

        [HttpGet]
        public ActionResult<List<Response>> GetResponse()
        {
            return _resp.GetResponse();
        }


        [HttpPost]
        public ActionResult<Response> CreateResponse(Response resp)
        {
            _resp.AddResponse(resp);
            return resp;
        }


        [HttpPut("{id}")]
        public ActionResult<Response> UpdateResponse(Response resp)
        {
            _resp.UpdateResponse(resp);
            return resp; ;
        }


        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _resp.DeleteResponse(id);
        }
    }
}
