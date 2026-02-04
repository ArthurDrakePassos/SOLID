namespace Exercicios.Exercicio3.Violacao
{
    public class Pedido
    {
        private ConsoleLogger log = new ConsoleLogger();

        public virtual void AdicionarPedido()
        {
            try
            {
                log.Registrar($"Pedido incluido!");
            }
            catch (Exception ex)
            {

                log.Registrar($"Erro ao incluir pedido: {ex}");
            }            
        }
    }
}
