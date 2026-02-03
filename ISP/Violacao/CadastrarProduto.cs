using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.Violacao
{
    public class CadastrarProduto : IPersistencia
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
            throw new NotImplementedException();
        }
    }
}
