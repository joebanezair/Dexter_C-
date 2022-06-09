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

///

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
    public partial class create_account : Form
    {
        private string connection = null;
        SqlConnection con;
        public create_account()
        {
            InitializeComponent();
        }
        private void create_account_Load(object sender, EventArgs e)
        {
            this.age.Text = "Age";
            this.gender.Text = "Gender";
            this.system_email.Text = "Suggested Emails";

            string[] gendre = { "Male", "Female" };
            foreach (string value in gendre) { this.gender.Items.Add(value); }
            for (int age__ = 1; age__ < 101; age__++) { this.age.Items.Add(age__); }

            connection = "Data Source = DESKTOP-52H7VC8\\SQLEXPRESS;Initial Catalog = Hiring_Resource; User ID = DESKTOP-52H7VC8\\Yen Yen; Trusted_Connection = True";
            con = new SqlConnection(connection);
            try { con.Open(); con.Close(); } catch (Exception) { }
        }
        private void login_Click(object sender, EventArgs e) {

            string message = "Your current data will be deleted\n\nDo you want to continue?";
            string title = "Back to Login?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes) { close(true); } }

        public void close(bool close) {
            this.Close();
            return;
        }

        public string user_code, _user_email, username, lastname, password,
                      address, industry, job_categories, _gender, values;

        private void Generate_CheckedChanged(object sender, EventArgs e) {
            Random randomnumber = new Random();
            int randomone, randomtwo, randomthree;
            randomone = randomnumber.Next(1, 2);
            randomtwo = randomnumber.Next(1, 8);
            randomthree = randomnumber.Next(1, 8);
            username = user_name.Text;
            string[] email = { ".resource" };
            int random;

            if (username.Equals(null) || username == ""){
                MessageBox.Show("We cannot generate emails when\nusername is empty!");
            }
            else { 
                foreach (string value in email) {
                for (random = 0; random < 5; random++) {
                    this.system_email.Items.Add("@"+username+(randomone * random)+(random)+randomthree+value);
                } 
              }
            }
        }

        public int user_age;
        
        private void _create_acc_Click(object sender, EventArgs e)
        {
            username = user_name.Text;
            lastname = last_name.Text;
            address = _Address.Text; 
            industry = Industry.Text;

            job_categories = JobCategories.Text; 
            _gender = gender.SelectedItem.ToString();
            _user_email = system_email.SelectedItem.ToString();
            password = password_2.Text;

            user_age = age.SelectedIndex;

            user_code = user_age.ToString()+username+lastname+_gender;

            if (match.Text == "Passwords don't matched" || match.Text == "Passwords are empty!"
                || match.Text == "Passwords must be longer\nthan 8 characters!")
            {
                MessageBox.Show("We cannot continue\nPlease settle your passwords!");
            }
            else if (robot.Checked == false)
            {
                MessageBox.Show("We cannot continue\nPlease confirm if you are a robot\nor not!");
            }
            else {
                MessageBox.Show("Your data is already been saved to the database\nYou can now login your account!");
                this.password_1.Clear();
                this.password_2.Clear();
                this.check_pass.Checked = false;
                robot.Checked = false;
                this.match.Text = "";

                MessageBox.Show("Name : " + username +
                               "\nLast Name : " + lastname +
                               "\nAddress : " + address +
                               "\nIndustry : " + industry +
                               "\nJob Categories : " + job_categories +
                               "\nAge : " + user_age +
                               "\nGender : "+ _gender +
                               "\nEmail : " + _user_email);

                String query = "insert into userData values (@usercode, @user_email, @user_age, @user_gender, @user_name, @user_lastname, @user_password, @user_address, @user_industry, @user_jobCategories); ";
                try {
                    using (SqlCommand command = new SqlCommand(query, con)) {

                        command.Parameters.AddWithValue("@usercode", user_code);
                        command.Parameters.AddWithValue("@user_email", _user_email);
                        command.Parameters.AddWithValue("@user_age", user_age);
                        command.Parameters.AddWithValue("@user_gender", _gender);
                        command.Parameters.AddWithValue("@user_name", username);

                        command.Parameters.AddWithValue("@user_lastname", lastname);
                        command.Parameters.AddWithValue("@user_password", password);
                        command.Parameters.AddWithValue("@user_address", address);
                        command.Parameters.AddWithValue("@user_industry", industry);
                        command.Parameters.AddWithValue("@user_jobCategories", job_categories);

                        con.Open();
                        int result = command.ExecuteNonQuery();
                        if (result < 0) {
                            MessageBox.Show("error");
                            con.Close();
                        }
                    }

                }catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
                
            }
        }

       
        private void check_pass_CheckedChanged(object sender, EventArgs e)
        {
            string password1 = password_1.Text, 
                   password2 = password_2.Text;
            if (password1 != password2)
            {
                match.Text = "Passwords don't matched";
                match.ForeColor = Color.Red;
            }
            else if (password2 == "" || password1 == "")
            {
                match.Text = "Passwords are empty!";
                match.ForeColor = Color.Red;
            }
            else if (password2.Length < 8 || password1.Length < 8)
            {
                match.Text = "Passwords must be longer\nthan 8 characters!";
                match.ForeColor = Color.Red;
            }else{
                match.Text = "Passwords matched!";
                match.ForeColor = Color.Green;
            }
     
        }
    }
}

