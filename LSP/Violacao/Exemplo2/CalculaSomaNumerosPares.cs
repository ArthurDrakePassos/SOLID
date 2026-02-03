using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Violacao.Exemplo2
{
    public class CalculaSomaNumerosPares : CalculaSoma
    {
        public CalculaSomaNumerosPares(int[] numeros) : base(numeros)
        {
        }
        public new int Calcular() => numeros.Where(n => n % 2 == 0).Sum();
        
    }
}
