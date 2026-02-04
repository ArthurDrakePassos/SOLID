namespace Exercicios.Exercicio4.Violacao
{
    public class CalcularImposto
    {
        public static decimal Calcular(decimal valor, decimal deducao, string pais)
        {
            decimal valorImposto = 0;
            decimal valorBase = valor - deducao;

            switch (pais)
            {
                case "Brasil":
                    //valorImposto = CalcularImpostoBrasil(valorBase);
                    break;
                case "USA":
                    //valorImposto = CalcularImpostoEUA(valorBase);
                    break;
                case "Argentina":
                    //valorImposto = CalcularImpostoArgentina(valorBase);
                    break;
                default:
                    throw new ArgumentException("País desconhecido");
            }

            return valorImposto;
        }
    }
}
