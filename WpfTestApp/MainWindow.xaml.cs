using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfTestApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            foreach (UIElement el in MainGrid.Children)
            {
                if (el is Button)
                {
                    ((Button) el).Click += Button_Click;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string str = (string)((Button) e.OriginalSource).Content;

            //if (str == "AC")
            //    MainTextLabel.Text = "";
            //else
            //    MainTextLabel.Text += str;

            switch (str)
            {
                case "AC":
                    MainTextLabel.Text = "";
                    break;
                case "=":
                    string value = new DataTable().Compute(MainTextLabel.Text, null).ToString();
                    MainTextLabel.Text = value;
                    break;
                //case "+":
                //    MainTextLabel.Text = "PLUS";
                //    break;
                //case "*":
                //    MainTextLabel.Text = "UMNOZHIT";
                //    break;
                //case "/":
                //    MainTextLabel.Text = "DELIM";
                //    break;
                //case "-":
                //    MainTextLabel.Text = "MINUS";
                //    break;
                default:
                    MainTextLabel.Text += str;
                    break;
            }
        }
    }
}
