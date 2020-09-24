using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Security.Cryptography;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DrugApp
{
    /// <summary>
    /// Logique d'interaction pour Affichage.xaml
    /// </summary>
  
    public partial class Affichage : Window
    {
      
        public ObservableCollection<Medicament> medicaments;

        public Affichage()
        {
            InitializeComponent();
            medicaments = new ObservableCollection<Medicament>();
            list.ItemsSource = medicaments;



        }
    }
}
