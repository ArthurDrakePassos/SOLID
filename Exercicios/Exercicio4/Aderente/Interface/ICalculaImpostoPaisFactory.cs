using Exercicios.Exercicio4.Aderente.Enumeradores;

namespace Exercicios.Exercicio4.Aderente.Interface
{
    public interface ICalculaImpostoPaisFactory
    {
        ICalculaImpostoPais CalcularImpostoPorPais(PaisEnum pais);
    }
}
