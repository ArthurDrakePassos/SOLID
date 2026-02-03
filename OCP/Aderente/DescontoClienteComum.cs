namespace OCP.Aderente
{
    public class DescontoClienteComum : Pedido
    {
        public override double DescontoPedido(double valorFinal)
        {
            return valorFinal * 0.95; // 5% de desconto para clientes comuns
        }
    }
}
