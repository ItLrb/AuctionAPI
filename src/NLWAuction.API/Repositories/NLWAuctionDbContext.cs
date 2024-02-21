using Microsoft.EntityFrameworkCore;
using NLWAuction.API.Entities;

namespace NLWAuction.API.Repositories;

public class NLWAuctionDbContext : DbContext
{
    public NLWAuctionDbContext(DbContextOptions options) : base(options)
    {

    }

    public DbSet<Auction> Auctions { get; set; }
    public DbSet<Users> Users { get; set; }
    public DbSet<Offer> Offers { get; set; }

    internal Users GetUserByEmail(string email)
    {
        throw new NotImplementedException();
    }
}
