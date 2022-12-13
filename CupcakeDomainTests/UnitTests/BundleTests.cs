using CupcakeDomain.Abstractions;
using CupcakeDomain.Entities;
using CupcakeDomainTests.Fixtures;
using FluentAssertions;
using Xunit;

namespace CupcakeDomainTests.UnitTests;

public class BundleTests
{
    [Theory]
    [MemberData(nameof(BundleFixture.BundlesDescriptions), MemberType = typeof(BundleFixture))]
    public void Should_return_bundle_description(List<ICake> givenBundleContent, string expectedDescription)
    {
        //Arrange
        var bundle = new Bundle(givenBundleContent);
        
        //Act
        var description = bundle.Description();
        
        //Assert
        description.Should().BeEquivalentTo(expectedDescription);
    }

    [Theory]
    [MemberData(nameof(BundleFixture.BundlesNames), MemberType = typeof(BundleFixture))]
    public void Should_return_bundle_name(List<ICake> givenBundleContent, string expectedName)
    {
        //Arrange
        var bundle = new Bundle(givenBundleContent);
        
        //Act
        var name = bundle.Name();
        
        //Assert
        name.Should().BeEquivalentTo(expectedName);
    }
}