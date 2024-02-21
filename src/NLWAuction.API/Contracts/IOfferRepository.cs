using NLWAuction.API.Entities;

namespace NLWAuction.API.Contracts;

public interface IOfferRepository
{
    void Add(Offer offer);
}
