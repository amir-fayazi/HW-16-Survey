using Survey.Domain.Entities;

namespace Survey.Domain.Contracts.Repositories
{
    public interface IPersonRepository
    {
        LoginResultDto GetByUsername(string username);

    }
}
