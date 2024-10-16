using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CALC
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

        int _firstInt, _secInt;
        double _operation;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TB_Result.Text = "";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TB_Result.Text += "1"; 
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            TB_Result.Text += "2";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            TB_Result.Text += "3";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            TB_Result.Text += "4";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            TB_Result.Text += "5";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            TB_Result.Text += "6";
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            TB_Result.Text += "7";
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            TB_Result.Text += "8";
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            TB_Result.Text += "9";
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            TB_Result.Text += "0";
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            try
            {
                _firstInt = Convert.ToInt32(TB_Result.Text);
                TB_Result.Text = "";
                _operation = '+';
            }
            catch (Exception ex) { }
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            try
            {
                _firstInt = Convert.ToInt32(TB_Result.Text);
                TB_Result.Text = "";
                _operation = '*';
            }
            catch (Exception ex) { }
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            try
            {
                _firstInt = Convert.ToInt32(TB_Result.Text);
                TB_Result.Text = "";
                _operation = '/';
            }
            catch (Exception ex) { }
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            try
            {
                _secInt = Convert.ToInt32(TB_Result.Text);
                if(_operation == '+')
                {
                    TB_Result.Text = Convert.ToString(_firstInt + _secInt);
                }
                else if(_operation == '-')
                {
                    TB_Result.Text = Convert.ToString(_firstInt - _secInt);
                }
                else if(_operation == '*')
                {
                    TB_Result.Text = Convert.ToString(_firstInt * _secInt);
                }
                else if(_operation == '/')
                {
                    if(_secInt == 0)
                    {
                        MessageBox.Show("на ноль делить нельзя");
                    }
                    else
                    {
                        TB_Result.Text = Convert.ToString(_firstInt / _secInt);
                    }
                }
            }
            catch(Exception ex) { }
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            try
            {
                _firstInt = Convert.ToInt32(TB_Result.Text);
                TB_Result.Text = "";
                _operation = '-';
            }
            catch (Exception ex) { }
        }
    }
}