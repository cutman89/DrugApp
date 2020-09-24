using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using SQLite;
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
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace DrugApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        bool _exist;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int number;
            bool succes;
            SQLiteConnection connection = new SQLiteConnection(App.databasePath);
            Medicament medicament = new Medicament();
            HashCode hc = new HashCode();
            if (numero.Text != string.Empty && nom.Text != string.Empty && molecule.Text != string.Empty && posologie.Text != string.Empty && contreindication.Text != string.Empty)
            {
                succes = int.TryParse(numero.Text,out number);
                if (succes)
                {
                    medicament.Numero = int.Parse(numero.Text);
                    medicament.Nom = HashCode.Encrypt(nom.Text);
                    medicament.Molecule = HashCode.Encrypt(molecule.Text);
                    medicament.Posologie = HashCode.Encrypt(posologie.Text);
                    medicament.Contre_Indication = HashCode.Encrypt(contreindication.Text);
                    connection.CreateTable<Medicament>();
                    connection.Insert(medicament);
                    MessageBox.Show("Medicament Added");
                }
                else
                {
                    MessageBox.Show("value is not an integer");
                }
              
            }
            else 
            {
                MessageBox.Show("Empty fileds");
            }
            connection.Close();
            numero.Text = string.Empty;
            nom.Text = string.Empty;
            molecule.Text = string.Empty;
            posologie.Text = string.Empty;
            contreindication.Text = string.Empty;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            SQLiteConnection connection = new SQLiteConnection(App.databasePath);
            connection.CreateTable<Medicament>();
            Affichage affichage = new Affichage();

            var output = connection.Query<Medicament>("select * from medicament");

            if (output.Count > 0)
            {
                foreach (var value in output)
                {
                    string nomDecrypte = HashCode.Decrypt(value.Nom);
                    string moleculeDecrypte = HashCode.Decrypt(value.Molecule);
                    string posologieDecrypte = HashCode.Decrypt(value.Posologie);
                    string contreIndicationDecrypte = HashCode.Decrypt(value.Contre_Indication);

                    affichage.medicaments.Add(new Medicament
                    {
                        Numero = value.Numero,
                        Nom = nomDecrypte,
                        Molecule = moleculeDecrypte,
                        Posologie = posologieDecrypte,
                        Contre_Indication = contreIndicationDecrypte

                    });


                }
                affichage.Show();

            }
            else
            {
                MessageBox.Show("Empty Data");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            _exist = false;
            Affichage affichage = new Affichage();
            SQLiteConnection connection = new SQLiteConnection(App.databasePath);
            connection.CreateTable<Medicament>();
            var output = connection.Query<Medicament>("select * from medicament");
            string sql = "DELETE FROM medicament where Medicament.Numero= " + numero.Text;
           
            var comm = connection.CreateCommand(sql);
            try
            {
                if (output.Count > 0)
                {
                    foreach (var value in output)
                    {


                        if (numero.Text == value.Numero.ToString())
                        {
                            comm.ExecuteNonQuery();
                            MessageBox.Show("Deleted...");
                            _exist = true;
                            break;

                        }
                        else
                        {
                            continue;
                        }

                    }

                    if (_exist == false)
                    {
                        MessageBox.Show("input doesnt exist");
                    }
                }
                else
                {
                    MessageBox.Show("Empty Data");
                }

            }
            catch (Exception x)
            {
                MessageBox.Show("Not Deleted");
            }
            finally
            {
                connection.Close();
            }

            numero.Text = string.Empty;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            _exist = false;
            ModifiyDrugInformation drugModify = new ModifiyDrugInformation();
            SQLiteConnection connection = new SQLiteConnection(App.databasePath);
            connection.CreateTable<Medicament>();
            try
            {

                var output = connection.Query<Medicament>("select * from medicament where Medicament.Numero= " + numero.Text);
                var output1 = connection.Query<Medicament>("select * from medicament");
                if (output1.Count > 0)
                {
                    foreach (var value in output)
                    {
                   
                        if (numero.Text == value.Numero.ToString())
                        {
                            drugModify.numero.Text = value.Numero.ToString();
                            drugModify.nom.Text = HashCode.Decrypt(value.Nom);
                            drugModify.molecule.Text = HashCode.Decrypt(value.Molecule);
                            drugModify.posologie.Text = HashCode.Decrypt(value.Posologie);
                            drugModify.contreindication.Text = HashCode.Decrypt(value.Contre_Indication);
                            _exist = true;
                        }
                    }
                   
                    if (_exist == true)
                    {
                        drugModify.Show();
                    }
                    else
                    {
                        MessageBox.Show("input doesn't exist");
                    }
                

                }
                else
                {
                    MessageBox.Show("Empty Data");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("empty fileds");
            }

            finally
            {
                connection.Close();
            }

        }
    }
}
