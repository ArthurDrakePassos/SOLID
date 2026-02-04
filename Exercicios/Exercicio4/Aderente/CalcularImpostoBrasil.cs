using Exercicios.Exercicio4.Aderente.Constantes;
using Exercicios.Exercicio4.Aderente.Interface;

namespace Exercicios.Exercicio4.Aderente
{
    public class CalcularImpostoBrasil : ICalculaImpostoPais
    {
        public decimal Calcular(decimal valorBase)
        {
            decimal aliquota = AliquotaConstante.BRASIL;
            return valorBase * aliquota;
        }
    }
}
