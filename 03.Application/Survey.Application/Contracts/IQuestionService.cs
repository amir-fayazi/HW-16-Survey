

namespace Survey.Application.Contracts
{
    public interface IQuestionService
    {
        int CreateQuestion(int surveyId, string text, IReadOnlyCollection<string> optionTexts);
    }
}
