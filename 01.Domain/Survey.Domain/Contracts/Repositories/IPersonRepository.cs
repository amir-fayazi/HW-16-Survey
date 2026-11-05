using Survey.Domain.Entities;
using Survey.Domain.Dtos;

namespace Survey.Domain.Contracts.Repositories
{
    public interface IPersonRepository
    {
        LoginResultDto GetByUsername(string username);

    }
}
