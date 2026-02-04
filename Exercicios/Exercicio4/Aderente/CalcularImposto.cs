using Exercicios.Exercicio4.Aderente.Enumeradores;
using Exercicios.Exercicio4.Aderente.Interface;

namespace Exercicios.Exercicio4.Aderente
{
    public class CalcularImposto
    {
        ICalculaImpostoPaisFactory _calculaImpostoPaisFactory;
        ICalculaValorBase _calculaValorBase;
        public CalcularImposto(ICalculaImpostoPaisFactory calculaImpostoPaisFactory, ICalculaValorBase calculaValorBase)
        {
            _calculaImpostoPaisFactory = calculaImpostoPaisFactory;
            _calculaValorBase = calculaValorBase;
        }
        public decimal Calcular(decimal valor, decimal deducao, PaisEnum pais)
        {
            decimal valorBase = _calculaValorBase.Calcular(valor, deducao);

            decimal valorImposto = _calculaImpostoPaisFactory.CalcularImpostoPorPais(pais).Calcular(valorBase);

            return valorImposto;
        }
    }
}
