using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Objects;

namespace gsbRapports
{
    public partial class frmFamille : Form
    {
        private gsb2016_mission3Entities1 mesDonnees;

        public frmFamille(gsb2016_mission3Entities1 donnees)
        {
            InitializeComponent();
            this.mesDonnees = donnees;
            var req = from fam in this.mesDonnees.familles
                      select fam;
            foreach(var item in req)
            {
                this.comboBoxFam.Items.Add(item.libelle);
            }
        }

        private void ajouterFam_Click(object sender, EventArgs e) //bouton ajouter famille
        {
            frmAjoutFamille f = new frmAjoutFamille(this.mesDonnees);
            f.Show();
        }

        private void comboBoxFam_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Size = new Size(421, 394);
            this.listeMedic.Items.Clear();
            string nomFam = this.comboBoxFam.SelectedItem.ToString();
            var req = from med in this.mesDonnees.medicaments
                      where nomFam == med.famille.libelle
                      select med;
            foreach (var item in req)
            {
                this.listeMedic.Items.Add(item.nomCommercial);
            }
        }

        private void listeMedic_SelectedIndexChanged(object sender, EventArgs e)
        {
            var req = from med2 in this.mesDonnees.medicaments
                      where med2.nomCommercial == this.listeMedic.SelectedItem.ToString()
                      select med2;
            medicament med = req.First<medicament>();
            frmActionsMedicaments f = new frmActionsMedicaments(this.mesDonnees, med);
            f.Show();
        }

        private void ajouterMedoc_Click(object sender, EventArgs e)
        {
            var req = from fam2 in this.mesDonnees.familles
                      where fam2.libelle == this.comboBoxFam.SelectedItem.ToString()
                      select fam2;
            famille fam = req.First<famille>();
            frmActionsMedicaments f = new frmActionsMedicaments(this.mesDonnees, fam);
            f.Show();
        }
    }
}
