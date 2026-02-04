using Exercicios.Exercicio1.Aderente;
using Exercicios.Exercicio1.Aderente.Enumeradores;
using Exercicios.Exercicio1.Aderente.Interfaces;
using Exercicios.Exercicio2.Aderente;
using Exercicios.Exercicio3.Aderente;
using Exercicios.Exercicio4.Aderente;
using Exercicios.Exercicio4.Aderente.Enumeradores;
using Exercicios.Exercicio4.Aderente.Interface;

public class Program
{
    public static void Main(string[] args)
    {
        #region Exercicio 1
        //ICalculaDescontoFidelidade descontoFidelidade = new CalculoDescontoFidelidade();
        //ICalculaDescontoStatusContaFactory descontoStatusConta = new CalculaDescontoStatusContaFactory();

        //GerenciadorDeDescontos gerenciadorDeDescontos = new GerenciadorDeDescontos(descontoFidelidade, descontoStatusConta);

        //var resultado1 = gerenciadorDeDescontos.AplicarDesconto(1000, StatusContaCliente.ClienteComum, 10);
        //Console.WriteLine(resultado1);

        //var resultado2 = gerenciadorDeDescontos.AplicarDesconto(1000, StatusContaCliente.ClienteEspecial, 2);
        //Console.WriteLine(resultado2);

        //var resultado3 = gerenciadorDeDescontos.AplicarDesconto(1000, StatusContaCliente.ClienteVip, 5);
        //Console.WriteLine(resultado3);

        //var resultado4 = gerenciadorDeDescontos.AplicarDesconto(1000, StatusContaCliente.NaoRegistrado, 4);
        //Console.WriteLine(resultado4);

        //Console.ReadKey();
        #endregion

        #region Exercicio 2
        //var cliente = LocalizaCliente.ProcuraPorNome("Pedro");
        //var clientes = Cliente.GetClientes();
        //var clientesExportados = ExportarDados.ExportarCSV(clientes);

        //Console.WriteLine(clientesExportados);
        //Console.ReadKey();
        #endregion

        #region Exercicio 3
        //ILogger logger = new Logger();
        //var pedido = new Pedido(logger);
        //pedido.AdicionarPedido();
        #endregion

        #region Exercicio 4
        //ICalculaImpostoPaisFactory calculaImpostoPaisFactory = new CalculaImpostoPaisFactory();
        //ICalculaValorBase calculaValorBase = new CalculaValorBase();
        //CalcularImposto calc = new CalcularImposto(calculaImpostoPaisFactory, calculaValorBase);
        //var imposto = calc.Calcular(1000, 100, PaisEnum.Brasil);
        //Console.WriteLine($"Imposto calculado com sucesso: {imposto}");
        #endregion
    }
}
