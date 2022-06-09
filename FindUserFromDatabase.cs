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

namespace Resource_hub
{
    class Login
    {
        //checking user's data
        public string user,password;
        //
        private string conn = null;
        SqlConnection con;

        public void connect()
        {
            conn = "Data Source = DESKTOP-52H7VC8\\SQLEXPRESS;Initial Catalog = Hiring_Resource; User ID = DESKTOP-52H7VC8\\Yen Yen; Trusted_Connection = True";
            con = new SqlConnection(conn);
            try
            {
                con.Open();
                MessageBox.Show("     Welcome to Recruitment Hub", "");
                con.Close();
            }
            catch (Exception) { }
        }

        //
        public void initialize()
        {
            string check = getData();
            //username
            String query = "select user_name from userData where user_name = '" + check + "'";
            conn = "Data Source = DESKTOP-52H7VC8\\SQLEXPRESS;Initial Catalog = Hiring_Resource; User ID = DESKTOP-52H7VC8\\Yen Yen; Trusted_Connection = True";
            con = new SqlConnection(conn);

            //creating a username validation
            try {
                if (check == null || check == "") { MessageBox.Show("Empty username"); }
                else
                {
                    using (SqlDataAdapter adapt = new SqlDataAdapter(query, con))
                    {
                        DataTable dt = new DataTable();
                        adapt.Fill(dt);
                        if (dt.Rows.Count == 1)
                        {
                            //here touch
                            username open = new username();
                            open.openDialog();
                        }
                        else
                        {
                            MessageBox.Show("username does not exist!");
                        }
                    }
                }
            }
            catch (Exception) { }
        }


        //for closing username
        /*void openDialog()
        {
            username open = new username();
            password_login openDialog = new password_login(this);
            open.Hide();
            openDialog.ShowDialog();
            open.Close();
        }*/
        //Do not touch
        public void checkData(string username) { this.user = username; }
        public string getData(){ return user; }
        //Do not touch
     }

    class LoginPass {
        //checking user's data
        public string user, password;
        //
        private string conn = null;
        SqlConnection con;

        public void connect()
        {
            conn = "Data Source = DESKTOP-52H7VC8\\SQLEXPRESS;Initial Catalog = Hiring_Resource; User ID = DESKTOP-52H7VC8\\Yen Yen; Trusted_Connection = True";
            con = new SqlConnection(conn);
            try
            {
                con.Open();
                MessageBox.Show("     Welcome to Recruitment Hub", "");
                con.Close();
            }
            catch (Exception) { }
        }

        //
        public void initialize()
        {
            conn = "Data Source = DESKTOP-52H7VC8\\SQLEXPRESS;Initial Catalog = Hiring_Resource; User ID = DESKTOP-52H7VC8\\Yen Yen; Trusted_Connection = True";
            con = new SqlConnection(conn);
            //creating a password validation
            string checkPass = getPassword();
            String password = "select user_password from userData where user_password = '" + checkPass + "'";
            try
            {
                if (checkPass == null || checkPass == "") { MessageBox.Show("empty password!"); }
                else
                {
                    using (SqlDataAdapter adapt = new SqlDataAdapter(password, con))
                    {
                        DataTable dt = new DataTable();
                        adapt.Fill(dt);
                        if (dt.Rows.Count == 1)
                        {
                            MessageBox.Show("Nice");
                        }
                        else
                        {
                            MessageBox.Show("password does not exist!");
                        }
                    }
                }
            }
            catch (Exception) { }
        }

        public void checkPassword(string password) { this.password = password; }
        public string getPassword() { return this.password; }

        //Do not touch this

    }
}
