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
    /// Interakční logika pro HlavniChod.xaml
    /// </summary>
    public partial class HlavniChod : Window
    {
        public SpravceNakupu spravceNakupu;
        public HlavniChod(SpravceNakupu spravceNakupu)
        {
            InitializeComponent();
            this.spravceNakupu = spravceNakupu;
        }
        //Přidání do Observable collection + upozornění
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            spravceNakupu.PridejNakup("Kuřecí řízek", 250);
            MessageBox.Show("Úspěšně jsi přidal do košíku.");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            spravceNakupu.PridejNakup("Buchtičky", 100);
            MessageBox.Show("Úspěšně jsi přidal do košíku.");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            spravceNakupu.PridejNakup("Hovězí kostky", 666);
            MessageBox.Show("Úspěšně jsi přidal do košíku.");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            spravceNakupu.PridejNakup("Hermelín", 999);
            MessageBox.Show("Úspěšně jsi přidal do košíku.");
        }

        //Vytvoření dalších oken
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Jidlo rizek = new Jidlo();
            rizek.ShowDialog();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Buchticky buchticky = new Buchticky();
            buchticky.ShowDialog();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Hovezi hovezi = new Hovezi();
            hovezi.ShowDialog();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Hermelin hermelin = new Hermelin();
            hermelin.ShowDialog();
        }
        //Zavřít
        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
