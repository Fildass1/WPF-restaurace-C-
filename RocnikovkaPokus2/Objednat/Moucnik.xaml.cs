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
    /// Interakční logika pro Moucnik.xaml
    /// </summary>
    public partial class Moucnik : Window
    {
        public SpravceNakupu spravceNakupu;
        //Konstruktor
        public Moucnik(SpravceNakupu spravceNakupu)
        {
            InitializeComponent();
            this.spravceNakupu = spravceNakupu;
        }
        //Přidání do Observable collection + upozornění
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            spravceNakupu.PridejNakup("Cheesecake", 250);
            MessageBox.Show("Úspěšně jsi přidal do košíku.");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            spravceNakupu.PridejNakup("Kapučino řezy", 145);
            MessageBox.Show("Úspěšně jsi přidal do košíku.");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            spravceNakupu.PridejNakup("Tartaletky", 360);
            MessageBox.Show("Úspěšně jsi přidal do košíku.");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            spravceNakupu.PridejNakup("Sušenky", 444);
            MessageBox.Show("Úspěšně jsi přidal do košíku.");
        }

        //Vytvoření dalších oken
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Cheesecakes cheesecakes = new Cheesecakes();
            cheesecakes.ShowDialog();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Kapucino kapucino = new Kapucino();
            kapucino.ShowDialog();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Tartaletky tartaletky = new Tartaletky();
            tartaletky.ShowDialog();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Susenky susenky = new Susenky();
            susenky.ShowDialog();
        }
        //Zavření
        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            Close();
        }

    }
}