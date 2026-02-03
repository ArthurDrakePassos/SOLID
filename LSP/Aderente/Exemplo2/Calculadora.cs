using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Aderente.Exemplo2
{
    public abstract class Calculadora
    {
        protected readonly int[] numeros;
        public Calculadora(int[] numeros)
        {
            this.numeros = numeros;
        }

        public abstract int Calcular();
    }
}
