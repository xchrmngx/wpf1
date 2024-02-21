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
using Mail_LIB;


namespace WpfApp3

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
        private void CheckMailButton_Click(object sender, RoutedEventArgs e)
        {
            string mail = MailTextBox.Text;

            if (MailValidator.CheckMail(mail))
            {
                MessageBox.Show("Почта введена пральна", "Результат");
            }
            else
            {
                MessageBox.Show("Почта введена непральна", "Результат");
            }
        }

        private void CheckPasswordButton_Click(object sender, RoutedEventArgs e)
        {
            string password = PasswordTextBox.Text;

            if (MailValidator.CheckPassword(password))
            {
                MessageBox.Show("Твой пароль сильный", "Результат");
            }
            else
            {
                MessageBox.Show("Твой пароль слаб", "Результат");
            }
        }
    }
}