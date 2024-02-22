using Microsoft.AspNetCore.Mvc;
using NLWAuction.API.Communications.Request;
using NLWAuction.API.Filters;
using NLWAuction.API.UseCases.Offers.CreateOffers;

namespace NLWAuction.API.Controllers;

[ServiceFilter(typeof(AuthenticationUserAttribute))]
public class OfferController : NLWAuctionBaseController
{
    [HttpPost]
    [Route("{itemId}")]
    public IActionResult CreateOffer(
        [FromRoute] int itemId, 
        [FromBody] RequestCreateOfferJson request,
        [FromServices] CreateOfferUseCase useCase)
    {
        var id = useCase.Execute(itemId, request);

        return Created(string.Empty, id);
    }
}
