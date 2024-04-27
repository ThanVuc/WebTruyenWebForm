using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace WebTruyen
{
    public class _Connection
    {

        public SqlDataAdapter adapter = new SqlDataAdapter();
        public SqlConnection Connection { get; set; }
        public SqlCommand Cmd { get; set; }

        public _Connection()
        {
            var sqlconnectstring = @"Data Source=localhost;
                         Initial Catalog=StoryDB;
                         User ID=SA;Password=88888888";
            Connection = new SqlConnection(sqlconnectstring);
            Connection.Open();
            Cmd = Connection.CreateCommand();

        }

        public void CloseConnect()
        {
            Connection.Close();
        }

    }
}