

using Microsoft.EntityFrameworkCore;
using Survey.Domain.Contracts.Repositories;
using Survey.Domain.Dtos;

using Survey.Domain.Entities;
using Survey.Domain.Enums;
using Survey.Infrastructure.Persistence;

namespace Survey.Infrastructure.Repositories
{
    public class SurveyRepository : ISurveyRepository
    {
        private readonly AppDbContext _context;

        public SurveyRepository(AppDbContext context)
        {
            _context = context;
        }
        public void Add(SurveyAgg survey)
        {
            ArgumentNullException.ThrowIfNull(survey);
            _context.Surveys.Add(survey);
        }

        public bool Delete(int surveyId)
        {
            var affectedRow = _context.Surveys
                .Where(x => x.Id == surveyId)
                .ExecuteDelete();

            return affectedRow > 0;
        }

        public IReadOnlyCollection<SurveyListDto> GetAllSurveys()
        {
            return _context.Surveys
                 .Select(x => new SurveyListDto
                 {
                     Id = x.Id,
                     Title = x.Title
                 })
                 .ToList();
        }
        public IReadOnlyCollection<SurveyListDto> GetAllActiveSurveys()
        {
            return _context.Surveys
                .Where(x => x.SurveyStatus == SurveyStatus.Active)
                .Select(x => new SurveyListDto
                {
                    Id = x.Id,
                    Title = x.Title,
                    CreatedAt = x.CreatedAt
                })
                .ToList();
        }

        public bool ExistsById(int surveyId)
        {
            return _context.Surveys.Any(x => x.Id == surveyId);
        }

        private SurveyAgg? GetById(int surveyId)
        {
            return _context.Surveys.SingleOrDefault(x => x.Id == surveyId);
        }


        public bool? HasVotesBySurveyId(int surveyId)
        {
           var result = _context.Surveys
                .Where(x => x.Id == surveyId)
                .Select(x => new
                {
                    HasVotes= x.Questions.Any(q => q.Votes.Any())
                }
                 )
                .FirstOrDefault();
               
            return result?.HasVotes;
        }
    }
}
