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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.Txt_Adress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 49);
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
            this.Btn_Valider.Location = new System.Drawing.Point(300, 179);
            this.Btn_Valider.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Valider.Name = "Btn_Valider";
            this.Btn_Valider.Size = new System.Drawing.Size(100, 28);
            this.Btn_Valider.TabIndex = 5;
            this.Btn_Valider.Text = "Valider";
            this.Btn_Valider.UseVisualStyleBackColor = true;
            this.Btn_Valider.Click += new System.EventHandler(this.Btn_Valider_Click);
            // 
            // Lbl_Alert
            // 
            this.Lbl_Alert.AutoSize = true;
            this.Lbl_Alert.ForeColor = System.Drawing.Color.DarkRed;
            this.Lbl_Alert.Location = new System.Drawing.Point(40, 190);
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
            this.Txt_MDP.Location = new System.Drawing.Point(44, 137);
            this.Txt_MDP.Margin = new System.Windows.Forms.Padding(4);
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
            this.Txt_ID.Cursor = System.Windows.Forms.Cursors.Default;
            this.Txt_ID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Txt_ID.Location = new System.Drawing.Point(43, 92);
            this.Txt_ID.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_ID.Name = "Txt_ID";
            this.Txt_ID.Size = new System.Drawing.Size(293, 22);
            this.Txt_ID.TabIndex = 10;
            this.Txt_ID.Text = "Identifiant";
            this.Txt_ID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_ID_KeyDown);
            this.Txt_ID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_ID_KeyUp);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 351);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(293, 22);
            this.textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(30, 415);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(293, 22);
            this.textBox2.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 286);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(47, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Map";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(300, 464);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 15;
            this.button1.Text = "Rechercher";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(407, 11);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(680, 504);
            this.webBrowser1.TabIndex = 16;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // Txt_Adress
            // 
            this.Txt_Adress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Adress.Location = new System.Drawing.Point(13, 500);
            this.Txt_Adress.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Adress.Name = "Txt_Adress";
            this.Txt_Adress.ReadOnly = true;
            this.Txt_Adress.Size = new System.Drawing.Size(444, 15);
            this.Txt_Adress.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "ville";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "pays";
            // 
            // Form_Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1099, 528);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Txt_ID);
            this.Controls.Add(this.Txt_MDP);
            this.Controls.Add(this.Lbl_Alert);
            this.Controls.Add(this.Txt_Adress);
            this.Controls.Add(this.Btn_Valider);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox Txt_Adress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}

