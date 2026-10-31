
using Survey.Domain.Dtos;
using Survey.Domain.Entities;

namespace Survey.Domain.Contracts.Repositories
{
    public interface IVoteRepository
    {

        IReadOnlyCollection<OptionVotePercentageDto>? GetOptionVotePercentages(int questionId);
        int? GetVoteCountByOptionId(int optionId);


        IReadOnlyCollection<OptionVoteCountDto>? GetVoteCountByQuestionId(int questionId);
    }
}
