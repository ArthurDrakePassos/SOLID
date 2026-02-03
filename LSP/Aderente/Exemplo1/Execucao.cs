using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Aderente.Exemplo1
{
    public class Execucao
    {
        public void Executar()
        {
            Funcionario funcionario1 = new Gerente("Carlos", "Gerente de Vendas");
            Funcionario funcionario2 = new Vendendor("Ana", "Vendedora");

            var salario1 = funcionario1.CalcularSalario(3000);
            var salario2 = funcionario2.CalcularSalario(2000);

        }
    }
}
