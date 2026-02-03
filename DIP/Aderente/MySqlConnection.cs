using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.Aderente
{
    public class MySqlConnection : IDataBaseConnection
    {
        public void Conectar()
        {
            Console.WriteLine("Conectado ao banco de dados MySQL.");
        }
    }
}
