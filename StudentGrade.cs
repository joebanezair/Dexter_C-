using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StudentGrade
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

 
        private void Button_Click(object sender, RoutedEventArgs e)
        { 
            TextBox name = (TextBox)Name;
            string name_ = name.Text; //getting textbox name convert into name

            TextBox eng = (TextBox)English; double en = Convert.ToDouble(eng.Text); // textbox input convert to double
            TextBox sci = (TextBox)Science; double sc = Convert.ToDouble(sci.Text);
            TextBox mat = (TextBox)Math; double ma = Convert.ToDouble(mat.Text);
            TextBox fil = (TextBox)Filipino; double fi = Convert.ToDouble(fil.Text);
            TextBox his = (TextBox)History; double hi = Convert.ToDouble(his.Text);

            Label bot = (Label)bottom; // label below 
            double answer = (en + sc + ma + fi + hi); // adding five double value
            double fanswer = answer / 5; // devide 5 label value into 5
            Label label1 = (Label)topLabel;
            string pass, fail; // pass fail string 
            
            pass = "The Student Passed!"; fail = "The Student Failed"; // pass fail string

            if (fanswer < 75) // conditionals 
            {
                label1.Content = fail; // fail label content fail string
                bot.Content = "The general average of " + name_.ToString() + " is " + fanswer.ToString() + ""; // double to string name grade
            }
            else {
                label1.Content = pass;// pass string 
                bot.Content = "The general average of " + name_.ToString() + " is " + fanswer.ToString() + "";  // double to string name grade
            }
        }
 
    }
}
