using NLWAuction.API.UseCases.Auctions.GetCurrent;
using Xunit;

namespace UseCases.test.Auctions.GetCurrent;
public class GetCurrentAuctionUseCaseTest
{
    [Fact]
    public void Sucess()
    {
        //ARRANGE
        var useCase = new GetCurrentAuctionUseCase(null);
    
        //ACT
        var auction = useCase.Execute();
    
        //ASSERT
    }
}
