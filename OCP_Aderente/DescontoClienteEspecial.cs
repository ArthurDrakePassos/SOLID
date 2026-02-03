using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Aderente
{
    public class DescontoClienteEspecial : Pedido
    {
        public override double DescontoPedido(double valorFinal)
        {
            return valorFinal * 0.85; // 15% de desconto para clientes especiais
        }
    }
}
