using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

        class Student : INotifyPropertyChanged
        {
            public string ID { get; set; }
            public string Name { get; set; }
            public string Avatar { get; set; }

            public event PropertyChangedEventHandler? PropertyChanged;
        }

        ObservableCollection<Student> _students;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _students = new ObservableCollection<Student>()
            {
                new Student() {ID="001", Name="Nguyen Van A", Avatar="Images/01.jpg"},
                new Student() {ID="002", Name="Tran Van B", Avatar="Images/44.jpg"},
                new Student() {ID="003", Name="Pham Van C", Avatar="Images/46.jpg"},
                new Student() {ID="004", Name="Truong Van D", Avatar="Images/47.jpg"},
                new Student() {ID="005", Name="Dao Van E", Avatar="Images/63.jpg"},
                new Student() {ID="006", Name="Vo Van F", Avatar="Images/86.jpg"},
                new Student() {ID="007", Name="Phan Van G", Avatar="Images/95.jpg"},
                new Student() {ID="008", Name="Le Van H", Avatar="Images/97.jpg"},
                new Student() {ID="009", Name="Lam Van I", Avatar="Images/98.jpg"},
                new Student() {ID="010", Name="Doan Van J", Avatar="Images/99.jpg"},
            };

            studentsComboBox.ItemsSource = _students;
        }

        private void addStudent_Click(object sender, RoutedEventArgs e)
        {
            _students.Add(new Student() 
            { 
                ID = "011", 
                Name = "Nguyen Van K", 
                Avatar = "Images/36.jpg" 
            });
        }

        private void deleteStudent_Click(object sender, RoutedEventArgs e)
        {
            int i = studentsComboBox.SelectedIndex;
            if (i >= 0)
            {
                _students.RemoveAt(i);
            }
        }

        private void updatetudent_Click(object sender, RoutedEventArgs e)
        {
            int i = studentsComboBox.SelectedIndex;
            if (i >= 0)
            {
                _students[i].ID = "012";
                _students[i].Name = "Nguyen Van L";
                _students[i].Avatar = "Images/36.jpg";
            }
        }
    }
}
