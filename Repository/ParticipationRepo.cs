using Test1312.DBContext;
using Test1312.Interfaces;
using Test1312.Model;

namespace Test1312.Repository
{
    public class ParticipationRepo : IParticipation
    {
            private readonly DBContextTest _context;

            public ParticipationRepo(DBContextTest context)
            {
                _context = context;
            }
        public Participation AddParticipation(Participation parItem)
        {
            _context.Add(parItem);
            _context.SaveChanges();

            return parItem;
        }

        public void DeleteParticipation(int id)
        {
            var participation = _context.Participations.FirstOrDefault(u => u.Idparticipation == id);
            _context.Participations.Remove(participation);
            _context.SaveChanges();
        }

       

        public List<Participation> GetParticipation()
        {
            return _context.Participations.ToList();
        }

        public Participation UpdateParticipation(Participation parItem)
        {
            _context.Update(parItem);
            _context.SaveChanges();
            return parItem;
        }
    }
}
