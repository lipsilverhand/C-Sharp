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

namespace LoginUser
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void Password_Button(object sender, RoutedEventArgs e)
        {
            string passwordInput = PasswordBox.Password;
            string ePassword = Environment.GetEnvironmentVariable("UserLogin");
                
            if(ePassword != null)
            {
                if (ePassword == passwordInput)
                {
                    MessageBox.Show("Enter correct password");

                } else
                {
                    MessageBox.Show("Wrong password, try again");

                }
            } else
            {
                MessageBox.Show("Environment variable not found!");
            }
        }
    }
}
