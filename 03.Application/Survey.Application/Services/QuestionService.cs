using Survey.Application.Contracts;
using Survey.Application.Exceptions;
using Survey.Domain.Contracts;
using Survey.Domain.Contracts.Repositories;
using Survey.Domain.Entities;


namespace Survey.Application.Services
{
    public class QuestionService : IQuestionService
    {

        private readonly ISurveyRepository _surveyRepo;
        private readonly IQuestionRepository _questionRepo;
        private readonly IUnitOfWork _unitOfWork;

        public QuestionService(ISurveyRepository surveyRepo, IQuestionRepository questionRepo, IUnitOfWork unitOfWork)
        {
            _surveyRepo = surveyRepo;
            _questionRepo = questionRepo;
            _unitOfWork = unitOfWork;
        }
        public int CreateQuestion(int surveyId, string text, IReadOnlyCollection<string> optionTexts)
        {
            if(!_surveyRepo.ExistsById(surveyId))
                throw new NotFoundException("Survey not found.");

            var options = optionTexts
                .Select(x => new Option(x))
                .ToList();
            var question = new Question(text, surveyId, options);

            _questionRepo.Add(question);

            _unitOfWork.SaveChanges();

            return question.Id;
        }
    }
}
