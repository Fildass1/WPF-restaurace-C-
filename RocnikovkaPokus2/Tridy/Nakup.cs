using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocnikovkaPokus2
{
    //Vytvoření třídy
    public class Nakup
    {
        public string Name { get; set; }
        public int Cena { get; set; }
        //Konstruktor
        public Nakup(string name, int cena)
        {
            Name = name;
            Cena = cena;
        }
        //Vypsání
        public override string ToString()
        {
            string vysledek = Name +"   " +Cena.ToString()+" Kč";
            return vysledek;
        }
    }
}
