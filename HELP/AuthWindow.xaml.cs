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
using System.Windows.Shapes;

namespace HELP
{
    /// <summary>
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        public AuthWindow()
        {
            InitializeComponent();
        }

        private void Button_Auth_Click(object sender, RoutedEventArgs e)
        {
           
            

            string login = textBoxlogin.Text;
            string pass = passbox.Password;

            if (login.Length < 5)
            {
                textBoxlogin.ToolTip = "Введено не Корректно";
                textBoxlogin.Background = Brushes.DarkRed;

            }
            else if (pass.Length < 5)
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
                UserPageWindow userPageWindow = new UserPageWindow();
                userPageWindow.Show();
                Hide();
            }
        }

        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Hide();
        }
    }
}
