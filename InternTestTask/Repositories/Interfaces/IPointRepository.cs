using InternTestTask.Models;

namespace InternTestTask.Repository.Interfaces
{
    public interface IPointRepository
    {
        IEnumerable<Point> GetAll();
        Point? Get(int PointId);
        void Insert(Point point);
        void Update(Point point);
        void Delete(int PointId);
        void Save();
    }
}
