

using Survey.Application.Dtos;

namespace Survey.Application.Contracts
{
    public interface ISurveyParticipation
    {

        void ParticipateInSurvey(int surveyId, int personId);
    }
}
