﻿
using FactoryMethodPattern01.Product;

namespace FactoryMethodPattern01.ConcreteProduct;

public class CartaoTitanium : CartaoCredito
{
    private readonly string _tipoCartao;
    private int _limiteCredito;
    private int _cobrancaAnual;

    public CartaoTitanium(int limiteCredito, int cobrancaAnual)
    {
        this._tipoCartao = "Titanium";
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
