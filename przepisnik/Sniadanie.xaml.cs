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
using System.Windows.Shapes;

namespace przepisnik
{
    /// <summary>
    /// Interaction logic for Sniadanie.xaml
    /// </summary>
    public partial class Sniadanie : Window
    {
        public Sniadanie()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            fdViewer.Find();
        }

        private void Wyjdz_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        
    }
}
