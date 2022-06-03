using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //variables
        string name; 
        public double total, price, payments, change, minus;

        

        public int qantiti;
        private void compute_Click(object sender, EventArgs e)
        {
            this.name = itemname.Text.ToString();
            this.price = Convert.ToDouble(itemprice.Text);
            this.qantiti = Convert.ToInt32(quantity.Text);

            DiscountedItem items = new DiscountedItem(name, price, qantiti);

            items.setPayment(qantiti);
            items.setChange(qantiti);

            this.total = items.getTotalPrice();

            payments = Convert.ToDouble(payment.Text);
            change = items.getChange();
            minus = payments - change;
            CHANGE.Text = "CHANGE : " + minus; 

           
            TOTAL.Text = "TOTAL : "+items._getTotalPrice();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            double total, finals;
            total = Convert.ToDouble(payment.Text);
            minus = Convert.ToDouble(TOTAL.Text); 
            finals = total - minus;
            CHANGE.Text = "CHANGE : " + finals;


        }


    }

    class Item {
        protected string item_name;
        protected double item_price;
        protected int item_quantity;
        private double total_price;

        public Item(string name, double price, int quantity)
        {
            this.item_name = name;
            this.item_price = price;
            this.item_quantity = quantity;
        }
        

        public void setPayment(double amount)
        {
            amount = this.item_quantity * this.item_price;
            this.total_price = amount;
        }

        public double getTotalPrice() {
            return this.total_price;
        }

    }

    class DiscountedItem : Item {

        private double item_discount;
        private double discounted_price;
        private double payment_amount;
        private double change;

        public  DiscountedItem(string name, double price, int quantity):base(name, price, quantity){
            this.discounted_price = price;
        }
        public void _setPayment(double amount) {
           
            
        }
        public double _getTotalPrice(){
            Form1 form = new Form1();
            return form.total;
        }

        public void setChange(double change) {
            change = this.item_price + this.item_quantity;
            this.change = change;
        }
        public double getChange() { return this.change; }
         




    }

}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
 
        public double computation;
        private void compute_Click(object sender, EventArgs e)
        {
            double price, amount, compute, sdiscount = 1535;
            price = Convert.ToDouble(itemprice.Text);
            amount = Convert.ToDouble(quantity.Text);
            compute = price * amount;
            double apple = Convert.ToDouble(discount.Text);
            double percent = (compute * apple) / 100;
            computation = compute - percent;
            TOTAL.Text = " TOTAL : " + computation;
            
        }

        private void submit_Click(object sender, EventArgs e)
        {

            double compute = this.computation;
            double pay = Convert.ToDouble(payment.Text);

            double payed = pay - compute;
            CHANGE.Text = "CHANGE : " + payed;

        }


    }

     

}
