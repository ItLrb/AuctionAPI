using Bogus;
using FluentAssertions;
using Moq;
using NLWAuction.API.Communications.Request;
using NLWAuction.API.Contracts;
using NLWAuction.API.Entities;
using NLWAuction.API.Services;
using NLWAuction.API.UseCases.Offers.CreateOffers;
using Xunit;

namespace UseCases.test.Offers.CreateOffer;
public class CreateOfferUseCaseTest
{
    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(3)]
    public void Sucess(int itemId)
    {
        //ARRANGE
        var request = new Faker<RequestCreateOfferJson>()
            .RuleFor(request => request.Price, f => f.Random.Decimal(1, 700)).Generate();

        var offerRepository = new Mock<IOfferRepository>();
        var loggedUser = new Mock<ILoggedUser>();
        loggedUser.Setup(i => i.User()).Returns(new Users());

        var useCase = new CreateOfferUseCase(loggedUser.Object, offerRepository.Object);

        //ACT
        var act = () => useCase.Execute(itemId, request);

        //ASSERT
        act.Should().NotThrow();
    }
}
