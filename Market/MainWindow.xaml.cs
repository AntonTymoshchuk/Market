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

namespace Market
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.ShowDialog();
            if (loginWindow.LoginResult == LoginResult.Failure)
                Close();
            else if (loginWindow.LoginResult == LoginResult.Success)
            {
                LoadProducts();
            }
            else if (loginWindow.LoginResult == LoginResult.Registration)
            {
                RegistrationWindow registrationWindow = new RegistrationWindow();
                registrationWindow.ShowDialog();
                LoadProducts();
            }
        }

        private void LoadProducts()
        {

        }
    }
}
