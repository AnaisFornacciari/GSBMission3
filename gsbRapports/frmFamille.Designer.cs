namespace gsbRapports
{
    partial class frmFamille
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
            this.comboBoxFam = new System.Windows.Forms.ComboBox();
            this.famille = new System.Windows.Forms.GroupBox();
            this.ajouterFam = new System.Windows.Forms.Button();
            this.medicament = new System.Windows.Forms.GroupBox();
            this.listeMedic = new System.Windows.Forms.ListBox();
            this.ajouterMedoc = new System.Windows.Forms.Button();
            this.famille.SuspendLayout();
            this.medicament.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxFam
            // 
            this.comboBoxFam.FormattingEnabled = true;
            this.comboBoxFam.Location = new System.Drawing.Point(40, 42);
            this.comboBoxFam.Name = "comboBoxFam";
            this.comboBoxFam.Size = new System.Drawing.Size(244, 21);
            this.comboBoxFam.TabIndex = 1;
            this.comboBoxFam.SelectedIndexChanged += new System.EventHandler(this.comboBoxFam_SelectedIndexChanged);
            // 
            // famille
            // 
            this.famille.Controls.Add(this.ajouterFam);
            this.famille.Controls.Add(this.comboBoxFam);
            this.famille.Location = new System.Drawing.Point(26, 21);
            this.famille.Name = "famille";
            this.famille.Size = new System.Drawing.Size(325, 114);
            this.famille.TabIndex = 2;
            this.famille.TabStop = false;
            this.famille.Text = "Famille";
            // 
            // ajouterFam
            // 
            this.ajouterFam.Location = new System.Drawing.Point(77, 85);
            this.ajouterFam.Name = "ajouterFam";
            this.ajouterFam.Size = new System.Drawing.Size(161, 23);
            this.ajouterFam.TabIndex = 3;
            this.ajouterFam.Text = "Ajouter une famille";
            this.ajouterFam.UseVisualStyleBackColor = true;
            this.ajouterFam.Click += new System.EventHandler(this.ajouterFam_Click);
            // 
            // medicament
            // 
            this.medicament.Controls.Add(this.listeMedic);
            this.medicament.Location = new System.Drawing.Point(26, 169);
            this.medicament.Name = "medicament";
            this.medicament.Size = new System.Drawing.Size(325, 143);
            this.medicament.TabIndex = 3;
            this.medicament.TabStop = false;
            this.medicament.Text = "Médicaments";
            // 
            // listeMedic
            // 
            this.listeMedic.FormattingEnabled = true;
            this.listeMedic.Location = new System.Drawing.Point(17, 31);
            this.listeMedic.Name = "listeMedic";
            this.listeMedic.Size = new System.Drawing.Size(294, 95);
            this.listeMedic.TabIndex = 0;
            this.listeMedic.SelectedIndexChanged += new System.EventHandler(this.listeMedic_SelectedIndexChanged);
            // 
            // ajouterMedoc
            // 
            this.ajouterMedoc.Location = new System.Drawing.Point(103, 318);
            this.ajouterMedoc.Name = "ajouterMedoc";
            this.ajouterMedoc.Size = new System.Drawing.Size(161, 23);
            this.ajouterMedoc.TabIndex = 4;
            this.ajouterMedoc.Text = "Ajouter un médicament";
            this.ajouterMedoc.UseVisualStyleBackColor = true;
            this.ajouterMedoc.Click += new System.EventHandler(this.ajouterMedoc_Click);
            // 
            // frmFamille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 152);
            this.Controls.Add(this.ajouterMedoc);
            this.Controls.Add(this.medicament);
            this.Controls.Add(this.famille);
            this.Name = "frmFamille";
            this.Text = "frmFamille";
            this.famille.ResumeLayout(false);
            this.medicament.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxFam;
        private System.Windows.Forms.GroupBox famille;
        private System.Windows.Forms.Button ajouterFam;
        private System.Windows.Forms.GroupBox medicament;
        private System.Windows.Forms.ListBox listeMedic;
        private System.Windows.Forms.Button ajouterMedoc;
    }
}