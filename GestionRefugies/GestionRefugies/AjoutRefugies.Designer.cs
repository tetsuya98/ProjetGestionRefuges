namespace GestionRefugies
{
    partial class AjoutRefugies
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
            this.Btn_Ajout = new System.Windows.Forms.Button();
            this.Lbl_Nationalite = new System.Windows.Forms.Label();
            this.Lbl_DateNaiss = new System.Windows.Forms.Label();
            this.List_Nationalite = new System.Windows.Forms.ComboBox();
            this.DatePicker_DatNaiss = new System.Windows.Forms.DateTimePicker();
            this.RdBtn_Femme = new System.Windows.Forms.RadioButton();
            this.RdBtn_Homme = new System.Windows.Forms.RadioButton();
            this.Txt_Prenom = new System.Windows.Forms.MaskedTextBox();
            this.Txt_ID = new System.Windows.Forms.MaskedTextBox();
            this.Txt_MDP = new System.Windows.Forms.MaskedTextBox();
            this.Txt_Nom = new System.Windows.Forms.MaskedTextBox();
            this.tabPageRechercheRef = new System.Windows.Forms.TabPage();
            this.tabPageStock = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPageAjoutRef.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageAjoutRef);
            this.tabControl1.Controls.Add(this.tabPageRechercheRef);
            this.tabControl1.Controls.Add(this.tabPageStock);
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
            this.tabPageAjoutRef.Controls.Add(this.Btn_Ajout);
            this.tabPageAjoutRef.Controls.Add(this.Lbl_Nationalite);
            this.tabPageAjoutRef.Controls.Add(this.Lbl_DateNaiss);
            this.tabPageAjoutRef.Controls.Add(this.List_Nationalite);
            this.tabPageAjoutRef.Controls.Add(this.DatePicker_DatNaiss);
            this.tabPageAjoutRef.Controls.Add(this.RdBtn_Femme);
            this.tabPageAjoutRef.Controls.Add(this.RdBtn_Homme);
            this.tabPageAjoutRef.Controls.Add(this.Txt_Prenom);
            this.tabPageAjoutRef.Controls.Add(this.Txt_ID);
            this.tabPageAjoutRef.Controls.Add(this.Txt_MDP);
            this.tabPageAjoutRef.Controls.Add(this.Txt_Nom);
            this.tabPageAjoutRef.Location = new System.Drawing.Point(4, 22);
            this.tabPageAjoutRef.Name = "tabPageAjoutRef";
            this.tabPageAjoutRef.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAjoutRef.Size = new System.Drawing.Size(652, 311);
            this.tabPageAjoutRef.TabIndex = 0;
            this.tabPageAjoutRef.Text = "Ajouter un Refugié";
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
            // Txt_ID
            // 
            this.Txt_ID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Txt_ID.Location = new System.Drawing.Point(58, 179);
            this.Txt_ID.Name = "Txt_ID";
            this.Txt_ID.Size = new System.Drawing.Size(190, 20);
            this.Txt_ID.TabIndex = 2;
            this.Txt_ID.Text = "Identifiant";
            this.Txt_ID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_ID_KeyDown);
            this.Txt_ID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_ID_KeyUp);
            // 
            // Txt_MDP
            // 
            this.Txt_MDP.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Txt_MDP.Location = new System.Drawing.Point(58, 205);
            this.Txt_MDP.Name = "Txt_MDP";
            this.Txt_MDP.Size = new System.Drawing.Size(190, 20);
            this.Txt_MDP.TabIndex = 1;
            this.Txt_MDP.Text = "Mot de Passe";
            this.Txt_MDP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_MDP_KeyDown);
            this.Txt_MDP.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_MDP_KeyUp);
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
            // tabPageRechercheRef
            // 
            this.tabPageRechercheRef.Location = new System.Drawing.Point(4, 22);
            this.tabPageRechercheRef.Name = "tabPageRechercheRef";
            this.tabPageRechercheRef.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRechercheRef.Size = new System.Drawing.Size(652, 311);
            this.tabPageRechercheRef.TabIndex = 1;
            this.tabPageRechercheRef.Text = "Rechercher un Refugié";
            this.tabPageRechercheRef.UseVisualStyleBackColor = true;
            // 
            // tabPageStock
            // 
            this.tabPageStock.Location = new System.Drawing.Point(4, 22);
            this.tabPageStock.Name = "tabPageStock";
            this.tabPageStock.Size = new System.Drawing.Size(652, 311);
            this.tabPageStock.TabIndex = 2;
            this.tabPageStock.Text = "Gestion des Stocks";
            this.tabPageStock.UseVisualStyleBackColor = true;
            // 
            // AjoutRefugies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.tabControl1);
            this.Name = "AjoutRefugies";
            this.Text = "AjoutRefugies";
            this.Load += new System.EventHandler(this.AjoutRefugies_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageAjoutRef.ResumeLayout(false);
            this.tabPageAjoutRef.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageAjoutRef;
        private System.Windows.Forms.DateTimePicker DatePicker_DatNaiss;
        private System.Windows.Forms.RadioButton RdBtn_Femme;
        private System.Windows.Forms.RadioButton RdBtn_Homme;
        private System.Windows.Forms.MaskedTextBox Txt_Prenom;
        private System.Windows.Forms.MaskedTextBox Txt_ID;
        private System.Windows.Forms.MaskedTextBox Txt_MDP;
        private System.Windows.Forms.MaskedTextBox Txt_Nom;
        private System.Windows.Forms.TabPage tabPageRechercheRef;
        private System.Windows.Forms.TabPage tabPageStock;
        private System.Windows.Forms.ComboBox List_Nationalite;
        private System.Windows.Forms.Label Lbl_DateNaiss;
        private System.Windows.Forms.Button Btn_Ajout;
        private System.Windows.Forms.Label Lbl_Nationalite;
    }
}