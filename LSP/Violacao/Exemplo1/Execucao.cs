using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Violacao.Exemplo1
{
    public class Execucao
    {
        public void Executar()
        {
            Funcionario funcionario1 = new Gerente("Carlos", "Gerente de Vendas");
            Funcionario funcionario2 = new Vendendor("Ana", "Vendedora");

            //Ao descomentar o código abaixo, ocorrerá um erro de compilação, pois o método CalcularSalario não está definido na classe base Funcionario.
            /*
            var salario1 = funcionario1.CalcularSalario(3000);
            var salario2 = funcionario2.CalcularSalario(2000);
            */
        }
    }
}
