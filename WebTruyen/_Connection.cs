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
        private const string sqlconnectstring = @"Data Source=localhost;
                         Initial Catalog=StoryDB;
                         User ID=SA;Password=123";
        public SqlDataAdapter adapter = new SqlDataAdapter();
        public SqlConnection Connection { get; set; }
        public SqlCommand Cmd { get; set; }

        public _Connection()
        {
            
            Connection = new SqlConnection(sqlconnectstring);
            Connection.Open();
            Cmd = Connection.CreateCommand();

        }

        public void OpenConnect()
        {
            Connection = new SqlConnection(sqlconnectstring);
            Connection.Open();
        }
        public void CloseConnect()
        {
            Connection.Close();
        }

    }
}