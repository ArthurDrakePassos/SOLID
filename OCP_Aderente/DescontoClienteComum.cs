using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Aderente
{
    public class DescontoClienteComum : Pedido
    {
        public override double DescontoPedido(double valorFinal)
        {
            return valorFinal * 0.95; // 5% de desconto para clientes comuns
        }
    }
}
