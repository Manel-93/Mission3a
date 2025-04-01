namespace mission3A
{
    partial class EditMed
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                components = null;
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox txtspecialite;
        private System.Windows.Forms.TextBox txtdepartement;
        private System.Windows.Forms.Label departement;
        private System.Windows.Forms.Label specialite;
        private System.Windows.Forms.TextBox txtnumtel;
        private System.Windows.Forms.Label num_tel;
        private System.Windows.Forms.Label adresse;
        private System.Windows.Forms.TextBox txtadresse;
        private System.Windows.Forms.Label prenom_medecin;
        private System.Windows.Forms.TextBox txtprenommedecin;
        private System.Windows.Forms.Label nom_medecin;
        private System.Windows.Forms.TextBox txtnommedecin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.Button modifier;

        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtspecialite = new System.Windows.Forms.ComboBox();
            this.txtdepartement = new System.Windows.Forms.TextBox();
            this.departement = new System.Windows.Forms.Label();
            this.specialite = new System.Windows.Forms.Label();
            this.txtnumtel = new System.Windows.Forms.TextBox();
            this.num_tel = new System.Windows.Forms.Label();
            this.adresse = new System.Windows.Forms.Label();
            this.txtadresse = new System.Windows.Forms.TextBox();
            this.prenom_medecin = new System.Windows.Forms.Label();
            this.txtprenommedecin = new System.Windows.Forms.TextBox();
            this.nom_medecin = new System.Windows.Forms.Label();
            this.txtnommedecin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ajouter = new System.Windows.Forms.Button();
            this.modifier = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Location = new System.Drawing.Point(-178, -10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(846, 41);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtspecialite);
            this.groupBox1.Controls.Add(this.txtdepartement);
            this.groupBox1.Controls.Add(this.departement);
            this.groupBox1.Controls.Add(this.specialite);
            this.groupBox1.Controls.Add(this.txtnumtel);
            this.groupBox1.Controls.Add(this.num_tel);
            this.groupBox1.Controls.Add(this.adresse);
            this.groupBox1.Controls.Add(this.txtadresse);
            this.groupBox1.Controls.Add(this.prenom_medecin);
            this.groupBox1.Controls.Add(this.txtprenommedecin);
            this.groupBox1.Controls.Add(this.nom_medecin);
            this.groupBox1.Controls.Add(this.txtnommedecin);
            this.groupBox1.Location = new System.Drawing.Point(12, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 208);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // txtspecialite
            // 
            this.txtspecialite.FormattingEnabled = true;
            this.txtspecialite.Items.AddRange(new object[] {
            "",
            "Allergologie",
            "Anesthésiologie",
            "Cardiologie",
            "Dermatologie",
            "Endocrinologie",
            "Gastro-entérologie",
            "Gériatrie",
            "Gynécologie",
            "Hématologie",
            "Neurologie",
            "Oncologie",
            "Ophtalmologie",
            "Orthopédie",
            "Pédiatrie",
            "Pneumologie",
            "Psychiatrie",
            "Radiologie",
            "Rhumatologie",
            "Urologie"});
            this.txtspecialite.Location = new System.Drawing.Point(197, 107);
            this.txtspecialite.Name = "txtspecialite";
            this.txtspecialite.Size = new System.Drawing.Size(135, 24);
            this.txtspecialite.TabIndex = 18;
            // 
            // txtdepartement
            // 
            this.txtdepartement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtdepartement.Location = new System.Drawing.Point(197, 163);
            this.txtdepartement.Name = "txtdepartement";
            this.txtdepartement.Size = new System.Drawing.Size(133, 30);
            this.txtdepartement.TabIndex = 17;
            // 
            // departement
            // 
            this.departement.AutoSize = true;
            this.departement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.departement.Location = new System.Drawing.Point(221, 144);
            this.departement.Name = "departement";
            this.departement.Size = new System.Drawing.Size(106, 20);
            this.departement.TabIndex = 16;
            this.departement.Text = "Département";
            // 
            // specialite
            // 
            this.specialite.AutoSize = true;
            this.specialite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.specialite.Location = new System.Drawing.Point(180, 88);
            this.specialite.Name = "specialite";
            this.specialite.Size = new System.Drawing.Size(206, 20);
            this.specialite.TabIndex = 14;
            this.specialite.Text = "Spécialité complémentaire";
            // 
            // txtnumtel
            // 
            this.txtnumtel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtnumtel.Location = new System.Drawing.Point(198, 49);
            this.txtnumtel.Name = "txtnumtel";
            this.txtnumtel.Size = new System.Drawing.Size(133, 30);
            this.txtnumtel.TabIndex = 13;
            // 
            // num_tel
            // 
            this.num_tel.AutoSize = true;
            this.num_tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.num_tel.Location = new System.Drawing.Point(195, 30);
            this.num_tel.Name = "num_tel";
            this.num_tel.Size = new System.Drawing.Size(168, 20);
            this.num_tel.TabIndex = 12;
            this.num_tel.Text = "Numéro de téléphone";
            // 
            // adresse
            // 
            this.adresse.AutoSize = true;
            this.adresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.adresse.Location = new System.Drawing.Point(37, 145);
            this.adresse.Name = "adresse";
            this.adresse.Size = new System.Drawing.Size(172, 20);
            this.adresse.TabIndex = 10;
            this.adresse.Text = "Adresse du médecin :";
            // 
            // txtadresse
            // 
            this.txtadresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtadresse.Location = new System.Drawing.Point(39, 163);
            this.txtadresse.Name = "txtadresse";
            this.txtadresse.Size = new System.Drawing.Size(133, 30);
            this.txtadresse.TabIndex = 9;
            // 
            // prenom_medecin
            // 
            this.prenom_medecin.AutoSize = true;
            this.prenom_medecin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.prenom_medecin.Location = new System.Drawing.Point(39, 88);
            this.prenom_medecin.Name = "prenom_medecin";
            this.prenom_medecin.Size = new System.Drawing.Size(168, 20);
            this.prenom_medecin.TabIndex = 8;
            this.prenom_medecin.Text = "Prénom du médecin :";
            // 
            // txtprenommedecin
            // 
            this.txtprenommedecin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtprenommedecin.Location = new System.Drawing.Point(39, 106);
            this.txtprenommedecin.Name = "txtprenommedecin";
            this.txtprenommedecin.Size = new System.Drawing.Size(133, 30);
            this.txtprenommedecin.TabIndex = 7;
            // 
            // nom_medecin
            // 
            this.nom_medecin.AutoSize = true;
            this.nom_medecin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.nom_medecin.Location = new System.Drawing.Point(48, 31);
            this.nom_medecin.Name = "nom_medecin";
            this.nom_medecin.Size = new System.Drawing.Size(145, 20);
            this.nom_medecin.TabIndex = 6;
            this.nom_medecin.Text = "Nom du médecin :";
            // 
            // txtnommedecin
            // 
            this.txtnommedecin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtnommedecin.Location = new System.Drawing.Point(39, 49);
            this.txtnommedecin.Name = "txtnommedecin";
            this.txtnommedecin.Size = new System.Drawing.Size(133, 30);
            this.txtnommedecin.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(67, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(358, 31);
            this.label7.TabIndex = 18;
            this.label7.Text = "Modification des médecins";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ajouter);
            this.groupBox2.Controls.Add(this.modifier);
            this.groupBox2.Location = new System.Drawing.Point(12, 262);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 67);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actions";
            // 
            // ajouter
            // 
            this.ajouter.BackColor = System.Drawing.Color.Lime;
            this.ajouter.Location = new System.Drawing.Point(212, 22);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(114, 29);
            this.ajouter.TabIndex = 8;
            this.ajouter.Text = "Ajouter";
            this.ajouter.UseVisualStyleBackColor = false;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // modifier
            // 
            this.modifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.modifier.Location = new System.Drawing.Point(58, 22);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(114, 29);
            this.modifier.TabIndex = 6;
            this.modifier.Text = "Modifier";
            this.modifier.UseVisualStyleBackColor = false;
            this.modifier.Click += new System.EventHandler(this.modifier_Click);
            // 
            // EditMed
            // 
            this.ClientSize = new System.Drawing.Size(531, 350);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Name = "EditMed";
            this.Text = "EditMed";
            this.Load += new System.EventHandler(this.EditMed_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}