using Exercicios.Exercicio1.Aderente.Constantes;
using Exercicios.Exercicio1.Aderente.Interfaces;

namespace Exercicios.Exercicio1.Aderente
{
    public class CalculoDescontoFidelidade : ICalculaDescontoFidelidade
    {
        public decimal AplicarDescontoFidelidade(decimal preco, int tempoDeContaEmAnos)
        {
            decimal descontoPorFidelidade = (tempoDeContaEmAnos > DescontosConstante.DESCONTO_MAXIMO_POR_FIDELIDADE) ? (decimal)DescontosConstante.DESCONTO_MAXIMO_POR_FIDELIDADE / 100 : (decimal)tempoDeContaEmAnos / 100;

            return preco - (descontoPorFidelidade * preco);
        }
    }
}
