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

namespace Membership
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IMember user = null;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            user = new PremiumMember();
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            user = new NormalMember();
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            if (user == null)
            {
                MessageBox.Show("not a member");
                return;
            }

            MessageBox.Show(user.Play());
        }
    }
}
