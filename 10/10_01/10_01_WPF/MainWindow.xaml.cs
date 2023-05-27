using models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace _10_01_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Werknemer _werknemer = null;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnToevoegen_Click(object sender, RoutedEventArgs e)
        {
            List<Werknemer> lijstwerknemer = new List<Werknemer>();

            string voornaam = txtVoornaam.Text;
            string achternaam = txtAchterNaam.Text;

            if (!double.TryParse(txtLoon.Text, out double loon) || txtVoornaam.Text == "" || txtAchterNaam.Text == "")
            {
                MessageBox.Show("Vul alle gegevens correct in");
                return;
            }

            _werknemer = new Werknemer(voornaam, achternaam, loon);
            lijstwerknemer.Add(_werknemer);

            foreach (Werknemer werknemer in lijstwerknemer)
            {
                string werknemerGegevens = $"Mijn naam is {werknemer.Achternaam} {werknemer.Achternaam} mijn loon bedraagt:  {werknemer.Loon} euro/uur.";
                txtWerknemers.Text += werknemerGegevens + Environment.NewLine;
            }

            txtVoornaam.Clear();
            txtAchterNaam.Clear();
            txtLoon.Clear();
        }
    }
}
