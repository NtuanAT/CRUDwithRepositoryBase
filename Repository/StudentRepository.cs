using RazorPageLab.Models;

namespace RazorPageLab.Repository
{
    public class StudentRepository :RepositoryBase<Student>
    {
        public Student GetByName(string name)
        {
            return Get(s=>s.FirstName.Equals(name));
        }
    }
}
