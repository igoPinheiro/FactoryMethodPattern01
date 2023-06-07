using FactoryMethodPattern01.ConcreteProduct;
using FactoryMethodPattern01.Creator;
using FactoryMethodPattern01.Product;

namespace FactoryMethodPattern01.ConcreteCreator;

public class BlackFactory : CartaoFactory
{
    private int _limiteCredito;
    private int _cobrancaAnual;

    public BlackFactory(int limiteCredito, int cobrancaAnual)
    {
        this._limiteCredito = limiteCredito;
        this._cobrancaAnual = cobrancaAnual;
    }
    public override CartaoCredito BuscarCartaoCredito()
    {
        return new CartaoBlack(this._limiteCredito, this._cobrancaAnual);
    }
}
