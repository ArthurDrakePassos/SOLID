using Exercicios.Exercicio1.Aderente.Constantes;
using Exercicios.Exercicio1.Aderente.Interfaces;

namespace Exercicios.Exercicio1.Aderente
{
    internal class ClienteEspecialDesconto : ICalculaDescontoStatusConta
    {
        public decimal AplicarDescontoStatusConta(decimal preco)
        {
            return preco - (DescontosConstante.DESCONTO_CLIENTE_ESPECIAL * preco);
        }
    }
}
