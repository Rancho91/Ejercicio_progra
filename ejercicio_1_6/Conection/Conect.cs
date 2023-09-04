using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace ejercicio_1_6.Conection
{
    internal class Conect
    {
        private SqlConnection conn;

        public Conect()
        {
            conn = new SqlConnection("Data Source=DESKTOP-1G25HFQ;Initial Catalog=ejercicio_1_6;Integrated Security=True");
        }

        public SqlConnection GetConnection()
        {
            return conn;
        }
    }
}
