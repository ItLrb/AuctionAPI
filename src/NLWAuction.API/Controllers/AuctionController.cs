using Microsoft.AspNetCore.Mvc;
using NLWAuction.API.Entities;
using NLWAuction.API.UseCases.Auctions.GetCurrent;

namespace NLWAuction.API.Controllers
{
    public class AuctionController : NLWAuctionBaseController
    {
        [HttpGet]
        [ProducesResponseType(typeof(Auction), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult GetCurrentAuction([FromServices] GetCurrentAuctionUseCase useCase)
        {

            var result = useCase.Execute();

            if (result is null) return NoContent();

            return Ok(result);
        }
    }
}
