using NLWAuction.API.Contracts;
using NLWAuction.API.Entities;

namespace NLWAuction.API.Repositories.DataAcess;

public class OfferRepository : IOfferRepository
{
    private readonly NLWAuctionDbContext _dbcontext;
    public OfferRepository(NLWAuctionDbContext dbcontext) => _dbcontext = dbcontext;
    public void Add(Offer offer)
    {
        _dbcontext.Offers.Add(offer);

        _dbcontext.SaveChanges();
    }
}
