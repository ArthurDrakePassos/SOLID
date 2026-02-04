using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Exercicio3.Aderente
{
    public class Logger : ILogger
    {
        public void LogarArquivo(string mensagem)
        {
            File.WriteAllText(@"c:\dados\log\Logs.txt", mensagem);
        }

        public void LogarConsole(string mensagem)
        {
            Console.WriteLine(mensagem);
        }
    }
}
