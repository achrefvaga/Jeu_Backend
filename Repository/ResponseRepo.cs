using Test1312.DBContext;
using Test1312.Interfaces;
using Test1312.Model;

namespace Test1312.Repository
{
    public class ResponseRepo : IResponse
    {

        private readonly DBContextTest _context;

        public ResponseRepo(DBContextTest context)
        {
            _context = context;
        }
        public Response AddResponse(Response respItem)
        {
            _context.Add(respItem);
            _context.SaveChanges();

            return respItem;
        }

        public void DeleteResponse(int id)
        {
            var response = _context.Responses.FirstOrDefault(u => u.responseId == id);
            _context.Responses.Remove(response);
            _context.SaveChanges();
        }

        public List<Response> GetResponse()
        {
            return _context.Responses.ToList();
        }

        public Response UpdateResponse(Response respItem)
        {
            _context.Update(respItem);
            _context.SaveChanges();
            return respItem;
        }
    }
}
