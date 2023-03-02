using Microsoft.EntityFrameworkCore;
using RazorPageLab.Context;
using System.Linq.Expressions;

namespace RazorPageLab.Repository
{
    public class RepositoryBase<T> where T : class
    {
        private readonly SchoolCourseDbContext _context;
        public DbSet<T> Set { get; set; }
        public RepositoryBase()
        {
            _context = new SchoolCourseDbContext();
            Set = _context.Set<T>();
        }

        public void Create(T entity)
        {
            Set.Add(entity);
            _context.SaveChanges();
        }
        public T Get(Expression<Func<T, bool>> predicate)
        {
            return Set.Where(predicate).FirstOrDefault();
        }

        public List<T> GetAll()
        {
            return Set.ToList();    
        }

        public bool Delete(Expression<Func<T,bool>> predicate)
        {
            Set.Remove(Get(predicate));
            return _context.SaveChanges() > 0;
        }

        public void Update(T entity)
        {
            Set.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
