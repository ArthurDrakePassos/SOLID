using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.Aderente
{
    public class RecuperarSenha
    {
        private IDataBaseConnection _conexao;

        public RecuperarSenha(IDataBaseConnection conexao)
        {
            // Inicializa a conexão com o banco de dados MySQL
            _conexao = conexao;
        }

        public void Recuperar()
        {
            _conexao.Conectar();
            // Lógica para recuperar a senha do usuário usando a conexão com o banco de dados...
        }
    }
}
