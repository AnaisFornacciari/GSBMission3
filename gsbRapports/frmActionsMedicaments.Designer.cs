namespace gsbRapports
{
    partial class frmActionsMedicaments
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
            this.idMedoc = new System.Windows.Forms.Label();
            this.nomCommercialMedoc = new System.Windows.Forms.Label();
            this.idMedocFam = new System.Windows.Forms.Label();
            this.compoMedoc = new System.Windows.Forms.Label();
            this.effetMedoc = new System.Windows.Forms.Label();
            this.contreIndicMedoc = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.nomCommercial = new System.Windows.Forms.TextBox();
            this.compo = new System.Windows.Forms.TextBox();
            this.bdgMedoc = new System.Windows.Forms.BindingSource(this.components);
            this.enregistrerMedoc = new System.Windows.Forms.Button();
            this.contreIndic = new System.Windows.Forms.RichTextBox();
            this.effet = new System.Windows.Forms.RichTextBox();
            this.famille = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.supprimerMedoc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bdgMedoc)).BeginInit();
            this.SuspendLayout();
            // 
            // idMedoc
            // 
            this.idMedoc.AutoSize = true;
            this.idMedoc.Location = new System.Drawing.Point(46, 41);
            this.idMedoc.Name = "idMedoc";
            this.idMedoc.Size = new System.Drawing.Size(53, 13);
            this.idMedoc.TabIndex = 0;
            this.idMedoc.Text = "Identifiant";
            // 
            // nomCommercialMedoc
            // 
            this.nomCommercialMedoc.AutoSize = true;
            this.nomCommercialMedoc.Location = new System.Drawing.Point(46, 79);
            this.nomCommercialMedoc.Name = "nomCommercialMedoc";
            this.nomCommercialMedoc.Size = new System.Drawing.Size(85, 13);
            this.nomCommercialMedoc.TabIndex = 1;
            this.nomCommercialMedoc.Text = "Nom commercial";
            // 
            // idMedocFam
            // 
            this.idMedocFam.AutoSize = true;
            this.idMedocFam.Location = new System.Drawing.Point(46, 113);
            this.idMedocFam.Name = "idMedocFam";
            this.idMedocFam.Size = new System.Drawing.Size(85, 13);
            this.idMedocFam.TabIndex = 2;
            this.idMedocFam.Text = "Identifiant famille";
            // 
            // compoMedoc
            // 
            this.compoMedoc.AutoSize = true;
            this.compoMedoc.Location = new System.Drawing.Point(46, 148);
            this.compoMedoc.Name = "compoMedoc";
            this.compoMedoc.Size = new System.Drawing.Size(64, 13);
            this.compoMedoc.TabIndex = 3;
            this.compoMedoc.Text = "Composition";
            // 
            // effetMedoc
            // 
            this.effetMedoc.AutoSize = true;
            this.effetMedoc.Location = new System.Drawing.Point(46, 185);
            this.effetMedoc.Name = "effetMedoc";
            this.effetMedoc.Size = new System.Drawing.Size(29, 13);
            this.effetMedoc.TabIndex = 4;
            this.effetMedoc.Text = "Effet";
            // 
            // contreIndicMedoc
            // 
            this.contreIndicMedoc.AutoSize = true;
            this.contreIndicMedoc.Location = new System.Drawing.Point(46, 285);
            this.contreIndicMedoc.Name = "contreIndicMedoc";
            this.contreIndicMedoc.Size = new System.Drawing.Size(86, 13);
            this.contreIndicMedoc.TabIndex = 5;
            this.contreIndicMedoc.Text = "Contre indication";
            // 
            // id
            // 
            this.id.Enabled = false;
            this.id.Location = new System.Drawing.Point(183, 38);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(126, 20);
            this.id.TabIndex = 6;
            // 
            // nomCommercial
            // 
            this.nomCommercial.Location = new System.Drawing.Point(183, 76);
            this.nomCommercial.Name = "nomCommercial";
            this.nomCommercial.Size = new System.Drawing.Size(126, 20);
            this.nomCommercial.TabIndex = 7;
            // 
            // compo
            // 
            this.compo.Location = new System.Drawing.Point(183, 145);
            this.compo.Name = "compo";
            this.compo.Size = new System.Drawing.Size(126, 20);
            this.compo.TabIndex = 8;
            // 
            // enregistrerMedoc
            // 
            this.enregistrerMedoc.Location = new System.Drawing.Point(141, 424);
            this.enregistrerMedoc.Name = "enregistrerMedoc";
            this.enregistrerMedoc.Size = new System.Drawing.Size(75, 23);
            this.enregistrerMedoc.TabIndex = 12;
            this.enregistrerMedoc.Text = "Enregistrer";
            this.enregistrerMedoc.UseVisualStyleBackColor = true;
            this.enregistrerMedoc.Click += new System.EventHandler(this.enregistrerMedoc_Click);
            // 
            // contreIndic
            // 
            this.contreIndic.Location = new System.Drawing.Point(183, 282);
            this.contreIndic.Name = "contreIndic";
            this.contreIndic.Size = new System.Drawing.Size(126, 121);
            this.contreIndic.TabIndex = 13;
            this.contreIndic.Text = "";
            // 
            // effet
            // 
            this.effet.Location = new System.Drawing.Point(183, 182);
            this.effet.Name = "effet";
            this.effet.Size = new System.Drawing.Size(126, 84);
            this.effet.TabIndex = 14;
            this.effet.Text = "";
            // 
            // famille
            // 
            this.famille.FormattingEnabled = true;
            this.famille.Location = new System.Drawing.Point(183, 110);
            this.famille.Name = "famille";
            this.famille.Size = new System.Drawing.Size(126, 21);
            this.famille.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(191, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // supprimerMedoc
            // 
            this.supprimerMedoc.Location = new System.Drawing.Point(60, 424);
            this.supprimerMedoc.Name = "supprimerMedoc";
            this.supprimerMedoc.Size = new System.Drawing.Size(75, 23);
            this.supprimerMedoc.TabIndex = 17;
            this.supprimerMedoc.Text = "Supprimer";
            this.supprimerMedoc.UseVisualStyleBackColor = true;
            this.supprimerMedoc.Click += new System.EventHandler(this.supprimerMedoc_Click);
            // 
            // frmActionsMedicaments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 459);
            this.Controls.Add(this.supprimerMedoc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.famille);
            this.Controls.Add(this.effet);
            this.Controls.Add(this.contreIndic);
            this.Controls.Add(this.enregistrerMedoc);
            this.Controls.Add(this.compo);
            this.Controls.Add(this.nomCommercial);
            this.Controls.Add(this.id);
            this.Controls.Add(this.contreIndicMedoc);
            this.Controls.Add(this.effetMedoc);
            this.Controls.Add(this.compoMedoc);
            this.Controls.Add(this.idMedocFam);
            this.Controls.Add(this.nomCommercialMedoc);
            this.Controls.Add(this.idMedoc);
            this.Name = "frmActionsMedicaments";
            this.Text = "frmAjoutMedicaments";
            ((System.ComponentModel.ISupportInitialize)(this.bdgMedoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idMedoc;
        private System.Windows.Forms.Label nomCommercialMedoc;
        private System.Windows.Forms.Label idMedocFam;
        private System.Windows.Forms.Label compoMedoc;
        private System.Windows.Forms.Label effetMedoc;
        private System.Windows.Forms.Label contreIndicMedoc;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox nomCommercial;
        private System.Windows.Forms.TextBox compo;
        private System.Windows.Forms.BindingSource bdgMedoc;
        private System.Windows.Forms.Button enregistrerMedoc;
        private System.Windows.Forms.RichTextBox contreIndic;
        private System.Windows.Forms.RichTextBox effet;
        private System.Windows.Forms.ComboBox famille;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button supprimerMedoc;
    }
}