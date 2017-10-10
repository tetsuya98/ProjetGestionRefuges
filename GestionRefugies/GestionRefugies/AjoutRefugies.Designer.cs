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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.tabPageRechercheRef = new System.Windows.Forms.TabPage();
            this.tabPageStock = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.tabPageAjoutRef.Controls.Add(this.label1);
            this.tabPageAjoutRef.Controls.Add(this.comboBox1);
            this.tabPageAjoutRef.Controls.Add(this.dateTimePicker1);
            this.tabPageAjoutRef.Controls.Add(this.radioButton2);
            this.tabPageAjoutRef.Controls.Add(this.radioButton1);
            this.tabPageAjoutRef.Controls.Add(this.maskedTextBox4);
            this.tabPageAjoutRef.Controls.Add(this.maskedTextBox3);
            this.tabPageAjoutRef.Controls.Add(this.maskedTextBox2);
            this.tabPageAjoutRef.Controls.Add(this.maskedTextBox1);
            this.tabPageAjoutRef.Location = new System.Drawing.Point(4, 22);
            this.tabPageAjoutRef.Name = "tabPageAjoutRef";
            this.tabPageAjoutRef.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAjoutRef.Size = new System.Drawing.Size(652, 311);
            this.tabPageAjoutRef.TabIndex = 0;
            this.tabPageAjoutRef.Text = "Ajouter un Refugié";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(349, 57);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(163, 111);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(58, 111);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.Location = new System.Drawing.Point(58, 69);
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(190, 20);
            this.maskedTextBox4.TabIndex = 3;
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(58, 179);
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(190, 20);
            this.maskedTextBox3.TabIndex = 2;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(58, 205);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(190, 20);
            this.maskedTextBox2.TabIndex = 1;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(58, 43);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(190, 20);
            this.maskedTextBox1.TabIndex = 0;
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "",
            "Français",
            "Anglais",
            "Espagnol",
            "Marocain"});
            this.comboBox1.Location = new System.Drawing.Point(379, 156);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(428, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TabPage tabPageRechercheRef;
        private System.Windows.Forms.TabPage tabPageStock;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}