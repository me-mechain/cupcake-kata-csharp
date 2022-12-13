using CupcakeDomain.Abstractions;

namespace CupcakeDomain.Entities;

public class Cupcake : ICake
{
    public string Name() => "🧁";
    public decimal TotalPrice() => 1;

    public string PrintPrice() => $"{TotalPrice()}$";
}