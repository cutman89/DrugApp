using SQLite;
using System;
using System.Collections.Generic;
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
    /// Logique d'interaction pour ModifiyDrugInformation.xaml
    /// </summary>
    public partial class ModifiyDrugInformation : Window
    {
        public ModifiyDrugInformation()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SQLiteConnection connection = new SQLiteConnection(App.databasePath);
            Medicament medicament = new Medicament();
            connection.CreateTable<Medicament>();
            try
            {
                var output = connection.Query<Medicament>($"update medicament Set Nom='{HashCode.Encrypt(nom.Text)}', Molecule='{HashCode.Encrypt(molecule.Text)}',Posologie='{HashCode.Encrypt(posologie.Text)}',Contre_Indication='{HashCode.Encrypt(contreindication.Text)}'  where Medicament.Numero= " + numero.Text);
                MessageBox.Show("Drug information modifyed");
            }
            catch (Exception x)
            {
                MessageBox.Show("Doesnt exist" + x.Message);
            }
            finally
            {
                connection.Close();
            }
          
        }
    }
}
