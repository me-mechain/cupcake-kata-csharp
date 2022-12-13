using CupcakeDomain.Abstractions;

namespace CupcakeDomain.Entities;

public class Cookie : ICake
{
    public string Name() => "🍪";

    public decimal TotalPrice() => 2;

    public string PrintPrice() => $"{TotalPrice()}$";
}