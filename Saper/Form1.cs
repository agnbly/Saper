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
            this.przygotujPlansze(10, 10, 0);
            sw.Start();
        }

        private void przygotujPlansze(int szerokosc, int wysokosc, int bomby)
        {
            Graphics siatka = plansza.CreateGraphics();
            Pen myPen = new Pen(Brushes.Black, 1);
            Font myFont = new Font("Consolas", 10);

            float x = 0f, y = 0f;
            float szerokosc_komorki = plansza.Width / 10;
            float wysokosc_komorki = plansza.Height / 10;

            //pionowe linie
            for (int i = 0; i <= szerokosc; i++)
            {
                siatka.DrawLine(myPen, x, y, x, plansza.Height);
                x += szerokosc_komorki;
            }
            //poziome linie
            x = 0f;
            y = 0f;
            for (int i = 0; i <= wysokosc; i++)
            {
                siatka.DrawLine(myPen, x, y, plansza.Width, y);
                y += wysokosc_komorki;
            }

            siatka.DrawString("0", myFont, Brushes.Black, 0, 0);
        }
    }
}
