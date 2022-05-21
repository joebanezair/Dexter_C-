using System;

namespace O9_TP
{
    class Program
    {
        static void Main(string[] args)
        {
            Person papi = new Person();
            Console.WriteLine("\n\nFull Name ''{0}''\n\n",papi.fullName());
        }
    }

    class Person {

        private string full_name;
        public string fullName() {
            this.full_name = "Joebanezair Buatona";
            return full_name;
        }
    
    }

}
