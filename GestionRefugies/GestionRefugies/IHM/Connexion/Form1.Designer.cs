namespace GestionRefugies
{
    partial class Form_Connexion
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
            this.Btn_Valider = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Txt_Adress = new System.Windows.Forms.TextBox();
            this.Lbl_Alert = new System.Windows.Forms.Label();
            this.Txt_MDP = new System.Windows.Forms.MaskedTextBox();
            this.Txt_ID = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connexion";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_Valider
            // 
            this.Btn_Valider.Location = new System.Drawing.Point(137, 260);
            this.Btn_Valider.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Valider.Name = "Btn_Valider";
            this.Btn_Valider.Size = new System.Drawing.Size(100, 28);
            this.Btn_Valider.TabIndex = 5;
            this.Btn_Valider.Text = "Valider";
            this.Btn_Valider.UseVisualStyleBackColor = true;
            this.Btn_Valider.Click += new System.EventHandler(this.Btn_Valider_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(419, 49);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(443, 255);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Txt_Adress
            // 
            this.Txt_Adress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Adress.Location = new System.Drawing.Point(419, 342);
            this.Txt_Adress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_Adress.Name = "Txt_Adress";
            this.Txt_Adress.ReadOnly = true;
            this.Txt_Adress.Size = new System.Drawing.Size(444, 15);
            this.Txt_Adress.TabIndex = 7;
            this.Txt_Adress.Text = "Adresse du Camp";
            // 
            // Lbl_Alert
            // 
            this.Lbl_Alert.AutoSize = true;
            this.Lbl_Alert.ForeColor = System.Drawing.Color.DarkRed;
            this.Lbl_Alert.Location = new System.Drawing.Point(40, 329);
            this.Lbl_Alert.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Alert.Name = "Lbl_Alert";
            this.Lbl_Alert.Size = new System.Drawing.Size(244, 17);
            this.Lbl_Alert.TabIndex = 8;
            this.Lbl_Alert.Text = "* Veuillez renseigner tous les champs";
            this.Lbl_Alert.Visible = false;
            // 
            // Txt_MDP
            // 
            this.Txt_MDP.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Txt_MDP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Txt_MDP.Location = new System.Drawing.Point(44, 207);
            this.Txt_MDP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_MDP.Name = "Txt_MDP";
            this.Txt_MDP.Size = new System.Drawing.Size(293, 22);
            this.Txt_MDP.TabIndex = 9;
            this.Txt_MDP.Text = "Mot de Passe";
            this.Txt_MDP.UseSystemPasswordChar = true;
            this.Txt_MDP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_MDP_KeyDown);
            this.Txt_MDP.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_MDP_KeyUp);
            // 
            // Txt_ID
            // 
            this.Txt_ID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Txt_ID.Location = new System.Drawing.Point(44, 150);
            this.Txt_ID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_ID.Name = "Txt_ID";
            this.Txt_ID.Size = new System.Drawing.Size(293, 22);
            this.Txt_ID.TabIndex = 10;
            this.Txt_ID.Text = "Identifiant";
            this.Txt_ID.UseWaitCursor = true;
            this.Txt_ID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_ID_KeyDown);
            this.Txt_ID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_ID_KeyUp);
            // 
            // Form_Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(912, 444);
            this.Controls.Add(this.Txt_ID);
            this.Controls.Add(this.Txt_MDP);
            this.Controls.Add(this.Lbl_Alert);
            this.Controls.Add(this.Txt_Adress);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Btn_Valider);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_Connexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Valider;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Txt_Adress;
        private System.Windows.Forms.Label Lbl_Alert;
        private System.Windows.Forms.MaskedTextBox Txt_MDP;
        private System.Windows.Forms.MaskedTextBox Txt_ID;
    }
}

