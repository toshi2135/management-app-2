﻿using System;
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Student sv = new Student()
            {
                ID = "PH12345", 
                Name = "Nguyễn Văn A",
                Credits = 40,
                Avatar = "Images/4.jpg",
                Amount = 2000000
            };
            this.DataContext = sv; // Thực hiện hàn gắn Entity với Màn hình
        }
    }
}
