// See https://aka.ms/new-console-template for more information
using FactoryMethodPattern01.ConcreteCreator;
using FactoryMethodPattern01.Creator;
using FactoryMethodPattern01.Product;

CartaoFactory cartaoFactory = null;
Console.Write("Digite o tipo de cartão que gostaria de obter:");
string console = Console.ReadLine();

switch (console.ToLower())
{
    case "black":
        cartaoFactory = new BlackFactory(50000, 0);
        break;
    case "titanium":
        cartaoFactory = new TitaniumFactory(100000, 500);
        break;
    case "platinum":
        cartaoFactory = new PlatinumFactory(500000, 1000);
        break;
    default:
        break;
}

CartaoCredito cartaoCredito = cartaoFactory.BuscarCartaoCredito();
Console.WriteLine("\nOs detalhes do seu cartão estão abaixo: \n");
Console.WriteLine("Tipo do Cartao: {0}\nCrédito limite: {1}\nCobrança Anual: {2}",
   cartaoCredito.TipoConta, cartaoCredito.LimiteCredito, cartaoCredito.CobrancaAnual);
Console.ReadKey();
