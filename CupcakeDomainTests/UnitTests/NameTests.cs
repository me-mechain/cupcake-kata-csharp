using CupcakeDomain.Abstractions;
using CupcakeDomainTests.Fixtures;
using FluentAssertions;
using Xunit;

namespace CupcakeDomainTests.UnitTests;

public class NameTests
{
    [Theory]
    [MemberData(nameof(CakeFixture.CakesWithoutToppings), MemberType = typeof(CakeFixture))]
    public void Should_return_cupcake_name_for_a_cake_without_toppings(ICake givenCake, string expectedName)
    {
        //Act
        var name = givenCake.Name();

        //Assert
        name.Should().BeEquivalentTo(expectedName);
    }

    [Theory]
    [MemberData(nameof(CakeFixture.CakesWithToppings), MemberType = typeof(CakeFixture))]
    public void Should_return_cake_with_topping_name(ICake givenCake, string expectedName)
    {
        //Act
        var name = givenCake.Name();

        //Assert
        name.Should().BeEquivalentTo(expectedName);
    }
}