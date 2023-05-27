using models;
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

namespace _10_00_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Vierkant _vierkant = null;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnInitialiseer_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(txtZijde.Text, out int zijde))
            {
                MessageBox.Show("Geef een getal in.");
                return;
            }

            _vierkant = new Vierkant(zijde);
        }

        private void btnTeken_Click(object sender, RoutedEventArgs e)
        {
            if (_vierkant != null)
            {
                lblOutput.Content = _vierkant.Teken();
            }
        }

        private void btnOmtrek_Click(object sender, RoutedEventArgs e)
        {
            lblOutput.Content = _vierkant.Omtrek();
        }

        private void btnOppervlakte_Click(object sender, RoutedEventArgs e)
        {
            lblOutput.Content = _vierkant.Oppervlakte();
        }

        private void Diagonaal_Click(object sender, RoutedEventArgs e)
        {
            lblOutput.Content = _vierkant.Diagonaal();
        }
    }
}
