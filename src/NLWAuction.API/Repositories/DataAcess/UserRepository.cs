using NLWAuction.API.Contracts;
using NLWAuction.API.Entities;

namespace NLWAuction.API.Repositories.DataAcess;

public class UserRepository : IUserRepository
{
    private readonly NLWAuctionDbContext _dbcontext;
    public UserRepository(NLWAuctionDbContext dbcontext) => _dbcontext = dbcontext;

    public bool ExistUserWithEmail(string email)
    {
        return _dbcontext.Users.Any(user => user.Email.Equals(email));
    }

    public Users GetUserByEmail(string email) => _dbcontext.Users.First(user => user.Email.Equals(email));
}