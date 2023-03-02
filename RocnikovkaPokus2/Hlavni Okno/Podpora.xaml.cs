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
using System.Windows.Shapes;

namespace RocnikovkaPokus2
{
    /// <summary>
    /// Interakční logika pro Podpora.xaml
    /// </summary>
    public partial class Podpora : Window
    {
        public Podpora()
        {
            InitializeComponent();
        }

        //Kontrola požadavku
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (A.Text != "" & B.Text != "")
            {
                MessageBox.Show("Úspěšně jste odeslali požadavek");
                A.Text = "";
                B.Text = "";
                Close();
            }
            else
            {
                MessageBox.Show("Špatně jste vyplnil nějaké políčko");
            }
        }
        //Zavřít
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
