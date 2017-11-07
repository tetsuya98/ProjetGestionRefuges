namespace GestionRefugies
{
    partial class Connexion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_ID = new System.Windows.Forms.TextBox();
            this.Txt_MDP = new System.Windows.Forms.TextBox();
            this.Btn_Valider = new System.Windows.Forms.Button();
            this.MAP = new System.Windows.Forms.PictureBox();
            this.Txt_Adress = new System.Windows.Forms.TextBox();
            this.creer = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MAP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(44, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connexion";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Txt_ID
            // 
            this.Txt_ID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Txt_ID.Location = new System.Drawing.Point(33, 126);
            this.Txt_ID.Name = "Txt_ID";
            this.Txt_ID.Size = new System.Drawing.Size(221, 20);
            this.Txt_ID.TabIndex = 1;
            this.Txt_ID.Text = "Identifiant";
            this.Txt_ID.Click += new System.EventHandler(this.Txt_ID_Click);
            this.Txt_ID.TextChanged += new System.EventHandler(this.Txt_ID_TextChanged);
            // 
            // Txt_MDP
            // 
            this.Txt_MDP.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Txt_MDP.Location = new System.Drawing.Point(33, 171);
            this.Txt_MDP.Name = "Txt_MDP";
            this.Txt_MDP.Size = new System.Drawing.Size(221, 20);
            this.Txt_MDP.TabIndex = 2;
            this.Txt_MDP.Text = "Mot de Passe";
            this.Txt_MDP.Click += new System.EventHandler(this.Txt_MDP_Click);
            this.Txt_MDP.TextChanged += new System.EventHandler(this.Txt_MDP_TextChanged);
            // 
            // Btn_Valider
            // 
            this.Btn_Valider.Location = new System.Drawing.Point(103, 211);
            this.Btn_Valider.Name = "Btn_Valider";
            this.Btn_Valider.Size = new System.Drawing.Size(75, 23);
            this.Btn_Valider.TabIndex = 5;
            this.Btn_Valider.Text = "Valider";
            this.Btn_Valider.UseVisualStyleBackColor = true;
            this.Btn_Valider.Click += new System.EventHandler(this.Btn_Valider_Click);
            // 
            // MAP
            // 
            this.MAP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MAP.Location = new System.Drawing.Point(314, 40);
            this.MAP.Name = "MAP";
            this.MAP.Size = new System.Drawing.Size(333, 208);
            this.MAP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.MAP.TabIndex = 6;
            this.MAP.TabStop = false;
            // 
            // Txt_Adress
            // 
            this.Txt_Adress.Location = new System.Drawing.Point(314, 278);
            this.Txt_Adress.Name = "Txt_Adress";
            this.Txt_Adress.ReadOnly = true;
            this.Txt_Adress.Size = new System.Drawing.Size(333, 20);
            this.Txt_Adress.TabIndex = 7;
            this.Txt_Adress.Text = "Adresse du Camp";
            // 
            // creer
            // 
            this.creer.Location = new System.Drawing.Point(103, 278);
            this.creer.Name = "creer";
            this.creer.Size = new System.Drawing.Size(75, 23);
            this.creer.TabIndex = 8;
            this.creer.Text = "creer";
            this.creer.UseVisualStyleBackColor = true;
            this.creer.Click += new System.EventHandler(this.creer_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(194, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.creer);
            this.Controls.Add(this.Txt_Adress);
            this.Controls.Add(this.MAP);
            this.Controls.Add(this.Btn_Valider);
            this.Controls.Add(this.Txt_MDP);
            this.Controls.Add(this.Txt_ID);
            this.Controls.Add(this.label1);
            this.Name = "Connexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MAP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_ID;
        private System.Windows.Forms.TextBox Txt_MDP;
        private System.Windows.Forms.Button Btn_Valider;
        private System.Windows.Forms.PictureBox MAP;
        private System.Windows.Forms.TextBox Txt_Adress;
        private System.Windows.Forms.Button creer;
        private System.Windows.Forms.Button button1;
    }
}

