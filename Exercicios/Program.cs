using Exercicios.Exercicio1.Aderente;
using Exercicios.Exercicio1.Aderente.Enumeradores;
using Exercicios.Exercicio1.Aderente.Interfaces;

public class Program
{
    public static void Main(string[] args)
    {
        ICalculaDescontoFidelidade descontoFidelidade = new CalculoDescontoFidelidade();
        ICalculaDescontoStatusContaFactory descontoStatusConta = new CalculaDescontoStatusContaFactory();

        GerenciadorDeDescontos gerenciadorDeDescontos = new GerenciadorDeDescontos(descontoFidelidade, descontoStatusConta);

        var resultado1 = gerenciadorDeDescontos.AplicarDesconto(1000, StatusContaCliente.ClienteComum, 10);
        Console.WriteLine(resultado1);

        var resultado2 = gerenciadorDeDescontos.AplicarDesconto(1000, StatusContaCliente.ClienteEspecial, 2);
        Console.WriteLine(resultado2);

        var resultado3 = gerenciadorDeDescontos.AplicarDesconto(1000, StatusContaCliente.ClienteVip, 5);
        Console.WriteLine(resultado3);

        var resultado4 = gerenciadorDeDescontos.AplicarDesconto(1000, StatusContaCliente.NaoRegistrado, 4);
        Console.WriteLine(resultado4);

        Console.ReadKey();
    }
}
