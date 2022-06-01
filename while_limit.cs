using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            User use = new User("Joebanezair","Joe");
            Administrator add = new Administrator("Joebanezair","0002","0002");
            
            Console.WriteLine("Enter ID : "); string ID = Convert.ToString(Console.ReadLine());
            add.verifyLogin(ID, "0002");

            Console.WriteLine("Enter new Password : "); string pass = Convert.ToString(Console.ReadLine());
            add.updataPassword(pass);

            Console.WriteLine("Enter new updated password : "); string updated = Convert.ToString(Console.ReadLine());
            use.updatePassword(updated);

            Console.WriteLine("Enter updated Name : "); string updatedName = Convert.ToString(Console.ReadLine());
            add.updateAdminName(updatedName);


        }
    }
    class User
    {
        protected string user_id; protected string user_password;
        public User(string id, string pass) {
            this.user_id = id;
            this.user_password = pass;
        }
        public void verifyLogin(string id, string pass) {
            bool confirm = string.Equals(this.user_password, this.user_id);

            if (confirm.Equals(true))
            {
                Console.WriteLine("registered user : " + confirm);
            }
            else {
                Console.WriteLine("registered user : " + confirm);
            }
           
        }
        public void updatePassword(string newPassword) {
            this.user_password = newPassword;
            Console.WriteLine("This is your new password : " +this.user_password);
        }
    }

    class Administrator : User {

        private string admin_name;
        public Administrator(string name, string id, string pass) : base(id, pass) {
            this.user_password = pass;
            this.user_id = id;
            this.admin_name = name;

            Console.WriteLine("The data of the data of the user  \nUsername : "+this.admin_name+"\nUserID : "+ this.user_id+ "\nPassword : " + this.user_password + "\n\n");
        }
        public void updataPassword(string newPassword) {
            this.user_password = newPassword;
            Console.WriteLine("Updated password : " + this.user_password);
        }
        public void updateAdminName(string name) {
            this.admin_name = name;
            Console.WriteLine("Updated Admin Name : " + this.admin_name);
        }
    }
}
