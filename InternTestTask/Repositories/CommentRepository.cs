using InternTestTask.Models;
using InternTestTask.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace InternTestTask.Repositories
{
    public class CommentRepository : ICommentRepository
    {
        private readonly InMemoryContext _context;
        public CommentRepository()
        {
            _context = new InMemoryContext();
        }
        public CommentRepository(InMemoryContext context)
        {
            _context = context;
        }
        public IEnumerable<Comment> GetAll()
        {
            return _context.Comments.ToList();
        }
        public Comment? Get(int id)
        {
            return _context.Comments.Find(id);
        }
        public void Insert(Comment comment)
        {
            _context.Comments.Add(comment);
        }
        public void Update(Comment comment)
        {
            _context.Entry(comment).State = EntityState.Modified;
        }
        public void Delete(int id)
        {
            var deletingComment = _context.Comments.Find(id);
            if (deletingComment != null)
            {
                _context.Comments.Remove(deletingComment);
            }
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
