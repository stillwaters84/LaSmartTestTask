using InternTestTask.Models;
using InternTestTask.Repository;
using InternTestTask.Repository.Interfaces;
using InternTestTask.Services.Interfaces;

namespace InternTestTask.Services
{
    public class PointService : IPointService
    {
        private IPointRepository _repository;
        public PointService(IPointRepository pointRepository) 
        {
            _repository = pointRepository;
        }
        public IEnumerable<Point> GetAll()
        {
            return _repository.GetAll();
        }
        public Point? Get(int id)
        {
            return _repository.Get(id);
        }
        public void Insert(Point point)
        {
            _repository.Insert(point);
            _repository.Save();
        }
        public void Update(Point point)
        {
            _repository.Update(point);
            _repository.Save();
        }
        public void Delete(int id)
        {
            _repository.Delete(id);
            _repository.Save();
        }
    }
}
