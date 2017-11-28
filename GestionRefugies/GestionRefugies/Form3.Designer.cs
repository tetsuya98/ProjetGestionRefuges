namespace GestionRefugies
{
    partial class Form3
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colonne_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colonne_Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colonne_Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colonne_natio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colonne_sexe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colonne_adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colonne_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colonne_Id,
            this.colonne_Prenom,
            this.colonne_Nom,
            this.colonne_natio,
            this.Colonne_sexe,
            this.colonne_adresse,
            this.colonne_date});
            this.dataGridView1.Location = new System.Drawing.Point(260, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(628, 541);
            this.dataGridView1.TabIndex = 0;
            // 
            // colonne_Id
            // 
            this.colonne_Id.HeaderText = "ID";
            this.colonne_Id.Name = "colonne_Id";
            this.colonne_Id.ReadOnly = true;
            // 
            // colonne_Prenom
            // 
            this.colonne_Prenom.HeaderText = "Prenom";
            this.colonne_Prenom.Name = "colonne_Prenom";
            this.colonne_Prenom.ReadOnly = true;
            // 
            // colonne_Nom
            // 
            this.colonne_Nom.HeaderText = "Nom";
            this.colonne_Nom.Name = "colonne_Nom";
            this.colonne_Nom.ReadOnly = true;
            // 
            // colonne_natio
            // 
            this.colonne_natio.HeaderText = "nationalité";
            this.colonne_natio.Name = "colonne_natio";
            this.colonne_natio.ReadOnly = true;
            // 
            // Colonne_sexe
            // 
            this.Colonne_sexe.HeaderText = "sexe";
            this.Colonne_sexe.Name = "Colonne_sexe";
            this.Colonne_sexe.ReadOnly = true;
            // 
            // colonne_adresse
            // 
            this.colonne_adresse.HeaderText = "adresse";
            this.colonne_adresse.Name = "colonne_adresse";
            this.colonne_adresse.ReadOnly = true;
            // 
            // colonne_date
            // 
            this.colonne_date.HeaderText = "Date de naissance";
            this.colonne_date.Name = "colonne_date";
            this.colonne_date.ReadOnly = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(89, 260);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 78);
            this.button2.TabIndex = 2;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 565);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colonne_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn colonne_Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colonne_Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colonne_natio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colonne_sexe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colonne_adresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn colonne_date;
    }
}