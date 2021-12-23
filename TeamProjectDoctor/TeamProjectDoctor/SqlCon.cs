
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace TeamProjectDoctor
{


    public static class SqlCommunication
    {


        static public SqlConnection connection;
        static public SqlCommand command;
        static public SqlDataAdapter adapter;
        static public DataTable dataTable;
        static string ConnectioString = ConfigurationManager.ConnectionStrings[""].ConnectionString;

      
    }


}