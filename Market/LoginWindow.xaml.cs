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

namespace Market
{
    /// <summary>
    /// Логика взаимодействия для LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private Scheme.User user = null;
        private LoginResult loginResult = LoginResult.Failure;

        public Scheme.User User
        {
            get { return user; }
        }

        public LoginResult LoginResult
        {
            get { return loginResult; }
        }

        public LoginWindow()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            Scheme.Market market = new Scheme.Market();
            foreach (Scheme.User user in market.Users)
            {
                if (user.Phone.Equals(usernameTextBox.Text) || user.Email.Equals(usernameTextBox.Text) && user.Password.Equals(passwordTextBox.Text))
                {
                    this.user = user;
                    break;
                }
            }
            if (user == null)
                MessageBox.Show("Incorrect phone, email or password", "Login failed", MessageBoxButton.OK);
            else
            {
                loginResult = LoginResult.Success;
                Close();
            }
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            loginResult = LoginResult.Registration;
            Close();
        }
    }

    public enum LoginResult
    {
        Failure = 1,
        Success = 2,
        Registration = 3
    }
}
