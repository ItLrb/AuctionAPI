using NLWAuction.API.Contracts;
using NLWAuction.API.Entities;

namespace NLWAuction.API.UseCases.Auctions.GetCurrent;

public class GetCurrentAuctionUseCase
{
    private readonly IAuctionRepository _repository;

    public GetCurrentAuctionUseCase(IAuctionRepository repository) => _repository = repository;
    public Auction? Execute() => _repository.GetCurrent();

}
