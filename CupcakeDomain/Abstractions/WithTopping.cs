namespace CupcakeDomain.Abstractions;

public interface WithTopping : ICake
{
    static string And => "and";

    static string With => "with";
}