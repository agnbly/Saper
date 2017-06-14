using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Saper
{
    public partial class Form1 : Form
    {
        private static Stopwatch sw;
        private pole[,] komorka;
        private int _szerokosc;
        private int _wysokosc;
        private int _liczba_bomb;
        private Opcje_gry Opcje;
        private Graphics siatka;
        private Pen myPen;
        private Font myFont;
        public int szerokosc
        {
            get { return this._szerokosc; }
            set { this._szerokosc = value; }
        }
        public int wysokosc
        {
            get { return this._wysokosc; }
            set { this._wysokosc = value; }
        }
        public int liczba_bomb
        {
            get { return this._liczba_bomb; }
            set { this._liczba_bomb = value; }
        }
        public Form1()
        {
            
            this.Opcje = new Opcje_gry();
            InitializeComponent();
            this.siatka = plansza.CreateGraphics();
            this.myPen = new Pen(Brushes.LightGray, 2);
            this.myFont = new Font("Consolas", 12);
            sw = new Stopwatch();
            
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

       private void timer_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer.Text = sw.Elapsed.ToString("mm\\:ss");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void nowaGraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Opcje.ShowDialog(this);
            
        }

        public void Rozpocznij_Gre()
        {
            this.Width = 79 + 20 * this.szerokosc;
            this.Height = 126 + 20 * this.wysokosc;
            plansza.Width = 20 * this.szerokosc + 1;
            plansza.Height = 20 * this.wysokosc + 1;
            this.siatka = plansza.CreateGraphics();
            sw.Reset();
            this.komorka = null;
            this.siatka.Clear(Color.DarkGray);
            this.komorka = new pole[this.szerokosc, this.wysokosc];
            for (int i = 0; i < this.szerokosc; i++)
                for (int j = 0; j < this.wysokosc; j++)
                    this.komorka[i, j] = new pole();
            this.losujBomby();
            this.przygotujPlansze();
            sw.Start();
        }
        private void przygotujPlansze()
        {
            

            float x = 0f, y = 0f;
            float szerokosc_komorki = plansza.Width / this.szerokosc;
            float wysokosc_komorki = plansza.Height / this.wysokosc;

            //pionowe linie
            for (int i = 0; i <= this.szerokosc; i++)
            {
                this.siatka.DrawLine(this.myPen, x, y, x, plansza.Height);
                x += szerokosc_komorki;
            }
            //poziome linie
            x = 0f;
            y = 0f;
            for (int i = 0; i <= this.wysokosc; i++)
            {
                this.siatka.DrawLine(this.myPen, x, y, plansza.Width, y);
                y += wysokosc_komorki;
            }
            for(int i =0; i<this.szerokosc;i++)
                for(int j=0; j < this.wysokosc; j++)
                {
                    if (this.komorka[i, j].typ == Saper.typ_pola.bomba)

                        this.siatka.DrawString("x", this.myFont, Brushes.Black, i * szerokosc_komorki + szerokosc_komorki / 8, j * wysokosc_komorki + wysokosc_komorki / 25);
                    else
                    {
                        switch(this.komorka[i,j].liczba_sasiadow)
                        {
                            case 1:
                                this.siatka.DrawString(this.komorka[i, j].liczba_sasiadow.ToString(), this.myFont, Brushes.MediumBlue, i * szerokosc_komorki + szerokosc_komorki / 8, j * wysokosc_komorki + wysokosc_komorki / 25);
                                break;
                            case 2:
                                this.siatka.DrawString(this.komorka[i, j].liczba_sasiadow.ToString(), this.myFont, Brushes.Green, i * szerokosc_komorki + szerokosc_komorki / 8, j * wysokosc_komorki + wysokosc_komorki / 25);
                                break;
                            case 3:
                                this.siatka.DrawString(this.komorka[i, j].liczba_sasiadow.ToString(), this.myFont, Brushes.Red, i * szerokosc_komorki + szerokosc_komorki / 8, j * wysokosc_komorki + wysokosc_komorki / 25);
                                break;
                            case 4:
                                this.siatka.DrawString(this.komorka[i, j].liczba_sasiadow.ToString(), this.myFont, Brushes.Navy, i * szerokosc_komorki + szerokosc_komorki / 8, j * wysokosc_komorki + wysokosc_komorki / 25);
                                break;
                            case 5:
                                this.siatka.DrawString(this.komorka[i, j].liczba_sasiadow.ToString(), this.myFont, Brushes.Maroon, i * szerokosc_komorki + szerokosc_komorki / 8, j * wysokosc_komorki + wysokosc_komorki / 25);
                                break;
                            case 6:
                                this.siatka.DrawString(this.komorka[i, j].liczba_sasiadow.ToString(), this.myFont, Brushes.DarkCyan, i * szerokosc_komorki + szerokosc_komorki / 8, j * wysokosc_komorki + wysokosc_komorki / 25);
                                break;
                            case 7:
                                this.siatka.DrawString(this.komorka[i, j].liczba_sasiadow.ToString(), this.myFont, Brushes.Purple, i * szerokosc_komorki + szerokosc_komorki / 8, j * wysokosc_komorki + wysokosc_komorki / 25);
                                break;
                            case 8:
                                this.siatka.DrawString(this.komorka[i, j].liczba_sasiadow.ToString(), this.myFont, Brushes.Gold, i * szerokosc_komorki + szerokosc_komorki / 8, j * wysokosc_komorki + wysokosc_komorki / 25);
                                break;
                        }

                       
                    }
                }
            
        }

        private void losujBomby()
        {
            Random rnd = new Random();
            Point[] sasiedzi = new Point[]
            {
                new Point {X=-1, Y=-1},
                new Point {X=0, Y=-1},
                new Point {X=1, Y=-1},
                new Point {X=-1, Y=0},
                new Point {X=1, Y=0},
                new Point {X=-1, Y=1},
                new Point {X=0, Y=1},
                new Point {X=1, Y=1}
            };
            for(int i=0; i<this.liczba_bomb; i++)
            {
                int x = rnd.Next(0, this.szerokosc);
                int y = rnd.Next(0, this.wysokosc);
                if (this.komorka[x,y].typ == Saper.typ_pola.bomba)
                    i--;
                else
                {
                    this.komorka[x,y].typ = Saper.typ_pola.bomba;
                    foreach(Point p in sasiedzi)
                    {
                        if (x + p.X < 0 || x + p.X >= szerokosc || y + p.Y < 0 || y + p.Y >= wysokosc || this.komorka[x + p.X,y + p.Y].typ == Saper.typ_pola.bomba)
                            continue;
                        this.komorka[x + p.X,y + p.Y].liczba_sasiadow++;
                        this.komorka[x + p.X,y + p.Y].typ = Saper.typ_pola.ma_sasiadow;
                    }


                }
            }
        }
    }
}
