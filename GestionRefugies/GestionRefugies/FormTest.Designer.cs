namespace GestionRefugies
{
    partial class FormTest
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.BT_login = new System.Windows.Forms.Button();
            this.BT_selectUser = new System.Windows.Forms.Button();
            this.BT_delUser = new System.Windows.Forms.Button();
            this.BT_updateUser = new System.Windows.Forms.Button();
            this.BT_addUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 101);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(156, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 101);
            this.button2.TabIndex = 1;
            this.button2.Text = "Modifier";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 166);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 101);
            this.button3.TabIndex = 2;
            this.button3.Text = "Supprimer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(156, 166);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(138, 101);
            this.button4.TabIndex = 3;
            this.button4.Text = "Afficher";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // BT_login
            // 
            this.BT_login.Location = new System.Drawing.Point(300, 273);
            this.BT_login.Name = "BT_login";
            this.BT_login.Size = new System.Drawing.Size(282, 93);
            this.BT_login.TabIndex = 4;
            this.BT_login.Text = "Login";
            this.BT_login.UseVisualStyleBackColor = true;
            this.BT_login.Click += new System.EventHandler(this.BT_login_Click);
            // 
            // BT_selectUser
            // 
            this.BT_selectUser.Location = new System.Drawing.Point(444, 166);
            this.BT_selectUser.Name = "BT_selectUser";
            this.BT_selectUser.Size = new System.Drawing.Size(138, 101);
            this.BT_selectUser.TabIndex = 8;
            this.BT_selectUser.Text = "Afficher";
            this.BT_selectUser.UseVisualStyleBackColor = true;
            this.BT_selectUser.Click += new System.EventHandler(this.BT_selectUser_Click);
            // 
            // BT_delUser
            // 
            this.BT_delUser.Location = new System.Drawing.Point(300, 166);
            this.BT_delUser.Name = "BT_delUser";
            this.BT_delUser.Size = new System.Drawing.Size(138, 101);
            this.BT_delUser.TabIndex = 7;
            this.BT_delUser.Text = "Supprimer";
            this.BT_delUser.UseVisualStyleBackColor = true;
            this.BT_delUser.Click += new System.EventHandler(this.BT_delUser_Click);
            // 
            // BT_updateUser
            // 
            this.BT_updateUser.Location = new System.Drawing.Point(444, 59);
            this.BT_updateUser.Name = "BT_updateUser";
            this.BT_updateUser.Size = new System.Drawing.Size(138, 101);
            this.BT_updateUser.TabIndex = 6;
            this.BT_updateUser.Text = "Modifier";
            this.BT_updateUser.UseVisualStyleBackColor = true;
            // 
            // BT_addUser
            // 
            this.BT_addUser.Location = new System.Drawing.Point(300, 59);
            this.BT_addUser.Name = "BT_addUser";
            this.BT_addUser.Size = new System.Drawing.Size(138, 101);
            this.BT_addUser.TabIndex = 5;
            this.BT_addUser.Text = "Ajouter";
            this.BT_addUser.UseVisualStyleBackColor = true;
            this.BT_addUser.Click += new System.EventHandler(this.BT_addUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Refugier";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(416, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "User";
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 389);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BT_selectUser);
            this.Controls.Add(this.BT_delUser);
            this.Controls.Add(this.BT_updateUser);
            this.Controls.Add(this.BT_addUser);
            this.Controls.Add(this.BT_login);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FormTest";
            this.Text = "FormTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button BT_login;
        private System.Windows.Forms.Button BT_selectUser;
        private System.Windows.Forms.Button BT_delUser;
        private System.Windows.Forms.Button BT_updateUser;
        private System.Windows.Forms.Button BT_addUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}