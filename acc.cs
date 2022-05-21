using System;

namespace O9_TP
{
    class Program
    {
        static void Main(string[] args)
        {
            Accounts ac = new Accounts();
            Console.WriteLine("\n\naccount number : {0}", ac.account());
        }
    }

    class Accounts {
        private int account_number;
        public int account() {
            this.account_number = 12345;
            return account_number;
        }
    
    }

}
