using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saper
{
    [Flags]
    public enum typ_pola
    {
        puste = 0,
        bomba = 1,
        ma_sasiadow = 2, //pola sasiadujace maja bombe

    }
    class pole
    {
        private bool _czy_odkryte;
        public bool czy_odkryte
        {
            get { return this._czy_odkryte; }
            set { this._czy_odkryte = value; }
        }
        private bool _czy_oznaczone;
        public bool czy_oznaczone
        {
            get { return this._czy_oznaczone; }
            set { this._czy_oznaczone = value; }
        }
       
        private typ_pola _typ;
        public  typ_pola typ
        {
            get { return this._typ; }
            set { this._typ = value; }
        }
        int _liczba_sasiadow;
        public int liczba_sasiadow
        {
            get { return this._liczba_sasiadow; }
            set { this._liczba_sasiadow = value; }
        }
        public pole()
        {
            this.czy_odkryte = false;
            this.czy_oznaczone = false;
            this.typ = typ_pola.puste;
            this.liczba_sasiadow = 0;
        }
        public typ_pola leftClick()
        {
            this._czy_odkryte = true;

            return this._typ;
        }

        public void rightClick()
        {
            this._czy_oznaczone = !this._czy_oznaczone; //przypisuje przeciwna wartosc do obecnej
        }
    }
}
