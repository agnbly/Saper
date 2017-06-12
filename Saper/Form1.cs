﻿using System;
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
        private pole[][] komorka;
        private int szerokosc { get; set; }
        private int wysokosc { get; set; }
        private int liczba_bomb { get; set; }

        
        public Form1()
        {
            InitializeComponent();
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
            this.przygotujPlansze();
            sw.Start();
        }

        private void przygotujPlansze()
        {
            Graphics siatka = plansza.CreateGraphics();
            Pen myPen = new Pen(Brushes.Black, 1);
            Font myFont = new Font("Consolas", 10);

            float x = 0f, y = 0f;
            float szerokosc_komorki = plansza.Width / this.szerokosc;
            float wysokosc_komorki = plansza.Height / this.wysokosc;

            //pionowe linie
            for (int i = 0; i <= this.szerokosc; i++)
            {
                siatka.DrawLine(myPen, x, y, x, plansza.Height);
                x += szerokosc_komorki;
            }
            //poziome linie
            x = 0f;
            y = 0f;
            for (int i = 0; i <= this.wysokosc; i++)
            {
                siatka.DrawLine(myPen, x, y, plansza.Width, y);
                y += wysokosc_komorki;
            }

            siatka.DrawString("0", myFont, Brushes.Black, 0, 0);
        }

        private void losujBomby()
        {
            Random rnd = new Random();
            for(int i=0; i<this.liczba_bomb; i++)
            {
                int x = rnd.Next(0, this.szerokosc);
                int y = rnd.Next(0, this.wysokosc);
                if (this.komorka[x][y].typ == Saper.typ_pola.bomba)
                    i--;
                else
                {
                    this.komorka[x][y].typ = Saper.typ_pola.bomba;
                }
            }
        }
    }
}
