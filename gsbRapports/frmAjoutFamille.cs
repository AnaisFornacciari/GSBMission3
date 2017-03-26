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
    public partial class frmAjoutFamille : Form
    {
        private gsb2016_mission3Entities1 mesDonnees;

        public frmAjoutFamille(gsb2016_mission3Entities1 donnees)
        {
            InitializeComponent();
            this.mesDonnees = donnees;
            this.bdgFamille.DataSource = this.mesDonnees.familles;
        }

        private void enregistrerFam_Click(object sender, EventArgs e)
        {
            famille nouvelleFam = famille.Createfamille(
                this.idFam.Text,
                this.libelleFam.Text
            );
            this.mesDonnees.familles.AddObject(nouvelleFam);
            this.bdgFamille.EndEdit();
            this.mesDonnees.SaveChanges();
            MessageBox.Show("La famille à bien été enregistrée !");
            this.Close();

        }
    }
}
