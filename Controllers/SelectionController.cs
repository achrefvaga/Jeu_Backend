using Microsoft.AspNetCore.Mvc;
using Test1312.Interfaces;
using Test1312.Model;
using Test1312.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Test1312.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SelectionController : ControllerBase
    {
        private ISelection _sel;

        public SelectionController(ISelection sel)
        {
            _sel = sel;
        }

        [HttpGet]
        public ActionResult<List<Selection>> GetSelection()
        {
            return _sel.GetSelection();
        }


        [HttpPost]
        public ActionResult<Selection> CreateSelection(Selection sel)
        {
            _sel.AddSelection(sel);
            return sel;
        }


        [HttpPut("{id}")]
        public ActionResult<Selection> UpdateSelection(Selection sel)
        {
            _sel.UpdateSelection(sel);
            return sel; ;
        }


        [HttpDelete("{id}")]
        public void DeleteSelection(int id)
        {
            _sel.DeleteSelection(id);
        }
    }
}
