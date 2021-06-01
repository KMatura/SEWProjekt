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

namespace SEW_Projekt
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            var rand = new Random();
            Adresse a1 = new Adresse("Währinger Straße", "112", "Wien", "1180", "Österreich");
            Kunde k1 = new Kunde("Maximilian", "Schuller", Convert.ToString(rand.Next(1000,10000)),"Passwort", DateTime.Now, a1);
            InitializeComponent();
        }
    }

}
