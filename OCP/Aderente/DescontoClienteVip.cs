namespace OCP.Aderente
{
    public class DescontoClienteVip : Pedido
    {
        public override double DescontoPedido(double valorFinal)
        {
            return valorFinal * 0.80; // 20% de desconto para clientes VIP
        }
    }
}
