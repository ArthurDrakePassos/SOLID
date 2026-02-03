namespace LSP.Violacao.Exemplo1
{
    public class Gerente : Funcionario
    {
        private double bonus = 3000;

        public Gerente(string nome, string cargo) : base(nome, cargo)
        {
        }

        public double CalcularSalario(double salario)
        {
            return salario + bonus;
        }
    }
}
