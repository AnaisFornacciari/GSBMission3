namespace gsbRapports
{
    partial class frmAjoutFamille
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bdgFamille = new System.Windows.Forms.BindingSource(this.components);
            this.idFam = new System.Windows.Forms.Label();
            this.libelleFam = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.libelle = new System.Windows.Forms.TextBox();
            this.enregistrerFam = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bdgFamille)).BeginInit();
            this.SuspendLayout();
            // 
            // idFam
            // 
            this.idFam.AutoSize = true;
            this.idFam.Location = new System.Drawing.Point(32, 34);
            this.idFam.Name = "idFam";
            this.idFam.Size = new System.Drawing.Size(53, 13);
            this.idFam.TabIndex = 0;
            this.idFam.Text = "Identifiant";
            // 
            // libelleFam
            // 
            this.libelleFam.AutoSize = true;
            this.libelleFam.Location = new System.Drawing.Point(32, 87);
            this.libelleFam.Name = "libelleFam";
            this.libelleFam.Size = new System.Drawing.Size(37, 13);
            this.libelleFam.TabIndex = 1;
            this.libelleFam.Text = "Libelle";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(105, 31);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(151, 20);
            this.id.TabIndex = 2;
            // 
            // libelle
            // 
            this.libelle.Location = new System.Drawing.Point(105, 84);
            this.libelle.Name = "libelle";
            this.libelle.Size = new System.Drawing.Size(151, 20);
            this.libelle.TabIndex = 3;
            // 
            // enregistrerFam
            // 
            this.enregistrerFam.Location = new System.Drawing.Point(105, 129);
            this.enregistrerFam.Name = "enregistrerFam";
            this.enregistrerFam.Size = new System.Drawing.Size(75, 23);
            this.enregistrerFam.TabIndex = 4;
            this.enregistrerFam.Text = "Enregistrer";
            this.enregistrerFam.UseVisualStyleBackColor = true;
            this.enregistrerFam.Click += new System.EventHandler(this.enregistrerFam_Click);
            // 
            // frmAjoutFamille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 175);
            this.Controls.Add(this.enregistrerFam);
            this.Controls.Add(this.libelle);
            this.Controls.Add(this.id);
            this.Controls.Add(this.libelleFam);
            this.Controls.Add(this.idFam);
            this.Name = "frmAjoutFamille";
            this.Text = "frmAjoutFamille";
            ((System.ComponentModel.ISupportInitialize)(this.bdgFamille)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bdgFamille;
        private System.Windows.Forms.Label idFam;
        private System.Windows.Forms.Label libelleFam;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox libelle;
        private System.Windows.Forms.Button enregistrerFam;
    }
}