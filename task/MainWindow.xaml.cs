﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
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

namespace task
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TcpClient tcpClient;
        NetworkStream netstream;
        public SynchronizationContext uiContext;

        public MainWindow()
        {
            InitializeComponent();
            // center screen
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            // get ui context
            uiContext = SynchronizationContext.Current;
        }
    }
}
