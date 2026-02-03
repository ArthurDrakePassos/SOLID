using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Aderente
{
    public class DescontoClienteVip : Pedido
    {
        public override double DescontoPedido(double valorFinal)
        {
            return valorFinal * 0.80; // 20% de desconto para clientes VIP
        }
    }
}
