

using Survey.Domain.Dtos;
using Survey.Domain.Entities;

namespace Survey.Application.Contracts
{
    public interface IVoteService
    {
        IReadOnlyCollection<OptionVotePercentageDto>? GetOptionVotePercentages(int questionId);

        IReadOnlyCollection<OptionVoteCountDto> GetOptionVoteCountsByQuestionId(int questionId);

        void CastVote(int personId, int questionId, int optionId);
    }
}
