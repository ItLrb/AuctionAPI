using NLWAuction.API.Entities;

namespace NLWAuction.API.Contracts;

public interface IUserRepository
{
    bool ExistUserWithEmail(string email);
    Users GetUserByEmail(string email);
}
