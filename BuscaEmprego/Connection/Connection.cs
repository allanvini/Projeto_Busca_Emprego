using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace BuscaEmprego.Connection
{
    class Connection
    {
        private String connectionString;

        public String getconnectionString()
        {
            connectionString = ConfigurationManager.ConnectionStrings["BuscaEmprego.Properties.Settings.BuscaEmpregoConnectionString"].ConnectionString;
            return connectionString;
        }
    }
}
