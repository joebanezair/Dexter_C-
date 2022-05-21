using System;

namespace O9_TP
{
    class Program
    {
        static void Main(string[] args)
        {
            structDescPrice st = new structDescPrice();
            Console.WriteLine("Enter your Descriptions: ");
            string des = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter your Price: ");
            double price = Convert.ToDouble(Console.ReadLine());

            st.setDescription(des);
            Console.WriteLine("Description: {0}", st.getDescription());

            st.setPrice(price);
            Console.WriteLine("Description: P{0}", st.getPrice());


        }
    }

    struct structDescPrice {

        private string description;
        public string getDescription() {
            return description;
        }
        public void setDescription(string description){
            this.description = description;
        }

        private double price;
        public double getPrice() {
            return price;   
        }
        public void setPrice(double price) {
            this.price = price;
        }

       
    }
}
