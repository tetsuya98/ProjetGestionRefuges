namespace GestionRefugies
{
    partial class Test
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
            this.BT_login = new System.Windows.Forms.Button();
            this.TXT_login = new System.Windows.Forms.TextBox();
            this.TXT_password = new System.Windows.Forms.TextBox();
            this.BT_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BT_login
            // 
            this.BT_login.Location = new System.Drawing.Point(12, 64);
            this.BT_login.Name = "BT_login";
            this.BT_login.Size = new System.Drawing.Size(258, 21);
            this.BT_login.TabIndex = 0;
            this.BT_login.Text = "Connexion";
            this.BT_login.UseVisualStyleBackColor = true;
            this.BT_login.Click += new System.EventHandler(this.BT_login_Click);
            // 
            // TXT_login
            // 
            this.TXT_login.Location = new System.Drawing.Point(12, 12);
            this.TXT_login.Name = "TXT_login";
            this.TXT_login.Size = new System.Drawing.Size(258, 20);
            this.TXT_login.TabIndex = 1;
            // 
            // TXT_password
            // 
            this.TXT_password.Location = new System.Drawing.Point(12, 38);
            this.TXT_password.Name = "TXT_password";
            this.TXT_password.Size = new System.Drawing.Size(258, 20);
            this.TXT_password.TabIndex = 2;
            // 
            // BT_add
            // 
            this.BT_add.Location = new System.Drawing.Point(276, 12);
            this.BT_add.Name = "BT_add";
            this.BT_add.Size = new System.Drawing.Size(258, 73);
            this.BT_add.TabIndex = 3;
            this.BT_add.Text = "Ajouter un user au pif";
            this.BT_add.UseVisualStyleBackColor = true;
            this.BT_add.Click += new System.EventHandler(this.BT_add_Click);
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 96);
            this.Controls.Add(this.BT_add);
            this.Controls.Add(this.TXT_password);
            this.Controls.Add(this.TXT_login);
            this.Controls.Add(this.BT_login);
            this.Name = "Test";
            this.Text = "Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_login;
        private System.Windows.Forms.TextBox TXT_login;
        private System.Windows.Forms.TextBox TXT_password;
        private System.Windows.Forms.Button BT_add;
    }
}