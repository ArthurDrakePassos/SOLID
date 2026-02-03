using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Aderente.Exemplo3
{
    public class Pinguim : Passaro
    {
        public Pinguim(string nome) : base(nome)
        {
        }
        public override void Comer()
        {
            Console.WriteLine($"{Nome} está comendo.");
        }
        public override void BotarOvos()
        {
            Console.WriteLine($"{Nome} está botando ovos.");
        }
    }
}
