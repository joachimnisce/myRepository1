using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string contactNo { get; set; }

        public void insert()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(DatabaseConnection.connectionstring)) //dump //auto garbage collector
                {
                    con.Open(); // the program opens gthe database
                    string sql = "INSERT INTO users(name, contactNumber) VALUES(@name, @contact)";
                    //sql injection - hacker terms
                    MySqlCommand cmd = new MySqlCommand(sql, con); //connection
                    //populate name and contact with values
                    cmd.Parameters.AddWithValue("name", this.name);
                    cmd.Parameters.AddWithValue("contact", this.contactNo);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }
    }
}
