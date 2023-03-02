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
    /// Interakční logika pro MujKosik.xaml
    /// </summary>
    public partial class MujKosik : Window
    {
        //Konstruktor + přidělání existující třídy
        public SpravceNakupu spravceNakupu;
        public Rezervace rezervace;
        public MujKosik(SpravceNakupu spravceNakupu)
        {
            InitializeComponent();
            this.spravceNakupu = spravceNakupu;
            DataContext = spravceNakupu;
            //Vypsání jestli je rezervace
            if (spravceNakupu.Kontrola == 1)
            {
                if (spravceNakupu.Stul1 == 1)
                {
                    text.Text = "Rezervovali jste si stůl číslo 1 na den: ";
                }
                else if (spravceNakupu.Stul2 == 1)
                {
                    text.Text = "Rezervovali jste si stůl číslo 2 na den: ";
                }
                else if (spravceNakupu.Stul3 == 1)
                {
                    text.Text = "Rezervovali jste si stůl číslo 3 na den: ";
                }
                else if (spravceNakupu.Stul4 == 1)
                {
                    text.Text = "Rezervovali jste si stůl číslo 4 na den: ";
                }
            }
        }
        //Vypnutí
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        //Odstranění
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (nakupListBox.SelectedItem != null)
            {
                spravceNakupu.OddelejNakup((Nakup)nakupListBox.SelectedItem);
            }
        }
        //Oddělání rezervace
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            text.Text = "";
            spravceNakupu.Stul1 = 0;
            spravceNakupu.Stul2 = 0;
            spravceNakupu.Stul3 = 0;
            spravceNakupu.Stul4 = 0;
            spravceNakupu.Datumm = null;
            textik.Text = "";

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Zaplatit ZaplatitWindow = new Zaplatit(spravceNakupu);
            ZaplatitWindow.ShowDialog();
        }
    }
}
