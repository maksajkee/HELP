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

namespace HELP
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {
            string login = textBoxlogin.Text;
            string pass = passbox.Password;

            if (login.Length < 5)
            {
                textBoxlogin.ToolTip = "Введено не Корректно";
                textBoxlogin.Background = Brushes.DarkRed;

            }else if(pass.Length < 5)
            {
                passbox.ToolTip = "Введено не Корректно";
                passbox.Background = Brushes.DarkRed;

            }
            else
            {
                textBoxlogin.ToolTip = "";
                textBoxlogin.Background = Brushes.Transparent;
                passbox.ToolTip = "";
                passbox.Background = Brushes.Transparent;

                MessageBox.Show("Всё хорошо");
            }
            
            
        }

        private void Button_Window_Auth_Click(object sender, RoutedEventArgs e)
        {
            AuthWindow authWindow = new AuthWindow();
            authWindow.Show();
            this.Hide();
        }
    }
}
