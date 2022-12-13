namespace CupcakeDomain.Abstractions;

public interface ICake
{ 
    string Name();

    decimal TotalPrice();

    string PrintPrice();
}