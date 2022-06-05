using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace Resource_hub
{
    public partial class Hiring_Resource : Form
    {
        public Hiring_Resource()
        {
            InitializeComponent();
        }

        private System.Windows.Forms.Timer timer1;
        private int counter = 30;
        private void Hiring_Resource_Load(object sender, EventArgs e)
        {
            try
            {
                timer1 = new System.Windows.Forms.Timer();
                timer1.Tick += new EventHandler(Hiring_Resource_Load);
                timer1.Interval = 1000; // 1 second
                timer1.Start();
                
                load.Minimum = 0;
                load.Maximum = 100; int i;
                for (i = 0; i <= 100; i++)
                {
                    load.Value = i;
                    if (load.Value == 100)
                    {
                        counter--;
                        if (counter == 29)
                        {
                            intro.Text = "          WELCOME TO RECRUITMENT HUB!";
                        }
                        else if (counter == 27)
                        {
                            intro.Text = "   WE'RE WE FIND YOU NEW OPPORTUNITIES" +
                                         "\n   AND UPGRADE YOUR CAREER!";
                        }
                        else if (counter == 20)
                        {
                            intro.Text = "   JOIN US AND START YOUR NEW JOURNEY" +
                                         "\n   WITH RECRUITMENT HUB!";
                        }
                        else if (counter == 0)
                        {
                            username
                            open = new username();
                            this.Hide();
                            open.ShowDialog();
                            timer1.Stop();
                            // this.Close();
                        }
                        
                        
                    }
                } 
                
            }
            catch (Exception)
            {
                MessageBox.Show("Error Window");
            }

        }

        
        
         
    }
}
