namespace OCP.Aderente
{
    public class DescontoClienteAssociado : Pedido
    {
        public override double DescontoPedido(double valorFinal)
        {
            return valorFinal * 0.90; // 10% de desconto para clientes associados
        }
    }
}
