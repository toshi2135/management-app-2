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

namespace BTLTTuan07
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

        Book _sach = new Book()
        {
            Name = "Learning Java",
            Author = "Marc Loy",
            PublishedYear = "2020",
            CoverImage = "Images/cover.jpg"
        };

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = _sach; // Thực hiện hàn gắn Entity với Màn hình
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            _sach.Name = "C# 9.0 in a Nutshell";
            _sach.Author = "Joseph Albahari";
            _sach.PublishedYear = "2021";
            _sach.CoverImage = "Images/cover02.jpg";
        }
    }
}
