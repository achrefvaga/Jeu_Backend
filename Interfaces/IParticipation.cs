using Test1312.Model;

namespace Test1312.Interfaces
{
    public interface IParticipation
    {
        public List<Participation> GetParticipation();

        public Participation AddParticipation(Participation parItem);

        public Participation UpdateParticipation(Participation parItem);

        public void DeleteParticipation(int id);
    }
}
