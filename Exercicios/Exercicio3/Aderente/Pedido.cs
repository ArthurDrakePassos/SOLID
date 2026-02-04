using Exercicios.Exercicio3.Violacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Exercicio3.Aderente
{
    public class Pedido
    {
        private ILogger log;

        public Pedido(ILogger logger) 
        {
            log = logger;
        }

        public void AdicionarPedido()
        {
            try
            {
                log.LogarConsole("Pedido incluido - Log Console!");
                log.LogarArquivo("Pedido incluido - Log Arquivo!");
            }
            catch (Exception ex)
            {
                log.LogarConsole($"Log Console - Erro ao incluir pedido: {ex}");
                log.LogarArquivo($"Log Arquivo - Erro ao incluir pedido: {ex}");
            }
        }
    }
}
