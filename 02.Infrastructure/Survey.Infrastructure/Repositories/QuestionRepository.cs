using Survey.Domain.Contracts.Repositories;
using Survey.Domain.Entities;
using Survey.Infrastructure.Persistence;

namespace Survey.Infrastructure.Repositories
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly AppDbContext _context;

        public QuestionRepository(AppDbContext context)
        {
            _context = context;
        }
        public void Add(Question question)
        {
            ArgumentNullException.ThrowIfNull(question);
            _context.Questions.Add(question);
        }
    }
}
