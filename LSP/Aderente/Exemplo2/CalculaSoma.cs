using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Aderente.Exemplo2
{
    public class CalculaSoma : Calculadora
    {
        public CalculaSoma(int[] numeros) : base(numeros)
        {
        }

        public override int Calcular() => numeros.Sum();
    }
}
