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

namespace BTLTTuan05
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Title = "Chương trình đã sẵn sàng";
        }

        private void phoneButton_Click(object sender, RoutedEventArgs e)
        {
            AddPhoneWindow screen = new AddPhoneWindow();
            bool? result = screen.ShowDialog();

            if (result == true)
            {
                Title = screen.Phone;
            }
            else if (result == false)
            {
                MessageBox.Show("Bạn đã chọn Cancel");
            }
        }
    }
}
