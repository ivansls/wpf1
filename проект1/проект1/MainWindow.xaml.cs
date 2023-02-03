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

namespace проект1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();


        }
        Dictionary<int, Button> but = new Dictionary<int, Button>() {};
        Dictionary<int, RadioButton> R_but = new Dictionary<int, RadioButton>() { }; 
        int rob_or_hum = 0;
        int count = 0;
        Class1 cl = new Class1();
        wincs win = new wincs();
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            button1.Content = "X";
            button1.IsEnabled= false;
            count++;
            count++;
            if (count < 9)
            {
                cl.random(but, R_but, textblock);
            }
            win.all_true(but, R_but, textblock, count);
            count++;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            button2.Content = "X";
            button2.IsEnabled=false;
            count++;
            count++; 
            if (count < 9)
            {
                cl.random(but, R_but, textblock);
            }
            win.all_true(but, R_but, textblock, count);
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            button3.Content = "X";
            button3.IsEnabled=false;
            count++;
            count++;
            if (count < 9)
            {
                cl.random(but, R_but, textblock);
            }
            win.all_true(but, R_but, textblock, count);
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            button4.Content = "X";
            button4.IsEnabled=false;
            count++;
            count++;
            if (count < 9)
            {
                cl.random(but, R_but, textblock);
            }
            win.all_true(but, R_but, textblock, count);
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            button5.Content = "X";
            button5.IsEnabled=false;
            count++;
            count++;
            if (count < 9)
            {
                cl.random(but, R_but, textblock);
            }
            win.all_true(but, R_but, textblock, count);
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            button6.Content = "X";
            button6.IsEnabled=false;
            count++;
            count++; 
            if (count < 9)
            {
                cl.random(but, R_but, textblock);
            }
            win.all_true(but, R_but, textblock, count);
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            button7.Content = "X";
            button7.IsEnabled=false;
            count++;
            count++;
            if (count < 9)
            {
                cl.random(but, R_but, textblock);
            }
            win.all_true(but, R_but, textblock, count);
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            button8.Content = "X";
            button8.IsEnabled=false;
            count++;
            count++;
            if (count < 9)
            {
                cl.random(but, R_but, textblock);
            }
            win.all_true(but, R_but, textblock, count);
            
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            button9.Content = "X";
            button9.IsEnabled=false;
            count++;
            count++;
            if (count < 9)
            {
                cl.random(but, R_but, textblock);
            }
            win.all_true(but, R_but, textblock, count);
            
        }

        private void Human_Checked(object sender, RoutedEventArgs e)
        {
            Human.IsEnabled = false;
            Robot.IsEnabled = false;
            rob_or_hum = 0;
        }

        private void Robot_Checked(object sender, RoutedEventArgs e)
        {
            Human.IsEnabled = false;
            Robot.IsEnabled = false;
            rob_or_hum = 1;
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            count = 0;
            but.Clear();
            R_but.Clear();
            but.Add(1, button1);
            but.Add(2, button2);
            but.Add(3, button3);
            but.Add(4, button4);
            but.Add(5, button5);
            but.Add(6, button6);
            but.Add(7, button7);
            but.Add(8, button8);
            but.Add(9, button9);
            R_but.Add(1, Human);
            R_but.Add(2, Robot);
            button1.IsEnabled = true;
            button2.IsEnabled = true;
            button3.IsEnabled = true;
            button4.IsEnabled = true;
            button5.IsEnabled = true;
            button6.IsEnabled = true;
            button7.IsEnabled = true;
            button8.IsEnabled = true;
            button9.IsEnabled = true;
            button1.Content = "";
            button2.Content = "";
            button3.Content = "";
            button4.Content = "";
            button5.Content = "";
            button6.Content = "";
            button7.Content = "";
            button8.Content = "";
            button9.Content = "";
            textblock.Text = "";
            if (rob_or_hum == 0)
            {
                MessageBox.Show("Вы ходите первый");
                Human.IsEnabled = false;
                Robot.IsEnabled = false;
            }
            else
            {
                Human.IsEnabled = false;
                Robot.IsEnabled = false;
                MessageBox.Show("Робот ходит первый");
                cl.random(but, R_but, textblock);
            }
            
        }
    }
}
