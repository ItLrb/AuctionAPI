using Microsoft.EntityFrameworkCore;
using NLWAuction.API.Entities;
using NLWAuction.API.Repositories;

namespace NLWAuction.API.UseCases.Auctions.GetCurrent;

public class GetCurrentAuctionUseCase
{
    public Auction? Execute()
    {
        var repository = new NLWAuctionDbContext();

        return repository
            .Auctions
            .Include(auction => auction.Items)
            .FirstOrDefault();
    }
}
