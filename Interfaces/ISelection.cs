
using Test1312.Model;

namespace Test1312.Interfaces
{
    public interface ISelection
    {
        public List<Selection> GetSelection();

        public Selection AddSelection(Selection selItem);

        public Selection UpdateSelection(Selection selItem);

        public void DeleteSelection(int id);
    }
}
