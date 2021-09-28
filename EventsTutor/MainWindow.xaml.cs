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

namespace EventsTutor
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            signIn.Click += SignIn;
            signIn.Click += Logger;
        }

        private void SignIn(object sender, RoutedEventArgs e)
        {
            Account win = new Account();
            win.Show();
            Close();
        }

        private void Logger(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Время: {DateTime.Now}");
        }

    }
}
