
using Survey.Application.Dtos;
using Survey.Domain.Entities;

namespace Survey.Application.Contracts
{
    public interface IAuthenticationService
    {
        LoginResultDto Login(string username, string password);

    }
}
