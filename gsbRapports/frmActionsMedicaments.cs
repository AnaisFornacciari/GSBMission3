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
    public partial class frmActionsMedicaments : Form
    {
        private gsb2016_mission3Entities1 mesDonnees;
        private medicament medicament;

        public frmActionsMedicaments(gsb2016_mission3Entities1 donnees, famille familleMedicament)
        {
            InitializeComponent();
            this.mesDonnees = donnees;

        }

        public frmActionsMedicaments(gsb2016_mission3Entities1 donnees, medicament medicamentInput)
        {
            InitializeComponent();
            this.mesDonnees = donnees;
            this.medicament = medicamentInput;
            List<famille> listeFamille = this.mesDonnees.familles.ToList<famille>();
            this.compo.Text = medicament.composition.ToString();
            this.contreIndic.Text = medicament.contreIndications.ToString();
            this.effet.Text = medicament.effets.ToString();
            this.id.Text = medicament.id.ToString();
            this.nomCommercial.Text = medicament.nomCommercial.ToString();
            foreach (var item in listeFamille)
            {
                this.famille.Items.Add(item.libelle);
            }
            this.famille.SelectedItem = listeFamille.Where(x => x.libelle == this.medicament.famille.libelle)
                                                    .FirstOrDefault<famille>()
                                                    .libelle;
            this.id.Enabled = false;
            this.enregistrerMedoc.Visible = true;
            this.supprimerMedoc.Visible = true;
        }

        private void enregistrerMedoc_Click(object sender, EventArgs e)
        {
            medicament med = this.mesDonnees.medicaments.Where(m => m.id == this.medicament.id).FirstOrDefault<medicament>();
            med.nomCommercial = this.nomCommercial.Text;
            med.idFamille = this.famille.SelectedItem.ToString();
            med.composition = this.compo.Text;
            med.effets = this.effet.Text;
            med.contreIndications = this.contreIndic.Text;
            this.mesDonnees.SaveChanges();
            this.Close();
        }

        private void supprimerMedoc_Click(object sender, EventArgs e)
        {
            List<offrir> listeMedicamentsOfferts = this.mesDonnees.offrirs.Where(o => o.idMedicament == this.medicament.id).ToList<offrir>();
            foreach (offrir item in listeMedicamentsOfferts)
            {
                this.mesDonnees.offrirs.DeleteObject(item);
            }
            this.mesDonnees.medicaments.DeleteObject(this.medicament);
            this.mesDonnees.SaveChanges();
            this.Close();
        }
    }
}
