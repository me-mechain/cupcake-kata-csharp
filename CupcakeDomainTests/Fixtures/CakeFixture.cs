using CupcakeDomain.Entities;

namespace CupcakeDomainTests.Fixtures;

public static class CakeFixture
{
    public static IEnumerable<object[]> CakesWithoutToppings = new[]
    {
        new object[] {new Cupcake(), "🧁"},
        new object[] {new Cookie(), "🍪"},
    };
    
    public static IEnumerable<object[]> CakesWithToppings = new[]
    {
        new object[] {new Chocolate(new Cupcake()), "🧁 with 🍫"},
        new object[] {new Chocolate(new Cookie()), "🍪 with 🍫"},
        new object[] {new Nuts(new Cookie()), "🍪 with 🥜"},
        new object[] {new Sugar(new Cookie()), "🍪 with 🍬"},
        new object[] {new Nuts(new Sugar(new Cookie())), "🍪 with 🍬 and 🥜"},
        new object[] {new Sugar(new Nuts(new Cookie())), "🍪 with 🥜 and 🍬"},
    };

    public static IEnumerable<object[]> CakesPrices = new[]
    {
        new object[] { new Cupcake(), "1$" },
        new object[] { new Cookie(), "2$" },
        new object[] { new Chocolate(new Cupcake()), "1,1$" },
        new object[] { new Chocolate(new Cookie()), "2,1$" },
        new object[] { new Nuts(new Cookie()), "2,2$" },
        new object[] {new Nuts(new Chocolate(new Cupcake())), "1,3$"},
        new object[] {new Sugar(new Nuts(new Cookie())), "2,4$"},
    };
}