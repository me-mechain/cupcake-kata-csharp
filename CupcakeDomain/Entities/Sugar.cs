using CupcakeDomain.Abstractions;

namespace CupcakeDomain.Entities;

public class Sugar : WithTopping
{
    private readonly ICake _cake;
    
    public Sugar(ICake cake)
    {
        _cake = cake;
    }
    
    public string Name() => $"{_cake.Name()} {(_cake is WithTopping ? WithTopping.And : WithTopping.With)} 🍬";
}