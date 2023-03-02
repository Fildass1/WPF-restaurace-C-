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
    /// Interakční logika pro Predkrm.xaml
    /// </summary>
    public partial class Predkrm : Window
    {
        public SpravceNakupu spravceNakupu;
        //Konstruktor + ...
        public Predkrm(SpravceNakupu spravceNakupu)
        {
            InitializeComponent();
            this.spravceNakupu = spravceNakupu;
        }

        //Přidání do Observable collection + upozornění
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            spravceNakupu.PridejNakup("Tyčinky", 145);
            MessageBox.Show("Úspěšně jsi přidal do košíku.");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            spravceNakupu.PridejNakup("Sushi sandvič", 100);
            MessageBox.Show("Úspěšně jsi přidal do košíku.");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            spravceNakupu.PridejNakup("Košíčky", 200);
            MessageBox.Show("Úspěšně jsi přidal do košíku.");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            spravceNakupu.PridejNakup("Pirožky", 30);
            MessageBox.Show("Úspěšně jsi přidal do košíku.");
        }

        //Nové okna
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Tycinky tycinky = new Tycinky();
            tycinky.ShowDialog();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            SuschiSandvic sushisandvic = new SuschiSandvic();
            sushisandvic.ShowDialog();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Kosicky kosicky = new Kosicky();
            kosicky.ShowDialog();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Pirozky pirozky = new Pirozky();
            pirozky.ShowDialog();
        }

        //Zavřít
        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
