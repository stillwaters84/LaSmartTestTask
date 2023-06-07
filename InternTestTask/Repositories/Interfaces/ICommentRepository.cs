using InternTestTask.Models;

namespace InternTestTask.Repositories.Interfaces
{
    public interface ICommentRepository
    {
        IEnumerable<Comment> GetAll();
        Comment? Get(int id);
        void Insert(Comment comment);
        void Update(Comment comment);
        void Delete(int id);
        void Save();
    }
}
