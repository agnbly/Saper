using System;
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
        public Opcje_gry()
        {
            InitializeComponent();
            

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
    }
}
