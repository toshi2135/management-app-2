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

namespace Tuan05_BasicUI
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        // Public property
        public string Username { get; set; } = "";
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            // Lưu dữ liệu trước khi đóng màn hình
            Username = usernameTextBox.Text;

            DialogResult = true;
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
