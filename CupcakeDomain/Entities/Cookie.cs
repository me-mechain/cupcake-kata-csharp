using CupcakeDomain.Abstractions;

namespace CupcakeDomain.Entities;

public class Cookie : ICake
{
    public string Name() => "🍪";
}