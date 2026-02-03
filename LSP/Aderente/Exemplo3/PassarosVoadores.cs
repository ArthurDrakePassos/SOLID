using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Aderente.Exemplo3
{
    public class PassarosVoadores : Passaro
    {
        public PassarosVoadores(string nome) : base(nome)
        {
        }

        public virtual void Voar()
        {
            Console.WriteLine($"{Nome} está voando.");
        }
    }
}
