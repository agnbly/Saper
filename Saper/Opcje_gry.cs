﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saper
{
    public partial class Opcje_gry : Form
    {
        private int szerokosc;
        private int wysokosc;
        private int liczba_bomb;
        public Opcje_gry()
        {
            InitializeComponent();
            this.Dezaktywuj_ustawienia();
            this.szerokosc = 8;
            this.wysokosc = 8;
            this.liczba_bomb = 10;

        }

        private void Dezaktywuj_ustawienia()
        {
            this.ustaw_bomby.Enabled = false;
            this.ustaw_szerokosc.Enabled = false;
            this.ustaw_wysokosc.Enabled = false;
        }

        private void Aktywuj_ustawienia()
        {
            this.ustaw_bomby.Enabled = true;
            this.ustaw_szerokosc.Enabled = true;
            this.ustaw_wysokosc.Enabled = true;
        }

        private void Latwy_CheckedChanged(object sender, EventArgs e)
        {
            this.Dezaktywuj_ustawienia();
            this.szerokosc = 8;
            this.wysokosc = 8;
            this.liczba_bomb = 10;
        }

        private void Sredni_CheckedChanged(object sender, EventArgs e)
        {
            this.Dezaktywuj_ustawienia();
            this.szerokosc = 16;
            this.wysokosc = 16;
            this.liczba_bomb = 40;
        }

        private void Trudny_CheckedChanged(object sender, EventArgs e)
        {
            this.Dezaktywuj_ustawienia();
            this.szerokosc = 30;
            this.wysokosc = 16;
            this.liczba_bomb = 99;
        }

        private void Personalizuj_CheckedChanged(object sender, EventArgs e)
        {
            this.Aktywuj_ustawienia();
        }

        private void przycisk_ok_Click(object sender, EventArgs e)
        {
            if (this.Personalizuj.Checked == true)
            {
                Saper.Program.Gra.szerokosc = (int) this.ustaw_szerokosc.Value;
                Saper.Program.Gra.wysokosc = (int)this.ustaw_wysokosc.Value;
                Saper.Program.Gra.liczba_bomb = (int)this.ustaw_bomby.Value;
            }
            else
            {
                Saper.Program.Gra.szerokosc = this.szerokosc;
                Saper.Program.Gra.wysokosc = this.wysokosc;
                Saper.Program.Gra.liczba_bomb = this.liczba_bomb;
            }
            Saper.Program.Gra.Rozpocznij_Gre();
            this.Close();
        }

        private void przycisk_anuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ustaw_szerokosc_ValueChanged(object sender, EventArgs e)
        {
            this.ustaw_bomby.Maximum = this.ustaw_szerokosc.Value * ustaw_wysokosc.Value;
        }

        private void ustaw_wysokosc_ValueChanged(object sender, EventArgs e)
        {
            this.ustaw_bomby.Maximum = this.ustaw_szerokosc.Value * ustaw_wysokosc.Value;
        }
    }
}
