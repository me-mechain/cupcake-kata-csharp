using CupcakeDomain.Abstractions;

namespace CupcakeDomain.Entities;

public class Nuts : WithTopping
{
    private readonly ICake _cake;
    
    public Nuts(ICake cake)
    {
        _cake = cake;
    }
    
    public string Name() => $"{_cake.Name()} {(_cake is WithTopping ? WithTopping.And : WithTopping.With)} 🥜";
    public decimal TotalPrice() => _cake.TotalPrice() + (decimal)0.2;

    public string PrintPrice() => $"{TotalPrice()}$";
}