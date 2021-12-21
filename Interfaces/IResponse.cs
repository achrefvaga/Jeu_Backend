using Test1312.Model;

namespace Test1312.Interfaces
{
    public interface IResponse
    {

        public List<Response> GetResponse();

        public Response AddResponse(Response respItem);

        public Response UpdateResponse(Response respItem);

        public void DeleteResponse(int id);
    }
}
