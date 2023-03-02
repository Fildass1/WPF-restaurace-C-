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
    /// Interakční logika pro Rezervace.xaml
    /// </summary>
    public partial class Rezervace : Window
    {
        public SpravceNakupu spravceNakupu;
        //Konstruktor + existující třída
        public Rezervace(SpravceNakupu spravceNakupu)
        {
            InitializeComponent();
            this.spravceNakupu = spravceNakupu;
            DataContext = spravceNakupu;
        }
        //Vybarvení tlačítek podle toho které je vybrané + informace k realizování rezervace
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Bstul1.Background = new SolidColorBrush(Colors.Green);
            Bstul2.Background = new SolidColorBrush(Colors.LightGray);
            Bstul3.Background = new SolidColorBrush(Colors.LightGray);
            Bstul4.Background = new SolidColorBrush(Colors.LightGray);
            spravceNakupu.Stul1 = 1;
            spravceNakupu.Stul2 = 0;
            spravceNakupu.Stul3 = 0;
            spravceNakupu.Stul4 = 0;
        }

        private void Bstul2_Click(object sender, RoutedEventArgs e)
        {
            Bstul1.Background = new SolidColorBrush(Colors.LightGray);
            Bstul2.Background = new SolidColorBrush(Colors.Green);
            Bstul3.Background = new SolidColorBrush(Colors.LightGray);
            Bstul4.Background = new SolidColorBrush(Colors.LightGray);
            spravceNakupu.Stul1 = 0;
            spravceNakupu.Stul2 = 1;
            spravceNakupu.Stul3 = 0;
            spravceNakupu.Stul4 = 0;
        }

        private void Bstul3_Click(object sender, RoutedEventArgs e)
        {
            Bstul1.Background = new SolidColorBrush(Colors.LightGray);
            Bstul2.Background = new SolidColorBrush(Colors.LightGray);
            Bstul3.Background = new SolidColorBrush(Colors.Green);
            Bstul4.Background = new SolidColorBrush(Colors.LightGray);
            spravceNakupu.Stul1 = 0;
            spravceNakupu.Stul2 = 0;
            spravceNakupu.Stul3 = 1;
            spravceNakupu.Stul4 = 0;
        }

        private void Bstul4_Click(object sender, RoutedEventArgs e)
        {
            Bstul1.Background = new SolidColorBrush(Colors.LightGray);
            Bstul2.Background = new SolidColorBrush(Colors.LightGray);
            Bstul3.Background = new SolidColorBrush(Colors.LightGray);
            Bstul4.Background = new SolidColorBrush(Colors.Green);
            spravceNakupu.Stul1 = 0;
            spravceNakupu.Stul2 = 0;
            spravceNakupu.Stul3 = 0;
            spravceNakupu.Stul4 = 1;
        }
        //Kontrola jestli se nevybral špatný datum + jeho vybrání
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (spravceNakupu.DnesniDatum < datepiko.SelectedDate)
            {
                spravceNakupu.Kontrola = 1;
                spravceNakupu.Datumm = datepiko.SelectedDate;
                if (MessageBox.Show("Úspěšně jste si zarezervovali.", "Rezervace", MessageBoxButton.OK) == MessageBoxResult.OK)
                {
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Zadali jste neplatné datum :(");
            }

        }
        //Zavřít
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
