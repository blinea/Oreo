using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Oreo.Controller
{
    class Connection
    {
        private static SqlConnection conn = null;

        public void ConnectToday()
        {
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + "C:\\Users\\bline\\Documents\\Codes\\Visual Studio\\Oreo\\Oreo\\Database\\OreoDB.mdf" + ";Integrated Security=True");
            conn.Open();
        }




    }
}
