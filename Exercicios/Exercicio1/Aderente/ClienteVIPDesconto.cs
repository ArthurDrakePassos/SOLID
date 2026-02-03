using Exercicios.Exercicio1.Aderente.Constantes;
using Exercicios.Exercicio1.Aderente.Interfaces;

namespace Exercicios.Exercicio1.Aderente
{
    public class ClienteVIPDesconto : ICalculaDescontoStatusConta
    {
        public decimal AplicarDescontoStatusConta(decimal preco)
        {
            return preco - (DescontosConstante.DESCONTO_CLIENTE_VIP * preco);
        }
    }
}
