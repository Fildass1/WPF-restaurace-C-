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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RocnikovkaPokus2
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    /// Vytvoření
    public partial class MainWindow : Window
    {
        //Vytvoření nových oken
        Podpora PodporaWindow = new Podpora();
        
        PlanekBudovy PlanBudovyWindow = new PlanekBudovy();
        
        public SpravceNakupu spravceNakupu;
        public MainWindow()
        //konstruktor + data kontext
        {
            InitializeComponent();
            spravceNakupu = new SpravceNakupu();
            DataContext = spravceNakupu;
        }

        //Po zmáčknutí tlačítka se objeví nové okno
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Objednat ObjednatWindow = new Objednat(spravceNakupu);
            ObjednatWindow.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Rezervace RezervaceWindow = new Rezervace(spravceNakupu);
            RezervaceWindow.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            PodporaWindow.ShowDialog();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MujKosik MujKosikWindow = new MujKosik(spravceNakupu);
            MujKosikWindow.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            PlanBudovyWindow.ShowDialog();
        }

        //Program se ukončí
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Zaplatit ZaplatitWindow = new Zaplatit(spravceNakupu);
            ZaplatitWindow.ShowDialog();
        }
    }
}
