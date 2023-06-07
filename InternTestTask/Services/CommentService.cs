using InternTestTask.Models;
using InternTestTask.Repositories.Interfaces;
using InternTestTask.Repository.Interfaces;
using InternTestTask.Services.Interfaces;

namespace InternTestTask.Services
{
    public class CommentService : ICommentService
    {
        private ICommentRepository _repository;
        public CommentService(ICommentRepository commentRepository)
        {
            _repository = commentRepository;
        }
        public IEnumerable<Comment> GetAll()
        {
            return _repository.GetAll();
        }
        public Comment? Get(int id)
        {
            return _repository.Get(id);
        }
        public void Insert(Comment comment)
        {
            _repository.Insert(comment);
            _repository.Save();
        }
        public void Update(Comment comment)
        {
            _repository.Update(comment);
            _repository.Save();
        }
        public void Delete(int id)
        {
            _repository.Delete(id);
            _repository.Save();
        }
    }
}
