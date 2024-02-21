using NLWAuction.API.Communications.Request;
using NLWAuction.API.Contracts;
using NLWAuction.API.Entities;
using NLWAuction.API.Services;

namespace NLWAuction.API.UseCases.Offers.CreateOffers;

public class CreateOffersUseCase
{
    private readonly LoggedUser _loggedUser;
    private readonly IOfferRepository _repository;

    public CreateOffersUseCase(LoggedUser loggedUser, IOfferRepository repository)
    {
        _loggedUser = loggedUser;
        _repository = repository;
    }

    public int Execute(int itemId, RequestCreateOfferJson request) 
    { 

        var user = _loggedUser.User();

        var offer = new Offer
        {
            CreatedOn = DateTime.Now,
            ItemId = itemId,
            Price = request.Price,
            UserId = user.Id
        };

        _repository.Add(offer);    
    
        return offer.Id;
    }
}
