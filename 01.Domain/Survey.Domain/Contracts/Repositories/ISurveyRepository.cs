using Survey.Domain.Dtos;
using Survey.Domain.Dtos.Parcitipation;
using Survey.Domain.Entities;


namespace Survey.Domain.Contracts.Repositories
{
    public interface ISurveyRepository
    {
        void Add(SurveyAgg survey);
        bool Delete(int survetId);
        IReadOnlyCollection<SurveyListDto> GetAllSurveys();
        IReadOnlyCollection<SurveyListDto> GetAllActiveSurveys();

        bool ExistsById(int surveyId);

        bool? HasVotesBySurveyId(int surveyId);

        // -----------------------
        SurveyVotingDto? GetSurveyWithQuestions(int surveyId);
    }
}
