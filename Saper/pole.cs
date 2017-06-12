using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saper
{
    class pole
    {
        private bool czy_odkryte { get; set; }
        private bool czy_oznaczone { get; set; }
        [Flags]
        public enum typ_pola
        {
            puste = 0,
            bomba = 1,
            ma_sasiadow = 2, //pola sasiadujace maja bombe
           
        }
        private typ_pola typ { get; set; }
        int liczba_sasiadow { get; set; }
        public typ_pola leftClick()
        {
            this.czy_odkryte = true;

            return this.typ;
        }

        public void rightClick()
        {
            this.czy_oznaczone = !this.czy_oznaczone; //przypisuje przeciwna wartosc do obecnej
        }
    }
}
