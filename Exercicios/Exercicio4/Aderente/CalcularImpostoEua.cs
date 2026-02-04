using Exercicios.Exercicio4.Aderente.Constantes;
using Exercicios.Exercicio4.Aderente.Interface;

namespace Exercicios.Exercicio4.Aderente
{
    public class CalcularImpostoEua : ICalculaImpostoPais
    {
        public decimal Calcular(decimal valorBase)
        {
            decimal aliquota = AliquotaConstante.EUA;
            return valorBase * aliquota;
        }
    }
}
