using CupcakeDomain.Abstractions;
using CupcakeDomainTests.Fixtures;
using FluentAssertions;
using Xunit;

namespace CupcakeDomainTests.UnitTests;

public class PriceTests
{
    [Theory]
    [MemberData(nameof(CakeFixture.CakesPrices), MemberType = typeof(CakeFixture))]
    public void Should_return_cake_price(ICake givenCake, string expectedPrice)
    {
        //Act
        var price = givenCake.PrintPrice();

        //Assert
        price.Should().BeEquivalentTo(expectedPrice);
    }
}