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
    /// Interakční logika pro Prilohy.xaml
    /// </summary>
    public partial class Prilohy : Window
    {
        public SpravceNakupu spravceNakupu;
        //Konstruktor + ...
        public Prilohy(SpravceNakupu spravceNakupu)
        {
            InitializeComponent();
            this.spravceNakupu = spravceNakupu;
        }

        //Přidání do Observable collection + upozornění
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            spravceNakupu.PridejNakup("Hranolky", 30);
            MessageBox.Show("Úspěšně jsi přidal do košíku.");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            spravceNakupu.PridejNakup("Kečup", 10);
            MessageBox.Show("Úspěšně jsi přidal do košíku.");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            spravceNakupu.PridejNakup("Tatarka", 9);
            MessageBox.Show("Úspěšně jsi přidal do košíku.");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            spravceNakupu.PridejNakup("Hořčice", 5);
            MessageBox.Show("Úspěšně jsi přidal do košíku.");
        }

        //Nové okna
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Hranolky hranolky = new Hranolky();
            hranolky.ShowDialog();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Kecup kecup = new Kecup();
            kecup.ShowDialog();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Tatarka tatarka = new Tatarka();
            tatarka.ShowDialog();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Horcice horcice = new Horcice();
            horcice.ShowDialog();
        }
        //Zavřít
        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
