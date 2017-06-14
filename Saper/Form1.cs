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
        private bool gra_skonczona;
        private bool gra_init;
        private pole[,] komorka;
        private int _szerokosc;
        private int _wysokosc;
        private int _liczba_bomb;
        private Opcje_gry Opcje;
        public Graphics siatka;
        public Pen myPen;
        public SolidBrush myBrush_odkryte;
        public SolidBrush myBrush_zakryte;
        public Font myFont;
        public Image flaga;
        public Image bomba;
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
        public Panel pPlansza
        {
            get { return this.plansza; }

        }
        public Form1()
        {
            
            this.Opcje = new Opcje_gry();
            InitializeComponent();
            this.siatka = plansza.CreateGraphics();
            this.myPen = new Pen(Brushes.DimGray, 2);
            this.myBrush_odkryte = new SolidBrush(Color.LightGray);
            this.myBrush_zakryte = new SolidBrush(SystemColors.ActiveBorder);
            this.myFont = new Font("Consolas", 12);            
            this.flaga =Properties.Resources.flaga;
            this.bomba = Properties.Resources.bomba2;
            this.gra_skonczona = false;
            this.gra_init = false;
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
                    this.komorka[i, j] = new pole(i,j);
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

        private void plansza_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            if (me.Button == MouseButtons.Left)
            {
                HashSet<Point> Stos = new HashSet<Point>();
                Stos.Add(new Point { X = me.X / 20, Y = me.Y / 20 });
                Point[] sasiedzi = new Point[]
                {
                    new Point {X=-1, Y=-1},
                    new Point {X=1, Y=-1},
                    new Point {X=-1, Y=1},
                    new Point {X=1, Y=1},
                    new Point {X=0, Y=-1},                
                    new Point {X=-1, Y=0},
                    new Point {X=1, Y=0},                
                    new Point {X=0, Y=1}                
                };
                
                Saper.typ_pola t = this.komorka[me.X/20, me.Y/20].leftClick();
                if (t == Saper.typ_pola.typ_null || this.komorka[me.X/20,me.Y/20].czy_oznaczone==1)
                    return;
                while (Stos.Count > 0)
                {
                    Point p = Stos.First();
                    if (t==Saper.typ_pola.puste)
                    {
                        foreach(Point s in sasiedzi)
                        {
                            if (s.X + p.X < 0 || s.X + p.X >= szerokosc || s.Y + p.Y < 0 || s.Y + p.Y >= wysokosc)
                             continue;                            
                            if (this.komorka[p.X + s.X, p.Y + s.Y].czy_odkryte == false && this.komorka[p.X + s.X, p.Y + s.Y].typ == Saper.typ_pola.puste)
                            {
                                Stos.Add(new Point { X = p.X + s.X, Y = p.Y + s.Y });
                                this.komorka[p.X + s.X, p.Y + s.Y].leftClick();
                            }
                            else if (this.komorka[p.X + s.X, p.Y + s.Y].czy_odkryte == false && this.komorka[p.X + s.X, p.Y + s.Y].typ == Saper.typ_pola.ma_sasiadow)
                                this.komorka[p.X + s.X, p.Y + s.Y].leftClick();
                           

                        }
                       
                    }
                    Stos.Remove(p);
                }
                
            }
            if (me.Button == MouseButtons.Right)
            {
                if(this.komorka[me.X/20,me.Y/20].czy_odkryte==false)
                {
                    this.komorka[me.X / 20, me.Y / 20].rightClick();
                }
            }
        }
    }
}
