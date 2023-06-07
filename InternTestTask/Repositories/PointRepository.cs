using InternTestTask.Models;
using InternTestTask.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace InternTestTask.Repository
{
    public class PointRepository : IPointRepository
    {
        private readonly InMemoryContext _context;
        public PointRepository()
        {
            _context = new InMemoryContext();
        }
        public PointRepository(InMemoryContext context)
        {
            _context = context;
        }
        public IEnumerable<Point> GetAll()
        {
            return _context.Points.ToList();
        }
        public Point? Get(int id)
        {
            return _context.Points.Find(id);
        }
        public void Insert(Point point)
        {
            _context.Points.Add(point);
        }
        public void Update(Point point)
        {
            _context.Entry(point).State = EntityState.Modified;
        }
        public void Delete(int id)
        {
            var deletingPoint = _context.Points.Find(id);
            if (deletingPoint != null)
            {
                _context.Points.Remove(deletingPoint);
            }
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
