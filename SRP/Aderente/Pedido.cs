namespace SRP.Aderente
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Item { get; set; }
        private ILogger _logger;
        private EnviarEmail _email;

        public Pedido()
        {
            _logger = new RegistraLog();
            _email = new EnviarEmail();
        }

        public void IncluirPedido()
        {
            try
            {
                //Código para incluir pedido...
                _logger.GravaLog("Incluindo Pedido");

                _email.EmailFrom = "EmailFrom";
                _email.EmailTo = "EmailTo";
                _email.EmailSubject = "EmailSubject";
                _email.EmailBody = "EmailBody";
                _email.EnviarEmailConfirmacao();
            }
            catch (Exception ex)
            {
                _logger.GravaLog("Erro ao incluir pedido: " + ex.ToString());
            }
        }

        public void DeletarPedido()
        {
            try
            {
                //Código para deletar pedido...
                _logger.GravaLog("Deletando Pedido");
            }
            catch (Exception ex)
            {
                //Gravar log de erro
                _logger.GravaLog("Erro ao deletar pedido: " + ex.ToString());
            }
        }
    }
}
