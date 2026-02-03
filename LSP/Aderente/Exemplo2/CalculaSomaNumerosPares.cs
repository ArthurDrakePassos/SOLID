using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Aderente.Exemplo2
{
    public class CalculaSomaNumerosPares : Calculadora
    {
        public CalculaSomaNumerosPares(int[] numeros) : base(numeros)
        {
        }
        public override int Calcular() => numeros.Where(n => n % 2 == 0).Sum();
        
    }
}
