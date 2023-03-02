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
    /// Interakční logika pro Zaplatit.xaml
    /// </summary>
    public partial class Zaplatit : Window
    {
        public SpravceNakupu spravceNakupu;
        //Kontruktor + ...
        public Zaplatit(SpravceNakupu spravceNakupu)
        {
            InitializeComponent();
            this.spravceNakupu = spravceNakupu;
            DataContext = spravceNakupu;
        }
        //Kontrola vyplnění formulářů
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (A.Text != "" & B.Text != "" & C.Text != "" & D.Text != "" & E.Text != "" & F.Text != "" & G.Text != "")
            {
                if (MessageBox.Show("Úspěšně jste zaplatili", "Platba", MessageBoxButton.OK) == MessageBoxResult.OK)
                {
                    System.Windows.Application.Current.Shutdown();
                }
            }
            else
            {
                MessageBox.Show("Špatně jste vyplnil nějaké políčko", "Upozornění");
            }
        }
        //Zavřít
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
