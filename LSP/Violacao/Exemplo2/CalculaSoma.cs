using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Violacao.Exemplo2
{
    public class CalculaSoma
    {
        protected readonly int[] numeros;

        public CalculaSoma(int[] numeros)
        {
            this.numeros = numeros;
        }

        public int Calcular() => numeros.Sum();
    }
}
