using Exercicios.Exercicio1.Aderente.Interfaces;

namespace Exercicios.Exercicio1.Aderente
{
    public class ClienteNaoRegistradoDesconto : ICalculaDescontoStatusConta
    {
        public decimal AplicarDescontoStatusConta(decimal preco)
        {
            return preco;
        }
    }
}
