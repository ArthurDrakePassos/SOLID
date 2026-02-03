using System.Net.Mail;

namespace SRP_Violacao
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Item { get; set; }


        public void IncluirPedido()
        {
            try
            {
                //Código para incluir pedido...

                //Após incluir o pedido, enviar e-mail de confirmação ao cliente
                MailMessage mail = new MailMessage("EmailFrom", "EmailTo", "EmailSubject", "EmailBody");

                EnviarEmailConfirmacao(mail);
            }
            catch (Exception ex)
            {
                //Gravar log de erro
                File.WriteAllText(@"c:/dados/log.txt", ex.ToString());
            }
        }

        public void DeletarPedido()
        {
            try
            {
                //Código para deletar pedido...
            }
            catch (Exception ex)
            {
                //Gravar log de erro
                File.WriteAllText(@"c:/dados/log.txt", ex.ToString());
            }
        }

        public void EnviarEmailConfirmacao(MailMessage mail)
        {
            try
            {
                //Código para enviar e-mail...
            }
            catch (Exception ex)
            {
                //Gravar log de erro
                File.WriteAllText(@"c:/dados/log.txt", ex.ToString());
            }
        }
    }
}
