using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Saper
{
    [Flags]
    public enum typ_pola
    {
        typ_null=-1,
        puste = 0,
        bomba = 1,
        ma_sasiadow = 2, //pola sasiadujace maja bombe

    }
    class pole
    {
        private int x;
        private int y;
        private bool _czy_odkryte;
        public bool czy_odkryte
        {
            get { return this._czy_odkryte; }
            set { this._czy_odkryte = value; }
        }
        private int _czy_oznaczone;
        public int czy_oznaczone
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
       
        public pole(int x, int y)
        {
            this.czy_odkryte = false;
            this.czy_oznaczone = 0;
            this.typ = typ_pola.puste;
            this.liczba_sasiadow = 0;
            this.x = x;
            this.y = y;
           
        }

       

        public typ_pola leftClick()
        {
            if (this.czy_odkryte == true)
                return Saper.typ_pola.typ_null;
            this._czy_odkryte = true;
            Saper.Program.Gra.siatka.FillRectangle(Saper.Program.Gra.myBrush_odkryte, this.x * 20, this.y * 20, 20, 20);
            Saper.Program.Gra.siatka.DrawRectangle(Saper.Program.Gra.myPen, this.x * 20, this.y * 20, 20, 20);
            if (this.typ == Saper.typ_pola.bomba)

                Saper.Program.Gra.siatka.DrawImage(Saper.Program.Gra.bomba, new Point { X = this.x * 20, Y = this.y * 20 }); 
            else
            {
                switch (this.liczba_sasiadow)
                {
                    case 1:
                        Saper.Program.Gra.siatka.DrawString(this.liczba_sasiadow.ToString(), Saper.Program.Gra.myFont, Brushes.MediumBlue, this.x * 20 + 20 / 8, this.y * 20 + 20 / 25);
                        break;
                    case 2:
                        Saper.Program.Gra.siatka.DrawString(this.liczba_sasiadow.ToString(), Saper.Program.Gra.myFont, Brushes.Green, this.x * 20 + 20 / 8, this.y * 20 + 20 / 25);
                        break;
                    case 3:
                        Saper.Program.Gra.siatka.DrawString(this.liczba_sasiadow.ToString(), Saper.Program.Gra.myFont, Brushes.Red, this.x * 20 + 20 / 8, this.y * 20 + 20 / 25);
                        break;
                    case 4:
                        Saper.Program.Gra.siatka.DrawString(this.liczba_sasiadow.ToString(), Saper.Program.Gra.myFont, Brushes.Navy, this.x * 20 + 20 / 8, this.y * 20 + 20 / 25);
                        break;
                    case 5:
                        Saper.Program.Gra.siatka.DrawString(this.liczba_sasiadow.ToString(), Saper.Program.Gra.myFont, Brushes.Maroon, this.x * 20 + 20 / 8, this.y * 20 + 20 / 25);
                        break;
                    case 6:
                        Saper.Program.Gra.siatka.DrawString(this.liczba_sasiadow.ToString(), Saper.Program.Gra.myFont, Brushes.DarkCyan, this.x * 20 + 20 / 8, this.y * 20 + 20 / 25);
                        break;
                    case 7:
                        Saper.Program.Gra.siatka.DrawString(this.liczba_sasiadow.ToString(), Saper.Program.Gra.myFont, Brushes.Purple, this.x * 20 + 20 / 8, this.y * 20 + 20 / 25);
                        break;
                    case 8:
                        Saper.Program.Gra.siatka.DrawString(this.liczba_sasiadow.ToString(), Saper.Program.Gra.myFont, Brushes.Gold, this.x * 20 + 20 / 8, this.y * 20 + 20 / 25);
                        break;
                }


            }
            return this._typ;
        }

        public void rightClick()
        {
            if (this.czy_odkryte == true)
                return;
            this._czy_oznaczone = (this._czy_oznaczone+1)%3; //przypisuje przeciwna wartosc do obecnej
            switch (this.czy_oznaczone)
            {
                case 0:
                    Saper.Program.Gra.siatka.FillRectangle(Saper.Program.Gra.myBrush_zakryte, this.x * 20, this.y * 20, 20, 20);
                    Saper.Program.Gra.siatka.DrawRectangle(Saper.Program.Gra.myPen, this.x * 20, this.y * 20, 20, 20);
                    
                    break;
                case 1:
                    Saper.Program.Gra.siatka.FillRectangle(Saper.Program.Gra.myBrush_zakryte, this.x * 20, this.y * 20, 20, 20);
                    Saper.Program.Gra.siatka.DrawRectangle(Saper.Program.Gra.myPen, this.x * 20, this.y * 20, 20, 20);
                    Saper.Program.Gra.siatka.DrawImage(Saper.Program.Gra.flaga, new Point { X = this.x * 20, Y = this.y * 20 });
                    break;
                case 2:
                    Saper.Program.Gra.siatka.FillRectangle(Saper.Program.Gra.myBrush_zakryte, this.x * 20, this.y * 20, 20, 20);
                    Saper.Program.Gra.siatka.DrawRectangle(Saper.Program.Gra.myPen, this.x * 20, this.y * 20, 20, 20);
                    Saper.Program.Gra.siatka.DrawString("?", Saper.Program.Gra.myFont, Brushes.Black, this.x * 20 + 20 / 8, this.y * 20 + 20 / 25);
                    break;
            }
        }
    }
}
