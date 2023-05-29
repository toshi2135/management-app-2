using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Tuan08_BindingList
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

        class Student
        {
            public string ID { get; set; }
            public string Name { get; set; }
            public string Avatar { get; set; }

        }

        ObservableCollection<Student> _students;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _students = new ObservableCollection<Student>()
            {
                new Student() {ID="PH001", Name="Nguyen Van A", Avatar="Images/1.jpg"},
                new Student() {ID="PH002", Name="Nguyen Van B", Avatar="Images/2.jpg"},
                new Student() {ID="PH003", Name="Nguyen Van C", Avatar="Images/3.jpg"},
                new Student() {ID="PH004", Name="Nguyen Van D", Avatar="Images/4.jpg"},
                new Student() {ID="PH005", Name="Nguyen Van E", Avatar="Images/5.jpg"},
                new Student() {ID="PH006", Name="Nguyen Van F", Avatar="Images/6.jpg"},
                new Student() {ID="PH007", Name="Nguyen Van G", Avatar="Images/7.jpg"},
                new Student() {ID="PH008", Name="Nguyen Van H", Avatar="Images/8.jpg"},
                new Student() {ID="PH009", Name="Nguyen Van I", Avatar="Images/9.jpg"},
                new Student() {ID="PH010", Name="Nguyen Van J", Avatar="Images/10.jpg"},
            };

            studentsComboBox.ItemsSource = _students;
        }
    }
}
