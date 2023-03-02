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
    /// Interakční logika pro Objednat.xaml
    /// </summary>
    public partial class Objednat : Window
    {
        //Konstruktor + existující třída
        public SpravceNakupu spravceNakupu;
        public Objednat(SpravceNakupu spravceNakupu)
        {
            InitializeComponent();
            this.spravceNakupu = spravceNakupu;
        }
        //Další okna
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            HlavniChod hlavniChod = new HlavniChod(spravceNakupu);
            hlavniChod.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Predkrm predrkm = new Predkrm(spravceNakupu);
            predrkm.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Polevka polevka = new Polevka(spravceNakupu);
            polevka.ShowDialog();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Moucnik moucnik = new Moucnik(spravceNakupu);
            moucnik.ShowDialog();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Prilohy prilohy = new Prilohy(spravceNakupu);
            prilohy.ShowDialog();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Napoj napoj = new Napoj(spravceNakupu);
            napoj.ShowDialog();
        }
        //Zavření

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Close();
        }
        
    }
}
