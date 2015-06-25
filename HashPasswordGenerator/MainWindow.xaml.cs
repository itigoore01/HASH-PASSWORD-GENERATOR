﻿using HashPasswordGenerator.ViewModels;
using Microsoft.AspNet.Identity;
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

namespace HashPasswordGenerator
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow 
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void generationButton_Click(object sender, RoutedEventArgs e)
        {
            var hasher = new PasswordHasher();

            viewModel.HashPassword = hasher.HashPassword(viewModel.Password);
            hashPasswordTextBox.Focus();

            if (viewModel.AutoCopy)
                System.Windows.Clipboard.SetText(viewModel.HashPassword);
        }

        private void hashPasswordTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            hashPasswordTextBox.SelectAll();
        }
    }
}
