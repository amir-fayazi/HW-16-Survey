using Survey.Application.Contracts;
using Survey.Application.Exceptions;
using Survey.Domain.Contracts;
using Survey.Domain.Contracts.Repositories;
using Survey.Domain.Dtos;


namespace Survey.Application.Services
{
    public class VoteService : IVoteService
    {
        //private readonly ISurveyRepository _surveyRepo;
        //private readonly IQuestionRepository _questionRepo;
        //private readonly IUnitOfWork _unitOfWork;
        private readonly IVoteRepository _voteRepo;

        //public QuestionService(ISurveyRepository surveyRepo, IQuestionRepository questionRepo, IUnitOfWork unitOfWork)
        //{
        //    _surveyRepo = surveyRepo;
        //    _questionRepo = questionRepo;
        //    _unitOfWork = unitOfWork;
        //}

        public VoteService(IVoteRepository voteRepo)
        {
             _voteRepo = voteRepo;
        }
        public void CastVote(int personId, int questionId, int optionId)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyCollection<OptionVoteCountDto> GetOptionVoteCountsByQuestionId(int questionId)
        {

           var result = _voteRepo.GetVoteCountByQuestionId(questionId);

            if (result is null)
                throw new NotFoundException("Question not found");

            return result;

        }

        public IReadOnlyCollection<OptionVotePercentageDto>? GetOptionVotePercentages(int questionId)
        {
            throw new NotImplementedException();
        }
    }
}
