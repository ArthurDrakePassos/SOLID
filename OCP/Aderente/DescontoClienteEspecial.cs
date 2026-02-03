namespace OCP.Aderente
{
    public class DescontoClienteEspecial : Pedido
    {
        public override double DescontoPedido(double valorFinal)
        {
            return valorFinal * 0.85; // 15% de desconto para clientes especiais
        }
    }
}
