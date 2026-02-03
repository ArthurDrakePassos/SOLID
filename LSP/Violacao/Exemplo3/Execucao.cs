using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Violacao.Exemplo3
{
    public class Execucao
    {
        public void Executar()
        {
            Passaro pato = new Pato("Donald");
            pato.Comer();
            pato.BotarOvos();
            pato.Voar();
            
            Passaro pinguim = new Pinguim("Pingu");
            pinguim.Comer();
            pinguim.BotarOvos();
            pinguim.Voar();
        }
    }
}
