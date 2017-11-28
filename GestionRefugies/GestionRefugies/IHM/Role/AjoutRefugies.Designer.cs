namespace GestionRefugies
{
    partial class Ajout
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageAjoutRef = new System.Windows.Forms.TabPage();
            this.Lbl_ErrNation = new System.Windows.Forms.Label();
            this.Lbl_Sexe = new System.Windows.Forms.Label();
            this.Btn_Ajout = new System.Windows.Forms.Button();
            this.Lbl_Nationalite = new System.Windows.Forms.Label();
            this.Lbl_DateNaiss = new System.Windows.Forms.Label();
            this.List_Nationalite = new System.Windows.Forms.ComboBox();
            this.DatePicker_DatNaiss = new System.Windows.Forms.DateTimePicker();
            this.RdBtn_Femme = new System.Windows.Forms.RadioButton();
            this.RdBtn_Homme = new System.Windows.Forms.RadioButton();
            this.Txt_Prenom = new System.Windows.Forms.MaskedTextBox();
            this.Txt_Nom = new System.Windows.Forms.MaskedTextBox();
            this.tabPageAjoutGérant = new System.Windows.Forms.TabPage();
            this.lbl_errRole = new System.Windows.Forms.Label();
            this.check_Magasinier = new System.Windows.Forms.CheckBox();
            this.check_AgentAccueil = new System.Windows.Forms.CheckBox();
            this.lbl_errNationM = new System.Windows.Forms.Label();
            this.lbl_errSexM = new System.Windows.Forms.Label();
            this.btn_AjoutM = new System.Windows.Forms.Button();
            this.lbl_NationM = new System.Windows.Forms.Label();
            this.lbl_DatNaissM = new System.Windows.Forms.Label();
            this.list_NationM = new System.Windows.Forms.ComboBox();
            this.DatePicker_NaissM = new System.Windows.Forms.DateTimePicker();
            this.rdn_FemmeM = new System.Windows.Forms.RadioButton();
            this.rdn_HommeM = new System.Windows.Forms.RadioButton();
            this.Txt_PrenomM = new System.Windows.Forms.MaskedTextBox();
            this.Txt_MDPM = new System.Windows.Forms.MaskedTextBox();
            this.Txt_NomM = new System.Windows.Forms.MaskedTextBox();
            this.test = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPageAjoutRef.SuspendLayout();
            this.tabPageAjoutGérant.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageAjoutRef);
            this.tabControl1.Controls.Add(this.tabPageAjoutGérant);
            this.tabControl1.Controls.Add(this.test);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(660, 337);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageAjoutRef
            // 
            this.tabPageAjoutRef.BackColor = System.Drawing.Color.Transparent;
            this.tabPageAjoutRef.Controls.Add(this.Lbl_ErrNation);
            this.tabPageAjoutRef.Controls.Add(this.Lbl_Sexe);
            this.tabPageAjoutRef.Controls.Add(this.Btn_Ajout);
            this.tabPageAjoutRef.Controls.Add(this.Lbl_Nationalite);
            this.tabPageAjoutRef.Controls.Add(this.Lbl_DateNaiss);
            this.tabPageAjoutRef.Controls.Add(this.List_Nationalite);
            this.tabPageAjoutRef.Controls.Add(this.DatePicker_DatNaiss);
            this.tabPageAjoutRef.Controls.Add(this.RdBtn_Femme);
            this.tabPageAjoutRef.Controls.Add(this.RdBtn_Homme);
            this.tabPageAjoutRef.Controls.Add(this.Txt_Prenom);
            this.tabPageAjoutRef.Controls.Add(this.Txt_Nom);
            this.tabPageAjoutRef.Location = new System.Drawing.Point(4, 22);
            this.tabPageAjoutRef.Name = "tabPageAjoutRef";
            this.tabPageAjoutRef.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAjoutRef.Size = new System.Drawing.Size(652, 311);
            this.tabPageAjoutRef.TabIndex = 0;
            this.tabPageAjoutRef.Text = "Ajouter un Refugié";
            // 
            // Lbl_ErrNation
            // 
            this.Lbl_ErrNation.AutoSize = true;
            this.Lbl_ErrNation.ForeColor = System.Drawing.Color.Red;
            this.Lbl_ErrNation.Location = new System.Drawing.Point(392, 182);
            this.Lbl_ErrNation.Name = "Lbl_ErrNation";
            this.Lbl_ErrNation.Size = new System.Drawing.Size(157, 13);
            this.Lbl_ErrNation.TabIndex = 13;
            this.Lbl_ErrNation.Text = "Veuillez renseigner la nationalite";
            this.Lbl_ErrNation.Visible = false;
            // 
            // Lbl_Sexe
            // 
            this.Lbl_Sexe.AutoSize = true;
            this.Lbl_Sexe.ForeColor = System.Drawing.Color.Red;
            this.Lbl_Sexe.Location = new System.Drawing.Point(117, 131);
            this.Lbl_Sexe.Name = "Lbl_Sexe";
            this.Lbl_Sexe.Size = new System.Drawing.Size(131, 13);
            this.Lbl_Sexe.TabIndex = 12;
            this.Lbl_Sexe.Text = "Veuillez renseigner le sexe";
            this.Lbl_Sexe.Visible = false;
            // 
            // Btn_Ajout
            // 
            this.Btn_Ajout.Location = new System.Drawing.Point(453, 222);
            this.Btn_Ajout.Name = "Btn_Ajout";
            this.Btn_Ajout.Size = new System.Drawing.Size(108, 23);
            this.Btn_Ajout.TabIndex = 11;
            this.Btn_Ajout.Text = "Ajouter";
            this.Btn_Ajout.UseVisualStyleBackColor = true;
            this.Btn_Ajout.Click += new System.EventHandler(this.Btn_Ajout_Click);
            // 
            // Lbl_Nationalite
            // 
            this.Lbl_Nationalite.AutoSize = true;
            this.Lbl_Nationalite.Location = new System.Drawing.Point(357, 140);
            this.Lbl_Nationalite.Name = "Lbl_Nationalite";
            this.Lbl_Nationalite.Size = new System.Drawing.Size(57, 13);
            this.Lbl_Nationalite.TabIndex = 10;
            this.Lbl_Nationalite.Text = "Nationalite";
            // 
            // Lbl_DateNaiss
            // 
            this.Lbl_DateNaiss.AutoSize = true;
            this.Lbl_DateNaiss.Location = new System.Drawing.Point(357, 41);
            this.Lbl_DateNaiss.Name = "Lbl_DateNaiss";
            this.Lbl_DateNaiss.Size = new System.Drawing.Size(98, 13);
            this.Lbl_DateNaiss.TabIndex = 9;
            this.Lbl_DateNaiss.Text = "Date de Naissance";
            // 
            // List_Nationalite
            // 
            this.List_Nationalite.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.List_Nationalite.FormattingEnabled = true;
            this.List_Nationalite.Items.AddRange(new object[] {
            "Anglais",
            "Espagnol",
            "Allemand",
            "Italien",
            "Portugais",
            "Belge",
            "Suisse",
            "Polonais",
            "Ukrainien",
            "Chinois",
            "Indien",
            "Russe",
            "Japonais",
            "Americain",
            "Canadien",
            "Mexicain",
            "Bresilien",
            "Colombien",
            "Cubain",
            "Marocain",
            "Turc",
            "Algerien",
            "Tunisien",
            "Syrien",
            "Egyptien",
            "Soudanais",
            "Congolais",
            "Senegalais",
            "Sud-Africain",
            "Autre"});
            this.List_Nationalite.Location = new System.Drawing.Point(349, 156);
            this.List_Nationalite.Name = "List_Nationalite";
            this.List_Nationalite.Size = new System.Drawing.Size(148, 21);
            this.List_Nationalite.TabIndex = 8;
            // 
            // DatePicker_DatNaiss
            // 
            this.DatePicker_DatNaiss.Location = new System.Drawing.Point(349, 57);
            this.DatePicker_DatNaiss.Name = "DatePicker_DatNaiss";
            this.DatePicker_DatNaiss.Size = new System.Drawing.Size(200, 20);
            this.DatePicker_DatNaiss.TabIndex = 6;
            this.DatePicker_DatNaiss.ValueChanged += new System.EventHandler(this.DatePicker_DatNaiss_ValueChanged);
            // 
            // RdBtn_Femme
            // 
            this.RdBtn_Femme.AutoSize = true;
            this.RdBtn_Femme.Location = new System.Drawing.Point(158, 111);
            this.RdBtn_Femme.Name = "RdBtn_Femme";
            this.RdBtn_Femme.Size = new System.Drawing.Size(59, 17);
            this.RdBtn_Femme.TabIndex = 5;
            this.RdBtn_Femme.TabStop = true;
            this.RdBtn_Femme.Text = "Femme";
            this.RdBtn_Femme.UseVisualStyleBackColor = true;
            // 
            // RdBtn_Homme
            // 
            this.RdBtn_Homme.AutoSize = true;
            this.RdBtn_Homme.Location = new System.Drawing.Point(79, 111);
            this.RdBtn_Homme.Name = "RdBtn_Homme";
            this.RdBtn_Homme.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RdBtn_Homme.Size = new System.Drawing.Size(61, 17);
            this.RdBtn_Homme.TabIndex = 4;
            this.RdBtn_Homme.TabStop = true;
            this.RdBtn_Homme.Text = "Homme";
            this.RdBtn_Homme.UseVisualStyleBackColor = true;
            // 
            // Txt_Prenom
            // 
            this.Txt_Prenom.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Txt_Prenom.Location = new System.Drawing.Point(58, 69);
            this.Txt_Prenom.Name = "Txt_Prenom";
            this.Txt_Prenom.Size = new System.Drawing.Size(190, 20);
            this.Txt_Prenom.TabIndex = 3;
            this.Txt_Prenom.Text = "Prenom";
            this.Txt_Prenom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Prenom_KeyDown);
            this.Txt_Prenom.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_Prenom_KeyUp);
            // 
            // Txt_Nom
            // 
            this.Txt_Nom.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Txt_Nom.Location = new System.Drawing.Point(58, 43);
            this.Txt_Nom.Name = "Txt_Nom";
            this.Txt_Nom.Size = new System.Drawing.Size(190, 20);
            this.Txt_Nom.TabIndex = 0;
            this.Txt_Nom.Text = "Nom";
            this.Txt_Nom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Nom_KeyDown);
            this.Txt_Nom.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_Nom_KeyUp);
            // 
            // tabPageAjoutGérant
            // 
            this.tabPageAjoutGérant.BackColor = System.Drawing.Color.Transparent;
            this.tabPageAjoutGérant.Controls.Add(this.lbl_errRole);
            this.tabPageAjoutGérant.Controls.Add(this.check_Magasinier);
            this.tabPageAjoutGérant.Controls.Add(this.check_AgentAccueil);
            this.tabPageAjoutGérant.Controls.Add(this.lbl_errNationM);
            this.tabPageAjoutGérant.Controls.Add(this.lbl_errSexM);
            this.tabPageAjoutGérant.Controls.Add(this.btn_AjoutM);
            this.tabPageAjoutGérant.Controls.Add(this.lbl_NationM);
            this.tabPageAjoutGérant.Controls.Add(this.lbl_DatNaissM);
            this.tabPageAjoutGérant.Controls.Add(this.list_NationM);
            this.tabPageAjoutGérant.Controls.Add(this.DatePicker_NaissM);
            this.tabPageAjoutGérant.Controls.Add(this.rdn_FemmeM);
            this.tabPageAjoutGérant.Controls.Add(this.rdn_HommeM);
            this.tabPageAjoutGérant.Controls.Add(this.Txt_PrenomM);
            this.tabPageAjoutGérant.Controls.Add(this.Txt_MDPM);
            this.tabPageAjoutGérant.Controls.Add(this.Txt_NomM);
            this.tabPageAjoutGérant.Location = new System.Drawing.Point(4, 22);
            this.tabPageAjoutGérant.Name = "tabPageAjoutGérant";
            this.tabPageAjoutGérant.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAjoutGérant.Size = new System.Drawing.Size(652, 311);
            this.tabPageAjoutGérant.TabIndex = 1;
            this.tabPageAjoutGérant.Text = "Ajouter un Gérant";
            // 
            // lbl_errRole
            // 
            this.lbl_errRole.AutoSize = true;
            this.lbl_errRole.ForeColor = System.Drawing.Color.Red;
            this.lbl_errRole.Location = new System.Drawing.Point(117, 248);
            this.lbl_errRole.Name = "lbl_errRole";
            this.lbl_errRole.Size = new System.Drawing.Size(126, 13);
            this.lbl_errRole.TabIndex = 28;
            this.lbl_errRole.Text = "Veuillez renseigner le rôle";
            this.lbl_errRole.Visible = false;
            // 
            // check_Magasinier
            // 
            this.check_Magasinier.AutoSize = true;
            this.check_Magasinier.Location = new System.Drawing.Point(173, 228);
            this.check_Magasinier.Name = "check_Magasinier";
            this.check_Magasinier.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.check_Magasinier.Size = new System.Drawing.Size(75, 17);
            this.check_Magasinier.TabIndex = 27;
            this.check_Magasinier.Text = "Magasiner";
            this.check_Magasinier.UseVisualStyleBackColor = true;
            // 
            // check_AgentAccueil
            // 
            this.check_AgentAccueil.AutoSize = true;
            this.check_AgentAccueil.Location = new System.Drawing.Point(49, 228);
            this.check_AgentAccueil.Name = "check_AgentAccueil";
            this.check_AgentAccueil.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.check_AgentAccueil.Size = new System.Drawing.Size(100, 17);
            this.check_AgentAccueil.TabIndex = 26;
            this.check_AgentAccueil.Text = "Agent d\'Accueil";
            this.check_AgentAccueil.UseVisualStyleBackColor = true;
            // 
            // lbl_errNationM
            // 
            this.lbl_errNationM.AutoSize = true;
            this.lbl_errNationM.ForeColor = System.Drawing.Color.Red;
            this.lbl_errNationM.Location = new System.Drawing.Point(392, 182);
            this.lbl_errNationM.Name = "lbl_errNationM";
            this.lbl_errNationM.Size = new System.Drawing.Size(157, 13);
            this.lbl_errNationM.TabIndex = 25;
            this.lbl_errNationM.Text = "Veuillez renseigner la nationalite";
            this.lbl_errNationM.Visible = false;
            // 
            // lbl_errSexM
            // 
            this.lbl_errSexM.AutoSize = true;
            this.lbl_errSexM.ForeColor = System.Drawing.Color.Red;
            this.lbl_errSexM.Location = new System.Drawing.Point(117, 131);
            this.lbl_errSexM.Name = "lbl_errSexM";
            this.lbl_errSexM.Size = new System.Drawing.Size(131, 13);
            this.lbl_errSexM.TabIndex = 24;
            this.lbl_errSexM.Text = "Veuillez renseigner le sexe";
            this.lbl_errSexM.Visible = false;
            // 
            // btn_AjoutM
            // 
            this.btn_AjoutM.Location = new System.Drawing.Point(453, 222);
            this.btn_AjoutM.Name = "btn_AjoutM";
            this.btn_AjoutM.Size = new System.Drawing.Size(108, 23);
            this.btn_AjoutM.TabIndex = 23;
            this.btn_AjoutM.Text = "Ajouter";
            this.btn_AjoutM.UseVisualStyleBackColor = true;
            this.btn_AjoutM.Click += new System.EventHandler(this.btn_AjoutM_Click_1);
            // 
            // lbl_NationM
            // 
            this.lbl_NationM.AutoSize = true;
            this.lbl_NationM.Location = new System.Drawing.Point(357, 140);
            this.lbl_NationM.Name = "lbl_NationM";
            this.lbl_NationM.Size = new System.Drawing.Size(57, 13);
            this.lbl_NationM.TabIndex = 22;
            this.lbl_NationM.Text = "Nationalite";
            // 
            // lbl_DatNaissM
            // 
            this.lbl_DatNaissM.AutoSize = true;
            this.lbl_DatNaissM.Location = new System.Drawing.Point(357, 41);
            this.lbl_DatNaissM.Name = "lbl_DatNaissM";
            this.lbl_DatNaissM.Size = new System.Drawing.Size(98, 13);
            this.lbl_DatNaissM.TabIndex = 21;
            this.lbl_DatNaissM.Text = "Date de Naissance";
            // 
            // list_NationM
            // 
            this.list_NationM.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.list_NationM.FormattingEnabled = true;
            this.list_NationM.Items.AddRange(new object[] {
            "Anglais",
            "Espagnol",
            "Allemand",
            "Italien",
            "Portugais",
            "Belge",
            "Suisse",
            "Polonais",
            "Ukrainien",
            "Chinois",
            "Indien",
            "Russe",
            "Japonais",
            "Americain",
            "Canadien",
            "Mexicain",
            "Bresilien",
            "Colombien",
            "Cubain",
            "Marocain",
            "Turc",
            "Algerien",
            "Tunisien",
            "Syrien",
            "Egyptien",
            "Soudanais",
            "Congolais",
            "Senegalais",
            "Sud-Africain",
            "Autre"});
            this.list_NationM.Location = new System.Drawing.Point(349, 156);
            this.list_NationM.Name = "list_NationM";
            this.list_NationM.Size = new System.Drawing.Size(148, 21);
            this.list_NationM.TabIndex = 20;
            // 
            // DatePicker_NaissM
            // 
            this.DatePicker_NaissM.Location = new System.Drawing.Point(349, 57);
            this.DatePicker_NaissM.Name = "DatePicker_NaissM";
            this.DatePicker_NaissM.Size = new System.Drawing.Size(200, 20);
            this.DatePicker_NaissM.TabIndex = 19;
            this.DatePicker_NaissM.ValueChanged += new System.EventHandler(this.DatePicker_NaissM_ValueChanged_1);
            // 
            // rdn_FemmeM
            // 
            this.rdn_FemmeM.AutoSize = true;
            this.rdn_FemmeM.Location = new System.Drawing.Point(158, 111);
            this.rdn_FemmeM.Name = "rdn_FemmeM";
            this.rdn_FemmeM.Size = new System.Drawing.Size(59, 17);
            this.rdn_FemmeM.TabIndex = 18;
            this.rdn_FemmeM.TabStop = true;
            this.rdn_FemmeM.Text = "Femme";
            this.rdn_FemmeM.UseVisualStyleBackColor = true;
            // 
            // rdn_HommeM
            // 
            this.rdn_HommeM.AutoSize = true;
            this.rdn_HommeM.Location = new System.Drawing.Point(79, 111);
            this.rdn_HommeM.Name = "rdn_HommeM";
            this.rdn_HommeM.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdn_HommeM.Size = new System.Drawing.Size(61, 17);
            this.rdn_HommeM.TabIndex = 17;
            this.rdn_HommeM.TabStop = true;
            this.rdn_HommeM.Text = "Homme";
            this.rdn_HommeM.UseVisualStyleBackColor = true;
            // 
            // Txt_PrenomM
            // 
            this.Txt_PrenomM.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Txt_PrenomM.Location = new System.Drawing.Point(58, 69);
            this.Txt_PrenomM.Name = "Txt_PrenomM";
            this.Txt_PrenomM.Size = new System.Drawing.Size(190, 20);
            this.Txt_PrenomM.TabIndex = 16;
            this.Txt_PrenomM.Text = "Prenom";
            this.Txt_PrenomM.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_PrenomM_KeyDown_1);
            this.Txt_PrenomM.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_PrenomM_KeyUp_1);
            // 
            // Txt_MDPM
            // 
            this.Txt_MDPM.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Txt_MDPM.Location = new System.Drawing.Point(58, 194);
            this.Txt_MDPM.Name = "Txt_MDPM";
            this.Txt_MDPM.Size = new System.Drawing.Size(190, 20);
            this.Txt_MDPM.TabIndex = 15;
            this.Txt_MDPM.Text = "Mot de Passe";
            this.Txt_MDPM.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_MDPM_KeyDown);
            this.Txt_MDPM.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_MDPM_KeyUp);
            // 
            // Txt_NomM
            // 
            this.Txt_NomM.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Txt_NomM.Location = new System.Drawing.Point(58, 43);
            this.Txt_NomM.Name = "Txt_NomM";
            this.Txt_NomM.Size = new System.Drawing.Size(190, 20);
            this.Txt_NomM.TabIndex = 14;
            this.Txt_NomM.Text = "Nom";
            this.Txt_NomM.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_NomM_KeyDown_1);
            this.Txt_NomM.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_NomM_KeyUp);
            // 
            // test
            // 
            this.test.Location = new System.Drawing.Point(4, 22);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(652, 311);
            this.test.TabIndex = 2;
            this.test.Text = "test";
            this.test.UseVisualStyleBackColor = true;
            this.test.MouseDown += new System.Windows.Forms.MouseEventHandler(this.test_MouseDown);
            // 
            // Ajout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.tabControl1);
            this.MaximumSize = new System.Drawing.Size(700, 400);
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "Ajout";
            this.Text = "Ajout";
            this.Load += new System.EventHandler(this.AjoutRefugies_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageAjoutRef.ResumeLayout(false);
            this.tabPageAjoutRef.PerformLayout();
            this.tabPageAjoutGérant.ResumeLayout(false);
            this.tabPageAjoutGérant.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageAjoutRef;
        private System.Windows.Forms.DateTimePicker DatePicker_DatNaiss;
        private System.Windows.Forms.RadioButton RdBtn_Femme;
        private System.Windows.Forms.RadioButton RdBtn_Homme;
        private System.Windows.Forms.MaskedTextBox Txt_Prenom;
        private System.Windows.Forms.MaskedTextBox Txt_Nom;
        private System.Windows.Forms.TabPage tabPageAjoutGérant;
        private System.Windows.Forms.ComboBox List_Nationalite;
        private System.Windows.Forms.Label Lbl_DateNaiss;
        private System.Windows.Forms.Button Btn_Ajout;
        private System.Windows.Forms.Label Lbl_Nationalite;
        private System.Windows.Forms.Label Lbl_ErrNation;
        private System.Windows.Forms.Label Lbl_Sexe;
        private System.Windows.Forms.Label lbl_errNationM;
        private System.Windows.Forms.Label lbl_errSexM;
        private System.Windows.Forms.Button btn_AjoutM;
        private System.Windows.Forms.Label lbl_NationM;
        private System.Windows.Forms.Label lbl_DatNaissM;
        private System.Windows.Forms.ComboBox list_NationM;
        private System.Windows.Forms.DateTimePicker DatePicker_NaissM;
        private System.Windows.Forms.RadioButton rdn_FemmeM;
        private System.Windows.Forms.RadioButton rdn_HommeM;
        private System.Windows.Forms.MaskedTextBox Txt_PrenomM;
        private System.Windows.Forms.MaskedTextBox Txt_MDPM;
        private System.Windows.Forms.MaskedTextBox Txt_NomM;
        private System.Windows.Forms.Label lbl_errRole;
        private System.Windows.Forms.CheckBox check_Magasinier;
        private System.Windows.Forms.CheckBox check_AgentAccueil;
        private System.Windows.Forms.TabPage test;
    }
}