using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Database
    {
        protected string Strcon = @"Data Source=DESKTOP-M4UKRGH\SQLEXPRESS01;Initial Catalog=STUDENTMANAGEMENT;Integrated Security=True";
        protected SqlConnection sqlcon = null;

        public void OpenConnction()
        {
            if (sqlcon == null)
            {
                sqlcon = new SqlConnection(Strcon);

            }
            if (sqlcon.State != System.Data.ConnectionState.Open)
            {
                sqlcon.Open();
            }
        }
        public void closeConnection()
        {
            if (sqlcon != null && sqlcon.State == System.Data.ConnectionState.Open)
            {
                sqlcon.Close();
            }
        }

    }
}
   
