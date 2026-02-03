using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Violacao.Exemplo2
{
    public class Execucao
    {
        public void Executar()
        {
            var numeros = new int[] { 1, 2, 3, 4, 5 };

            CalculaSoma calculaSoma = new CalculaSoma(numeros);
            Console.WriteLine($"Soma Total: {calculaSoma.Calcular()}"); // Saída Esperada - Soma Total: 15

            CalculaSoma calculaSomaPares = new CalculaSomaNumerosPares(numeros);
            Console.WriteLine($"Soma dos Números Pares: {calculaSomaPares.Calcular()}"); // Saída Esperada - Soma dos Números Pares: 6

            //Substituindo a instância da classe base pela classe derivada
            CalculaSoma calculaSomaPares2 = new CalculaSomaNumerosPares(numeros);
            Console.WriteLine($"Soma dos Números Pares: {calculaSomaPares2.Calcular()}"); // Saída Esperada - Soma dos Números Pares: 6, porém, está retornando 15
        }
    }
}
