using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HHub_
{
    public partial class Profile : Form
    {
        private string connection = null;
        SqlConnection con;

        Login log;
        public Profile(Login login)
        {
            this.log = login;
            InitializeComponent();
            this.Text = "user profile";
            connection = "Data Source = DESKTOP-52H7VC8\\SQLEXPRESS;Initial Catalog = Hiring_Resource; User ID = DESKTOP-52H7VC8\\Yen Yen; Trusted_Connection = True";
            con = new SqlConnection(connection);
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            boxes();
        }
        ///
        void boxes() {


            string loguse = log.username.Text.ToString();
            
            //string sql = "select * from userData";
            string sql = "select * from userData where user_name = '"+ loguse +"'";
            SqlCommand command = new SqlCommand(sql, con);
            con.Open();
            using (SqlDataReader dataread = command.ExecuteReader()) {
                if (dataread.Read()) {
                    username.Text = "NAME : " + dataread["user_name"].ToString().ToUpper() + " " 
                                              + dataread["user_lastname"].ToString().ToUpper();
                    gender.Text = dataread["user_gender"].ToString();
                    label1.Text = dataread["user_address"].ToString();
                    age.Text = dataread["user_age"].ToString();
                    email.Text = dataread["user_email"].ToString();
                }
            }
            con.Close();
        }
        /// https ://www.youtube.com/watch?v=gsYrMTG9830
        /// https ://www.youtube.com/watch?v=IN2u3wfbZM8
    }
}
