
using FactoryMethodPattern01.Product;

namespace FactoryMethodPattern01.Creator;

public abstract class CartaoFactory
{
    public abstract CartaoCredito BuscarCartaoCredito();
}
