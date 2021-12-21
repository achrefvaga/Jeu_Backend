using Test1312.DBContext;
using Test1312.Interfaces;
using Test1312.Model;

namespace Test1312.Repository
{
    public class SelectionRepo : ISelection
    {
        private readonly DBContextTest _context;

        public SelectionRepo(DBContextTest context)
        {
            _context = context;
        }
        public Selection AddSelection(Selection selItem)
        {
            _context.Add(selItem);
            _context.SaveChanges();

            return selItem;
        }

        public void DeleteSelection(int id)
        {
            var selection = _context.Selections.FirstOrDefault(u => u.selectionid == id);
            _context.Selections.Remove(selection);
            _context.SaveChanges();
        }

        public List<Selection> GetSelection()
        {
            return _context.Selections.ToList();
        }

        public Selection UpdateSelection(Selection selItem)
        {
            _context.Update(selItem);
            _context.SaveChanges();
            return selItem;
        }
    }
}
