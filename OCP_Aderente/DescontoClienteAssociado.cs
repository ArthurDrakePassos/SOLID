using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Aderente
{
    public class DescontoClienteAssociado : Pedido
    {
        public override double DescontoPedido(double valorFinal)
        {
            return valorFinal * 0.90; // 10% de desconto para clientes associados
        }
    }
}
