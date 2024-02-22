using NLWAuction.API.Communications.Request;
using NLWAuction.API.Contracts;
using NLWAuction.API.Entities;
using NLWAuction.API.Services;

namespace NLWAuction.API.UseCases.Offers.CreateOffers;

public class CreateOfferUseCase
{
    private readonly ILoggedUser _loggedUser;
    private readonly IOfferRepository _repository;
    private ILoggedUser object1;
    private IOfferRepository object2;

    public CreateOfferUseCase(LoggedUser loggedUser, IOfferRepository repository)
    {
        _loggedUser = loggedUser;
        _repository = repository;
    }

    public CreateOfferUseCase(ILoggedUser object1, IOfferRepository object2)
    {
        this.object1 = object1;
        this.object2 = object2;
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
