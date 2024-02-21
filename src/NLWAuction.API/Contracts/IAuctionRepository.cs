using NLWAuction.API.Entities;

namespace NLWAuction.API.Contracts;

public interface IAuctionRepository
{
    Auction? GetCurrent();
}
