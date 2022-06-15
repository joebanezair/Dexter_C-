using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePayrollOOP
{
    public partial class Form1 : Form
    {
        int salary,  tax;
        double _qross;
        string male = "Male", female = "Female";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {   }

        private void gross_Click(object sender, EventArgs e)
        {
            check();
        }

        void check() {
            if (basicSalary.Text == "" || overTime.Text == "" || Tax.Text == "")
            {
                MessageBox.Show("some fields are empty");
            }
            else
            {
                set(Convert.ToDouble(basicSalary.Text));
                _gross.Text = "" + get();
            }
        }

        private void receipt_Click(object sender, EventArgs e)
        {
            if (employee.Text == "" || employer.Text == "" || Address.Text == ""){
                MessageBox.Show("some fields are empty");
            }
            else {
                check();
                if (Male.Checked)
                {
                    MessageBox.Show("" +
                      "\nEmployee Name :" + employee.Text +
                      "\nEmployer Name :" + employer.Text +
                      "\nGender : " + this.male +
                      "\nAddress : " + Address.Text +
                      "\nBasic Salary : " + basicSalary.Text +
                      "\nOver Time : " + overTime.Text +
                      "\nTax : " + Tax.Text +
                      "\nTOTAL GROSS : " + get());
                }
                else if (Female.Checked)
                {
                    MessageBox.Show("" +
                      "\nEmployee Name :" + employee.Text +
                      "\nEmployer Name :" + employer.Text +
                      "\nGender : " + this.female +
                      "\nAddress : " + Address.Text +
                      "\nBasic Salary : " + basicSalary.Text +
                      "\nOver Time : " + overTime.Text +
                      "\nTax : " + Tax.Text +
                      "\nTOTAL GROSS : " + get());
                }
                else {
                    MessageBox.Show("Check some gender");
                }
                
            }
        }

        private void set(double gross) {
            double _salary = Convert.ToDouble(basicSalary.Text);
            double overtime = Convert.ToDouble(overTime.Text);
            double tacs = Convert.ToDouble(Tax.Text);
            this._qross = (_salary + overtime) - tacs;
        }
        private double get() {
            return this._qross;
        }
    }
}
