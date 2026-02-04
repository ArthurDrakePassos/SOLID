using Exercicios.Exercicio4.Aderente.Interface;

namespace Exercicios.Exercicio4.Aderente
{
    public class CalculaValorBase : ICalculaValorBase
    {
        public decimal Calcular(decimal valor, decimal deducao)
        {
            return valor - deducao;
        }
    }
}
