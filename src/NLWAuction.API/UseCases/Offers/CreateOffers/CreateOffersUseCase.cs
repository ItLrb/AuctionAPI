using NLWAuction.API.Communications.Request;
using NLWAuction.API.Entities;
using NLWAuction.API.Repositories;
using NLWAuction.API.Services;

namespace NLWAuction.API.UseCases.Offers.CreateOffers;

public class CreateOffersUseCase
{
    private readonly LoggedUser _loggedUser;

    public CreateOffersUseCase(LoggedUser loggedUser) => _loggedUser = loggedUser;

    public int Execute(int itemId, RequestCreateOfferJson request) 
    { 
        var repository = new NLWAuctionDbContext();

        var user = _loggedUser.User();

        var offer = new Offer
        {
            CreatedOn = DateTime.Now,
            ItemId = itemId,
            Price = request.Price,
            UserId = user.Id
        };

        repository.Offers.Add(offer);

        repository.SaveChanges(); 
    
        return offer.Id;
    }
}
