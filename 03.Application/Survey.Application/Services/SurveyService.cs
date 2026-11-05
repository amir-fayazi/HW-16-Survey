

using Survey.Application.Contracts;
using Survey.Application.Exceptions;
using Survey.Domain.Contracts;
using Survey.Domain.Contracts.Repositories;
using Survey.Domain.Dtos;
using Survey.Domain.Dtos.Parcitipation;
using Survey.Domain.Entities;
using Survey.Domain.Enums;

namespace Survey.Application.Services
{


    public class SurveyService : ISurveyService
    {
        private readonly ISurveyRepository _surveyRepo;
        private readonly IQuestionRepository _questionRepo;
        private readonly ISurveyParticipationRepository _surveyParticipationRepo;
        private readonly IUnitOfWork _unitOfWork;
        public SurveyService(ISurveyRepository surveyRepo, IUnitOfWork unitOfWork, ISurveyParticipationRepository surveyParticipationRepo)
        {
            _surveyRepo = surveyRepo;
            _unitOfWork = unitOfWork;
            _surveyParticipationRepo = surveyParticipationRepo;
        }


        public int CreateSurvey(string title, SurveyStatus surveyStatus)
        {
            var survey = new SurveyAgg(title, surveyStatus);

            _surveyRepo.Add(survey);

            _unitOfWork.SaveChanges();

            return survey.Id;
        }


        public void DeleteSurvey(int surveyId)
        {
            var hasParticipation = _surveyRepo.HasVotesBySurveyId(surveyId);

            if (hasParticipation is null)
                throw new NotFoundException("Survey not found.");

            if (hasParticipation is false)
                throw new BusinessLogicException("Survey has no participation.");


            if (!_surveyRepo.Delete(surveyId))
                throw new NotFoundException("Survey not found.");
            
        }


        public IReadOnlyCollection<SurveyListDto> GetActiveSurveys()
        {
            return _surveyRepo.GetAllActiveSurveys();
        }

        public int GetParticipantCountBySurveyId(int surveyId)
        {
            var count = _surveyParticipationRepo.GetParticipantCountBySurveyId(surveyId);

            if (count is null)
                throw new NotFoundException("Survey not found");

            return count.Value;
        }

        /*        public IReadOnlyCollection<SurveyParticipantDto> GetParticipantsBySurveyId(int surveyId)
                {
                    var participants = _surveyParticipationRepo.GetParticipantsBySurveyId(surveyId);
                    if (participants is null)
                        throw new NotFoundException("Survey not found");

                    return participants;
                }*/



        public SurveyVotingDto GetSurveyForVoting(int surveyId)
        {
            var surveyVoting = _surveyRepo.GetSurveyWithQuestions(surveyId);

            if (surveyVoting is null)
                throw new NotFoundException("Survey not found");

            return surveyVoting;
        }
    }
}
