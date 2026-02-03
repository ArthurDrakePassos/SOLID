using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Aderente.Exemplo3
{
    public class Passaro
    {
        public string Nome { get; set; }

        public Passaro(string nome)
        {
            Nome = nome;
        }

        public virtual void Comer()
        {
            Console.WriteLine($"{Nome} está comendo.");
        }

        public virtual void BotarOvos()
        {
            Console.WriteLine($"{Nome} está botando ovos.");
        }
    }
}
