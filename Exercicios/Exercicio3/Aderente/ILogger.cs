using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Exercicio3.Aderente
{
    public interface ILogger
    {
        void LogarConsole(string mensagem);
        void LogarArquivo(string mensagem);
    }
}
