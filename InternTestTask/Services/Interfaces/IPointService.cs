using InternTestTask.Models;

namespace InternTestTask.Services.Interfaces
{
    public interface IPointService
    {
        IEnumerable<Point> GetAll();
        Point? Get(int id);
        void Insert(Point point);
        void Update(Point point);
        void Delete(int id);
    }
}
