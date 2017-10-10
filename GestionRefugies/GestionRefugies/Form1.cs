﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionRefugies
{
    public partial class Form_Connexion : Form
    {
        public Form_Connexion()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Form1_Load appelle la BD pour l'adresse du camp.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Txt_Adress.Text = /*appel de BD*/ "Adresse du Camps";
        }
        /// <summary>
        /// Btn_Valider_Click appelle la BD pour verifier les mots de passe/id
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Valider_Click(object sender, EventArgs e)
        {
            
            if (((Txt_ID.Text != "") && (Txt_MDP.Text != "")) && (Txt_ID.Text != "Identifiant") && (Txt_MDP.Text != "Mot de Passe"))
            {
                
            }
            else
            {
                this.Lbl_Alert.Visible = true;
                this.Txt_ID.ForeColor = System.Drawing.SystemColors.WindowFrame;
                this.Txt_MDP.ForeColor = System.Drawing.SystemColors.WindowFrame;
                this.Txt_ID.Text = "Identifiant";
                this.Txt_MDP.Text = "Mot de Passe";
            }
        }

        
        
        private void Txt_MDP_Click_1(object sender, EventArgs e)
        {
            if (this.Txt_MDP.Text == "Mot de Passe")
            {
                this.Txt_MDP.Text = "";
            }
        }

        private void Txt_ID_Click_1(object sender, EventArgs e)
        {
            if (this.Txt_ID.Text == "Identifiant")
            {
                this.Txt_ID.Text = "";
            }
        }

        private void Txt_MDP_TextChanged_1(object sender, EventArgs e)
        {
            this.Txt_MDP.ForeColor = System.Drawing.Color.Black;
        }

        private void Txt_ID_TextChanged_1(object sender, EventArgs e)
        {
            this.Txt_ID.ForeColor = System.Drawing.Color.Black;
        }

        private void Txt_ID_Leave(object sender, EventArgs e)
        {
            if (this.Txt_ID.Text == "")
            {
                this.Txt_ID.ForeColor = System.Drawing.SystemColors.WindowFrame;
                this.Txt_ID.Text = "Identifiant";
            }
        }

        private void Txt_MDP_Leave(object sender, EventArgs e)
        {
            if (this.Txt_MDP.Text == "")
            {

                this.Txt_MDP.ForeColor = System.Drawing.SystemColors.WindowFrame;
                this.Txt_MDP.Text = "Mot de Passe";
            }
        }
    }
}
