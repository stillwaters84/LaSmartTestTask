using InternTestTask.Models;

namespace InternTestTask.Services.Interfaces
{
    public interface ICommentService
    {
        IEnumerable<Comment> GetAll();
        Comment? Get(int id);
        void Insert(Comment comment);
        void Update(Comment comment);
        void Delete(int id);
    }
}
