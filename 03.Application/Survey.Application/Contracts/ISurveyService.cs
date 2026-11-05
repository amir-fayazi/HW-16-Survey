

using Survey.Domain.Dtos;
using Survey.Domain.Entities;
using Survey.Domain.Enums;

namespace Survey.Application.Contracts
{
    public interface ISurveyService
    {
        int CreateSurvey(string title, SurveyStatus status);

        //IReadOnlyCollection<SurveyParticipantDto> GetParticipantsBySurveyId(int surveyId);
        int GetParticipantCountBySurveyId(int surveyId);

        void DeleteSurvey(int surveyId);

        IReadOnlyCollection<SurveyListDto> GetActiveSurveys();


    }
}
