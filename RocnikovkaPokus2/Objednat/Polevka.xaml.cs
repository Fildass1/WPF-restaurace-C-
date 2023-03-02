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
    /// Interakční logika pro Polevka.xaml
    /// </summary>
    public partial class Polevka : Window
    {
        public SpravceNakupu spravceNakupu;
        //konstruktor + ...
        public Polevka(SpravceNakupu spravceNakupu)
        {
            InitializeComponent();
            this.spravceNakupu = spravceNakupu;
        }

        //Přidání do Observable collection + upozornění
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            spravceNakupu.PridejNakup("Česnečka", 645);
            MessageBox.Show("Úspěšně jsi přidal do košíku.");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            spravceNakupu.PridejNakup("Slepičí vývar", 66);
            MessageBox.Show("Úspěšně jsi přidal do košíku.");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            spravceNakupu.PridejNakup("Guláš", 123);
            MessageBox.Show("Úspěšně jsi přidal do košíku.");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            spravceNakupu.PridejNakup("Polévka smrti", 666);
            MessageBox.Show("Úspěšně jsi přidal do košíku.");
        }

        //Nové okna
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Cesnecka cesnecka = new Cesnecka();
            cesnecka.ShowDialog();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            SlepiciVyvar slepicivyvar = new SlepiciVyvar();
            slepicivyvar.ShowDialog();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Gulas gulas = new Gulas();
            gulas.ShowDialog();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            PolevkaSmrti polevkasmrti = new PolevkaSmrti();
            polevkasmrti.ShowDialog();
        }

        //Zavřít
        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
