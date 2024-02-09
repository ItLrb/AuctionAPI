using Microsoft.AspNetCore.Mvc;
using NLWAuction.API.Communications.Request;
using NLWAuction.API.Filters;

namespace NLWAuction.API.Controllers;

[ServiceFilter(typeof(AuthenticationUserAttribute))]
public class OfferController : NLWAuctionBaseController
{
    [HttpPost]
    [Route("{itemId}")]
    public IActionResult CreateOffer([FromRoute] int itemId, [FromBody] RequestCreateOfferJson request)
    {
        return Created();
    }
}
