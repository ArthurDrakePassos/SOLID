namespace SRP.Aderente
{
    public class RegistraLog : ILogger
    {
        public void GravaLog(string info)
        {
            //Gravar log de erro
            File.WriteAllText(@"c:\dados\log.txt", info);
        }
    }
}
