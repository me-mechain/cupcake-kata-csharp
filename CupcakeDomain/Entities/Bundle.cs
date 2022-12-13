using CupcakeDomain.Abstractions;

namespace CupcakeDomain.Entities;

public class Bundle : ICake
{
    private readonly Dictionary<ICake, int> _cakes = new();

    public Bundle(IEnumerable<ICake> cakes)
    {
        var groupedCakes = cakes.GroupBy(cake => cake.Name()).ToList();
        foreach (var cakeGroup in groupedCakes)
        {
            _cakes.Add(cakeGroup.First(), cakeGroup.Count());
        }
    }
    
    public string Name() => $"Bundle of ({string.Join(" + ", _cakes.Select(cake => $"{cake.Value} {cake.Key.Name()}"))})";
    
    public decimal TotalPrice()
    {
        throw new NotImplementedException();
    }

    public string PrintPrice()
    {
        throw new NotImplementedException();
    }
}