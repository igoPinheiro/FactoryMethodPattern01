using FactoryMethodPattern01.Product;

namespace FactoryMethodPattern01.ConcreteProduct;

internal class CartaoBlack : CartaoCredito
{
    private readonly string _tipoCartao;
    private int _limiteCredito;
    private int _cobrancaAnual;

    public CartaoBlack(int limiteCredito, int cobrancaAnual)
    {
        this._tipoCartao = "Black";
        this._limiteCredito = limiteCredito;
        this._cobrancaAnual = cobrancaAnual;
    }

    public override string TipoConta
    {
        get { return _tipoCartao; }
    }
    public override int LimiteCredito
    {

        get { return _limiteCredito; }
        set { _limiteCredito = value; }
    }
    public override int CobrancaAnual
    {
        get { return _cobrancaAnual; }
        set { _cobrancaAnual = value; }
    }
}
