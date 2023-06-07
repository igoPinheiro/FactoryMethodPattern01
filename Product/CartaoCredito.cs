namespace FactoryMethodPattern01.Product;

public abstract class CartaoCredito
{
    public abstract string TipoConta { get;  } 
    public abstract int LimiteCredito { get; set; }
    public abstract int CobrancaAnual { get; set; }
}
