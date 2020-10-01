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
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            Scheme.Market market = new Scheme.Market();
            Scheme.User user = new Scheme.User()
            {
                FirstName = firstNameTextBox.Text,
                LastName = firstNameTextBox.Text,
                Phone = phoneTextBox.Text,
                Email = emailTextBox.Text,
                Password = passwordTextBox.Text,
                Address = addressTextBox.Text,
                Card = cardTextBox.Text
            };
            market.Users.Add(user);
            market.SaveChanges();
            Close();
        }
    }
}
