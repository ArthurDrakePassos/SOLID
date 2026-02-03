using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Aderente.Exemplo2
{
    public class Execucao
    {
        public void Executar()
        {
            var numeros = new int[] { 1, 2, 3, 4, 5 };

            Calculadora calculaSoma = new CalculaSoma(numeros);
            Console.WriteLine($"Soma Total: {calculaSoma.Calcular()}"); // Saída Esperada - Soma Total: 15

            Calculadora calculaSomaPares = new CalculaSomaNumerosPares(numeros);
            Console.WriteLine($"Soma dos Números Pares: {calculaSomaPares.Calcular()}"); // Saída Esperada - Soma dos Números Pares: 6
        }
    }
}
