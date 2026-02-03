namespace OCP.Violacao
{
    public enum TipoCliente
    {
        Comum,
        Associado,
        Especial
    }

    public class Pedido
    {
        //Caso seja criado um novo tipo de cliente, será necessário modificar este método para incluir a nova regra de desconto.
        public double DescontoPedido(double valor, TipoCliente tipoCliente)
        {
            double valorFinal;

            if (tipoCliente == TipoCliente.Comum)
            {
                valorFinal = valor * 0.95; // 5% de desconto
            }
            else if (tipoCliente == TipoCliente.Associado)
            {
                valorFinal = valor * 0.90; // 10% de desconto
            }
            else if (tipoCliente == TipoCliente.Especial)
            {
                valorFinal = valor * 0.85; // 15% de desconto
            }
            else
            {
                valorFinal = valor; // Sem desconto
            }

            return valorFinal;
        }
    }
}
