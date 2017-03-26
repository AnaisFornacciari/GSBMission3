using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace gsbRapports
{
    public partial class Form1 : Form
    {
        private gsb2016_mission3Entities1 mesDonnees;
        public Form1()
        {
            this.InitializeComponent();
            this.mesDonnees = new gsb2016_mission3Entities1();
        }

        private void gérerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFamille f = new frmFamille(mesDonnees);
            f.Show();
        }        
    }
}
