namespace LSP.Aderente.Exemplo1
{
    public class Funcionario
    {
        public string? Nome { get; set; }
        public string? Cargo { get; set; }

        public Funcionario(string nome, string cargo)
        {
            Nome = nome;
            Cargo = cargo;
        }

        public virtual double CalcularSalario(double salario)
        {
            return salario;
        }
    }
}
