using Exercicios.Exercicio1.Aderente.Constantes;
using Exercicios.Exercicio1.Aderente.Enumeradores;
using Exercicios.Exercicio1.Aderente.Interfaces;

namespace Exercicios.Exercicio1.Aderente
{
    public class GerenciadorDeDescontos
    {
        ICalculaDescontoFidelidade descontoFidelidade;
        ICalculaDescontoStatusContaFactory descontoStatusConta;

        public GerenciadorDeDescontos(ICalculaDescontoFidelidade _calculaDescontoFidelidade, ICalculaDescontoStatusContaFactory _calculaDescontoStatusContaFactory)
        {
            descontoFidelidade = _calculaDescontoFidelidade;
            descontoStatusConta = _calculaDescontoStatusContaFactory;
        }

        public decimal AplicarDesconto(decimal preco, StatusContaCliente statusContaCliente, int tempoDeContaEmAnos)
        {
            decimal precoAposDesconto = 0;

            precoAposDesconto = descontoStatusConta.GetCalculaDescontoStatusConta(statusContaCliente).AplicarDescontoStatusConta(preco);
            precoAposDesconto = descontoFidelidade.AplicarDescontoFidelidade(precoAposDesconto, tempoDeContaEmAnos);

            return precoAposDesconto;
        }
    }
}
