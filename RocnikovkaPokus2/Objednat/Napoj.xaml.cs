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
    /// Interakční logika pro Napoj.xaml
    /// </summary>
    public partial class Napoj : Window
    {
        public SpravceNakupu spravceNakupu;
        //Konstruktor + ...
        public Napoj(SpravceNakupu spravceNakupu)
        {
            InitializeComponent();
            this.spravceNakupu = spravceNakupu;
        }

        //Přidání do Observable collection + upozornění
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            spravceNakupu.PridejNakup("Kofola", 15);
            MessageBox.Show("Úspěšně jsi přidal do košíku.");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            spravceNakupu.PridejNakup("Pivson", 30);
            MessageBox.Show("Úspěšně jsi přidal do košíku.");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            spravceNakupu.PridejNakup("Vínečko", 100);
            MessageBox.Show("Úspěšně jsi přidal do košíku.");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            spravceNakupu.PridejNakup("Vinea", 23);
            MessageBox.Show("Úspěšně jsi přidal do košíku.");
        }

        //Vytvoření dalších oken
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Kofola kofola = new Kofola();
            kofola.ShowDialog();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Pivson pivson = new Pivson();
            pivson.ShowDialog();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Vinecko vinecko = new Vinecko();
            vinecko.ShowDialog();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Vinea vinea = new Vinea();
            vinea.ShowDialog();
        }

        //Zavřít
        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
