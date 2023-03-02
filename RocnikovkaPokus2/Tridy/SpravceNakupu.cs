using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocnikovkaPokus2
{
    //Vytvoření správce nákupu
    public class SpravceNakupu : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<Nakup> Seznam { get; set; }
        public Nakup CelkovaCena { get; set; }
        public DateTime? Datumm { set; get; }
        public DateTime DnesniDatum { get {
                return DateTime.Now;
            } }
        public string Cas { get; set; }
        public int Stul1 { get; set; }
        public int Stul2 { get; set; }
        public int Stul3 { get; set; }
        public int Stul4 { get; set; }
        public int Kontrola { get; set; }
        //Konstruktor
        public SpravceNakupu()
        {
            Seznam = new ObservableCollection<Nakup>();
            CelkovaCena = new Nakup("Ajo",0);
        }
        //Přidání do observable kolekce
        public void PridejNakup(string jmeno, int cena)
        {
            Nakup nakup = new Nakup(jmeno, cena);
            Seznam.Add(nakup);
            VypocitejCelkovou();
        }
        //Oddělání z observable kolekce
        public void OddelejNakup(Nakup nakup)
        {
            Seznam.Remove(nakup);
            VypocitejCelkovou();
        }
        //Vypočítání celkové ceny
        public void VypocitejCelkovou()
        {
            int celkem = 0;
            if (Seznam.Count() > 0)
            {
                for (int i = 0; i < Seznam.Count(); i++)
                {
                    celkem += Seznam[i].Cena;
                }
            }
            CelkovaCena.Cena = celkem;
            VyvolejZmenu("CelkovaCena");
        }
        //I Notify Property Changed
        public void VyvolejZmenu(string vlastnost)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(vlastnost));
            }
        }
    }
}
