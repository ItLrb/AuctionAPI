using Microsoft.EntityFrameworkCore;
using NLWAuction.API.Contracts;
using NLWAuction.API.Entities;

namespace NLWAuction.API.Repositories.DataAcess;

public class AuctionRepository : IAuctionRepository
{
    private readonly NLWAuctionDbContext _dbcontext;
    public AuctionRepository(NLWAuctionDbContext dbcontext) => _dbcontext = dbcontext;

    public Auction? GetCurrent()
    {
        return _dbcontext
            .Auctions
            .Include(auction => auction.Items)
            .FirstOrDefault();
    }
}
