using CupcakeDomain.Abstractions;

namespace CupcakeDomain.Entities;

public class Cupcake : ICake
{
    public string Name() => "🧁";
}