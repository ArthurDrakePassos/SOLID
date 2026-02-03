namespace LSP.Aderente.Exemplo1
{
    public class Vendendor : Funcionario
    {
        private double comissao = 1500;

        public Vendendor(string nome, string cargo) : base(nome, cargo)
        {
        }

        public override double CalcularSalario(double salario)
        {
            return salario + comissao;
        }
    }
}
