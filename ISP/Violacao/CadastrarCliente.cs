using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.Violacao
{
    public class CadastrarCliente : IPersistencia
    {
        public void ValidarDados()
        {
            Console.WriteLine("Valida Dados.");
        }
        public void SalvarDados()
        {
            Console.WriteLine("Salva Dados.");
        }
        public void EnviarEmail()
        {
            Console.WriteLine("Envia Email.");
        }
    }
}
