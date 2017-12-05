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
            this.Lbl_Alert = new System.Windows.Forms.Label();
            this.Txt_MDP = new System.Windows.Forms.MaskedTextBox();
            this.Txt_ID = new System.Windows.Forms.MaskedTextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(30, 38);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connexion";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Btn_Valider
            // 
            this.Btn_Valider.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Btn_Valider.Location = new System.Drawing.Point(179, 200);
            this.Btn_Valider.Name = "Btn_Valider";
            this.Btn_Valider.Size = new System.Drawing.Size(75, 23);
            this.Btn_Valider.TabIndex = 5;
            this.Btn_Valider.Text = "Valider";
            this.Btn_Valider.UseVisualStyleBackColor = true;
            this.Btn_Valider.Click += new System.EventHandler(this.Btn_Valider_Click);
            // 
            // Lbl_Alert
            // 
            this.Lbl_Alert.AutoSize = true;
            this.Lbl_Alert.ForeColor = System.Drawing.Color.DarkRed;
            this.Lbl_Alert.Location = new System.Drawing.Point(30, 161);
            this.Lbl_Alert.Name = "Lbl_Alert";
            this.Lbl_Alert.Size = new System.Drawing.Size(181, 13);
            this.Lbl_Alert.TabIndex = 8;
            this.Lbl_Alert.Text = "* Veuillez renseigner tous les champs";
            this.Lbl_Alert.Visible = false;
            // 
            // Txt_MDP
            // 
            this.Txt_MDP.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Txt_MDP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Txt_MDP.Location = new System.Drawing.Point(33, 138);
            this.Txt_MDP.Name = "Txt_MDP";
            this.Txt_MDP.Size = new System.Drawing.Size(221, 20);
            this.Txt_MDP.TabIndex = 9;
            this.Txt_MDP.Text = "Mot de Passe";
            this.Txt_MDP.UseSystemPasswordChar = true;
            this.Txt_MDP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_MDP_KeyDown);
            this.Txt_MDP.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_MDP_KeyUp);
            // 
            // Txt_ID
            // 
            this.Txt_ID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Txt_ID.Location = new System.Drawing.Point(33, 97);
            this.Txt_ID.Name = "Txt_ID";
            this.Txt_ID.Size = new System.Drawing.Size(221, 20);
            this.Txt_ID.TabIndex = 10;
            this.Txt_ID.Text = "Identifiant";
            this.Txt_ID.UseWaitCursor = true;
            this.Txt_ID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_ID_KeyDown);
            this.Txt_ID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_ID_KeyUp);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(280, 12);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(553, 400);
            this.webBrowser1.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1.Location = new System.Drawing.Point(33, 303);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 20);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "ville";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox2.Location = new System.Drawing.Point(33, 351);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(221, 20);
            this.textBox2.TabIndex = 13;
            this.textBox2.Text = "pays";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(30, 263);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(37, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Map";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button1.Location = new System.Drawing.Point(179, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Rechercher";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(845, 424);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.Txt_ID);
            this.Controls.Add(this.Txt_MDP);
            this.Controls.Add(this.Lbl_Alert);
            this.Controls.Add(this.Btn_Valider);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Name = "Form_Connexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Valider;
        private System.Windows.Forms.Label Lbl_Alert;
        private System.Windows.Forms.MaskedTextBox Txt_MDP;
        private System.Windows.Forms.MaskedTextBox Txt_ID;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

