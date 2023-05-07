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

namespace Tuan05_BasicUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void welcomeButton_Click(object sender, RoutedEventArgs e)
        {
            string name = nameTextBox.Text;
            string message = "Xin chào " + name;
            MessageBoxResult choice = MessageBox.Show(message, "Thông tin", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);

            if (choice == MessageBoxResult.Yes)
            {
                //MessageBox.Show("Bạn đã chọn Yes");
                Title = "Bạn đã chọn Yes";
            }
            else if (choice == MessageBoxResult.No)
            {
                //MessageBox.Show("Bạn đã chọn No");
                Title = "Bạn đã chọn No";
            }
            else
            {
                //MessageBox.Show("Bạn đã chọn Cancel");
                Title = "Bạn đã chọn Cancel";
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Hiển thị xong thì mới chạy tiếp");
            Title = "Chương trình đã sẵn sàng";
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow screen = new LoginWindow();
            //screen.Show(); // Show vs ShowDialog
            //this.Close();

            bool? result = screen.ShowDialog();

            if (result == true)
            {
                Title = "Username: " + screen.Username;
            } else if (result == false)
            {
                Title = "Dialog result: False";
            }
        }
    }
}
