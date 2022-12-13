using CupcakeDomain.Abstractions;
using CupcakeDomain.Entities;

namespace CupcakeDomainTests.Fixtures;

public static class BundleFixture
{
    public static IEnumerable<object[]> BundlesDescriptions = new[]
    {
        new object[] { new List<ICake> {new Cupcake(), new Cookie() }, "1 🧁 + 1 🍪" },
        new object[] { new List<ICake> {new Cookie(), new Cookie() }, "2 🍪" },
        new object[] { 
            new List<ICake> { new Cupcake(), new Cupcake(), new Cookie(), new Chocolate(new Cookie()) }, 
            "2 🧁 + 1 🍪 + 1 🍪 with 🍫" 
        },
        new object[] { 
            new List<ICake>{ new Cupcake(), new Cupcake(), new Cookie(), new Nuts(new Chocolate(new Cookie())) }, 
            "2 🧁 + 1 🍪 + 1 🍪 with 🍫 and 🥜" 
        },
        new object[] { 
            new List<ICake>{ new Bundle(new List<ICake>{new Cupcake(), new Cupcake()}), new Cupcake(), new Cookie(), new Nuts(new Chocolate(new Cookie())) }, 
            "1 Bundle of (2 🧁) + 1 🧁 + 1 🍪 + 1 🍪 with 🍫 and 🥜" 
        },
    };
    
    public static IEnumerable<object[]> BundlesNames = new[]
    {
        new object[] { new List<ICake> {new Cupcake(), new Cookie() }, "Bundle of (1 🧁 + 1 🍪)" },
        new object[] { new List<ICake> {new Cookie(), new Cookie() }, "Bundle of (2 🍪)" },
        new object[] { 
            new List<ICake> { new Cupcake(), new Cupcake(), new Cookie(), new Chocolate(new Cookie()) }, 
            "Bundle of (2 🧁 + 1 🍪 + 1 🍪 with 🍫)" 
        },
        new object[] { 
            new List<ICake>{ new Cupcake(), new Cupcake(), new Cookie(), new Nuts(new Chocolate(new Cookie())) }, 
            "Bundle of (2 🧁 + 1 🍪 + 1 🍪 with 🍫 and 🥜)" 
        },
        new object[] { 
            new List<ICake>{ new Bundle(new List<ICake>{new Cupcake(), new Cupcake()}), new Cupcake(), new Cookie(), new Nuts(new Chocolate(new Cookie())) }, 
            "Bundle of (1 Bundle of (2 🧁) + 1 🧁 + 1 🍪 + 1 🍪 with 🍫 and 🥜)" 
        },
    };
    
    public static IEnumerable<object[]> BundlesPrices = new[]
    {
        new object[] { new List<ICake> {new Cupcake(), new Cookie() }, "2,7$" },
        new object[] { new List<ICake> {new Cookie(), new Cookie() }, "3,6$" },
        new object[] { 
            new List<ICake> { new Cupcake(), new Cupcake(), new Cookie(), new Chocolate(new Cookie()) }, 
            "5,49$" 
        },
        new object[] { 
            new List<ICake>{ new Cupcake(), new Cupcake(), new Cookie(), new Nuts(new Chocolate(new Cookie())) }, 
            "5,67$" 
        },
        new object[] { 
            new List<ICake>{ new Bundle(new List<ICake>{new Cupcake(), new Cupcake()}), new Cupcake(), new Cookie(), new Nuts(new Chocolate(new Cookie())) }, 
            "6,39$" 
        },
    };
}