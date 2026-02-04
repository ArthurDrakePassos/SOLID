using Exercicios.Exercicio4.Aderente.Enumeradores;
using Exercicios.Exercicio4.Aderente.Interface;

namespace Exercicios.Exercicio4.Aderente
{
    public class CalculaImpostoPaisFactory : ICalculaImpostoPaisFactory
    {
        public ICalculaImpostoPais CalcularImpostoPorPais(PaisEnum pais)
        {
            ICalculaImpostoPais calculaImpostoPais;
            switch (pais)
            {
                case PaisEnum.Brasil:
                    calculaImpostoPais = new CalcularImpostoBrasil();
                    break;
                case PaisEnum.EUA:
                    calculaImpostoPais = new CalcularImpostoEua();
                    break;
                case PaisEnum.Argentina:
                    calculaImpostoPais = new CalcularImpostoArgentina();
                    break;
                default:
                    throw new ArgumentException("País desconhecido");
            }

            return calculaImpostoPais;
        }
    }
}
