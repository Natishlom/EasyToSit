using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//
using System.Data;
using System.Windows;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace EasyToSit.Classes
{
    class DbClass
    {

        public static string GetConnectionStrings()
        {
            string strConString = ConfigurationManager.ConnectionStrings["conString"].ToString();
            return strConString;
        }

        public static string sql;
        public static SqlConnection con = new SqlConnection();
        public static SqlCommand cmd = new SqlCommand();
        public static SqlDataReader rd;
        public static DataTable dt;
        public static SqlDataAdapter da;

        public static void openConnection()
        {
            try
            {
                if (con.State.Equals(ConnectionState.Closed))
                {
                    con.ConnectionString = GetConnectionStrings();
                    con.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The System failed to estalish a connection" + Environment.NewLine +
                    "Descriptions:" + ex.Message.ToString(), " C# WPF Connect to SQL Server", MessageBoxButtons.OK);
            }
        }

        public static void closeConnection()
        {
            try
            {
                if (con.State.Equals(ConnectionState.Open))
                {
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                //
            }
        }
    }
}


