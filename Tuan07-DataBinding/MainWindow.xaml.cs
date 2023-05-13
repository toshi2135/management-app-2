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

namespace Tuan07_DataBinding
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

        Student _sv = new Student()
        {
            ID = "PH12345",
            Name = "Nguyễn Văn A",
            Credits = 40,
            Avatar = "Images/30.jpg",
            Amount = 2000000
        };

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = _sv; // Thực hiện hàn gắn Entity với Màn hình
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            // Bước 1: NuGet, cài đặt thư viện PropertyChanged.Fody
            // Bước 2: Cho lớp Student kế thừa từ interface INotifyPropertyChanged
            // Bước 3: Bổ sung sự kiện PropertyChanged (Ctrl + .)
            _sv.Amount = 9789000;
            _sv.Name = "Nguyễn Văn B";
            _sv.Credits = 300;
            _sv.Avatar = "Images/58.jpg";
        }
    }
}
