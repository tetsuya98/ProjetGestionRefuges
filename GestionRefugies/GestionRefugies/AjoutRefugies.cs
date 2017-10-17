using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
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
    public partial class AjoutRefugies : Form
    {
        public AjoutRefugies()
        {
            InitializeComponent();
        }

        private void AjoutRefugies_Load(object sender, EventArgs e)
        {
            
        }

        

        

        private void Txt_Nom_KeyUp(object sender, KeyEventArgs e)
        {
            if (Txt_Nom.Text == "")
            {
                this.Txt_Nom.ForeColor = System.Drawing.SystemColors.WindowFrame;
                Txt_Nom.Text = "Nom";
            }
        }

        private void Txt_Nom_KeyDown(object sender, KeyEventArgs e)
        {
            if (Txt_Nom.Text == "Nom")
            {
                this.Txt_Nom.ForeColor = System.Drawing.Color.Black;
                Txt_Nom.Text = "";
            }
        }

        private void Txt_Prenom_KeyDown(object sender, KeyEventArgs e)
        {
            if (Txt_Prenom.Text == "Prenom")
            {
                this.Txt_Prenom.ForeColor = System.Drawing.Color.Black;
                Txt_Prenom.Text = "";
            }
        }

        private void Txt_Prenom_KeyUp(object sender, KeyEventArgs e)
        {
            if (Txt_Prenom.Text == "")
            {
                this.Txt_Prenom.ForeColor = System.Drawing.SystemColors.WindowFrame;
                Txt_Prenom.Text = "Prenom";
            }
        }

        private void Txt_ID_KeyDown(object sender, KeyEventArgs e)
        {
            if (Txt_ID.Text == "Identifiant")
            {
                this.Txt_ID.ForeColor = System.Drawing.Color.Black;
                Txt_ID.Text = "";
            }
        }

        private void Txt_ID_KeyUp(object sender, KeyEventArgs e)
        {
            if (Txt_ID.Text == "")
            {
                this.Txt_ID.ForeColor = System.Drawing.SystemColors.WindowFrame;
                Txt_ID.Text = "Identifiant";
            }
        }

        private void Txt_MDP_KeyDown(object sender, KeyEventArgs e)
        {
            if (Txt_MDP.Text == "Mot de Passe")
            {
                this.Txt_MDP.ForeColor = System.Drawing.Color.Black;
                Txt_MDP.Text = "";
            }
        }

        private void Txt_MDP_KeyUp(object sender, KeyEventArgs e)
        {
            if (Txt_MDP.Text == "")
            {
                this.Txt_MDP.ForeColor = System.Drawing.SystemColors.WindowFrame;
                Txt_MDP.Text = "Mot de Passe";
            }
        }

        private void Btn_Ajout_Click(object sender, EventArgs e)
        {
            if (Txt_Nom.Text != "Nom" && Txt_Prenom.Text != "Prenom" && Txt_MDP.Text != "Mot de passe" && Txt_ID.Text != "Identifiant")
            {
                
        
            }
        }
    }
}
