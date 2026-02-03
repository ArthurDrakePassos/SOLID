using Exercicios.Exercicio1.Aderente.Enumeradores;

namespace Exercicios.Exercicio1.Aderente.Interfaces
{
    public interface ICalculaDescontoStatusContaFactory
    {
        ICalculaDescontoStatusConta GetCalculaDescontoStatusConta(StatusContaCliente statusConta);
    }
}
