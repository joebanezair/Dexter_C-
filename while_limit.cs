using System;

namespace loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int num = random.Next(1, 10);
            int guess = 0;
            int limit = 1;

            Console.WriteLine("Guess a number between 1-100\nyou only got 3 attempts: ");
            
           
            while (limit <= 3){
                guess = Convert.ToInt32(Console.Read());
                if (num < guess) {
                    Console.WriteLine(limit+". try again lower than "+ guess); Console.ReadLine();               
                }
                if (num > guess){
                    Console.WriteLine(limit + ". try again higher than " + guess); Console.ReadLine();
                }
                if (num == guess){
                    Console.WriteLine(limit + ". good job you finally made it in "+limit
                    +" attempts and you guess it right : " + guess); 
                    Console.ReadLine(); break;
                }
                guess = 1;
                if (num == guess)
                {
                    Console.WriteLine(limit + ". good job you finally made it in " + limit 
                    + " attempts and you guess it right : " + guess);
                    Console.ReadLine(); break;
                }
                limit++;
            }
            Console.WriteLine("\nOpx you suceeded 3 attempts");


        }
    }
}









using System;

namespace UserNamespace
{
   

    public class User  
    {
        private string user_id;
        protected string user_passaword;

        static void Main(string[] args)
        {
            User use;
            string pass = "4321", id = "1234";
            User.Equals(pass, id);
            Console.WriteLine();
        }

        public User(string id, string pass) {
            this.user_id = id;
            this.user_passaword = pass;
        }
        public void verifyLogin (string id, string pass) {
           this.user_id = id = "1234";
           this.user_passaword = pass = "4321";

           bool compare = string.Equals(id, "1234");  
           bool compare2 = string.Equals(pass, "4321");
           Console.WriteLine(compare);
           Console.WriteLine(compare2);
        }
        public void updatePassword
        (string newPassword) {
           this.user_passaword = newPassword;
        }
        
    }

    public class Administrator : User 
    {
        private string admin_name;
        public string pass, id;
        public Administrator
        (string name, string id, string pass) : base(pass, id)  
        {
            this.admin_name = name = "Joebanezair";
            this.id = id; 
            this.pass = pass;
        }
        public void updatePassword
        (string newPassword)
        {
            this.user_passaword = newPassword;
        }
        public void updateAdminName(string name)
        {
            this.admin_name = name;
        }

    }
}

     
    


 

