

namespace Survey.Domain.Dtos.Parcitipation
{
    public class SurveyVotingDto
    {
        public int SurveyId { get; set; }
        public string SurveyTitle { get; set; } = string.Empty;
        public List<QuestionDto> Questions { get; set; } = [];

    }
}
