using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace ParkingGarageManagementSystem
{
    public class DatabaseHandler
    {
        //returns a DataTable from a select query
        public static DataTable GetTable(string query)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ParkingGarageManagementSystem.Properties.Settings.Default.mbaylesDatabaseConnectionString;
            con.Open();
            using(SqlDataAdapter adapter = new SqlDataAdapter(query, con))
            {
                DataTable table = new DataTable();
                try
                {

                    adapter.Fill(table);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                return table;
            }
        }
        //used for inserts and updates
        public static void ExecuteNonQuery(string query)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ParkingGarageManagementSystem.Properties.Settings.Default.mbaylesDatabaseConnectionString;
            con.Open();
            using (SqlCommand command = new SqlCommand(query, con))
            {                
                command.ExecuteNonQuery();        
            }
        }
    }
}
