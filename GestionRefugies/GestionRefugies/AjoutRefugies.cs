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

        #region Txt_Nom
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
            // si on appuie sur un numero ou un caractere special => on supprime l'evenement 
            if (e.KeyValue >= 96 && e.KeyValue <= 105 || e.KeyValue == 49 || e.KeyValue >= 51 && e.KeyValue <= 53 || e.KeyValue == 56 || e.KeyValue == 106 || e.KeyValue == 107 || e.KeyValue == 110 || e.KeyValue == 111)
            {
                e.SuppressKeyPress = true;
            }
            if (Txt_Nom.Text == "Nom" || Txt_Nom.Text == "Nom Incorrect")
            {
                this.Txt_Nom.ForeColor = System.Drawing.Color.Black;
                Txt_Nom.Text = "";
            }
        }
        #endregion


        #region Txt_Prenom
        private void Txt_Prenom_KeyDown(object sender, KeyEventArgs e)
        {
            // si on appuie sur un numero ou un caractere special => on supprime l'evenement 
            if (e.KeyValue >= 96 && e.KeyValue <= 105 || e.KeyValue == 49 || e.KeyValue >= 51 && e.KeyValue <= 53 || e.KeyValue == 56 || e.KeyValue == 106 || e.KeyValue == 107 || e.KeyValue == 110 || e.KeyValue == 111)
            {
                e.SuppressKeyPress = true;
            }
            if (Txt_Prenom.Text == "Prenom" || Txt_Prenom.Text == "Prenom Incorrect")
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
        #endregion


        #region Txt_ID
        private void Txt_ID_KeyDown(object sender, KeyEventArgs e)
        {
            if (Txt_ID.Text == "Identifiant" || Txt_ID.Text == "Identifiant Incorrect")
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
        #endregion


        #region Txt_MDP
        private void Txt_MDP_KeyDown(object sender, KeyEventArgs e)
        {
            if (Txt_MDP.Text == "Mot de Passe" || Txt_MDP.Text == "Mot de Passe Incorrect")
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
        #endregion


        #region Btn_Ajout
        private void Btn_Ajout_Click(object sender, EventArgs e)
        {

            // ce if est degueulasse ... désolé

            if (Txt_Nom.Text != "Nom" && Txt_Nom.Text != "Nom Incorrect" && Txt_Prenom.Text != "Prenom" && Txt_Prenom.Text != "Prenom Incorrect" && Txt_MDP.Text != "Mot de passe" && Txt_MDP.Text != "Mot de passe Incorrect" && Txt_ID.Text != "Identifiant" && Txt_ID.Text != "Identifiant Incorrect" && List_Nationalite.Text != "" && (RdBtn_Femme.Checked == true || RdBtn_Homme.Checked == true))
            {
                //appel bd

            }
            else
            {
                if (Txt_Nom.Text == "" || Txt_Nom.Text == "Nom")
                {
                    this.Txt_Nom.ForeColor = System.Drawing.Color.Red;
                    Txt_Nom.Text = "Nom Incorrect";
                }
                if (Txt_Prenom.Text == "" || Txt_Prenom.Text == "Prenom")
                {
                    this.Txt_Prenom.ForeColor = System.Drawing.Color.Red;
                    Txt_Prenom.Text = "Prenom Incorrect";
                }
                if (Txt_MDP.Text == "" || Txt_MDP.Text == "Mot de Passe")
                {
                    this.Txt_MDP.ForeColor = System.Drawing.Color.Red;
                    Txt_MDP.Text = "Mot de Passe Incorrect";
                }
                if (Txt_ID.Text == "" || Txt_ID.Text == "Identifiant")
                {
                    this.Txt_ID.ForeColor = System.Drawing.Color.Red;
                    Txt_ID.Text = "Identifiant Incorrect";
                }
                if (List_Nationalite.Text == "")
                {
                    Lbl_ErrNation.Visible = true;
                }
                else
                {
                    Lbl_ErrNation.Visible = false;
                }
                if (RdBtn_Homme.Checked == false && RdBtn_Femme.Checked == false)
                {
                    Lbl_Sexe.Visible = true;
                }
                else
                {
                    Lbl_Sexe.Visible = false;
                }
            }
        }
        #endregion

        private void DatePicker_DatNaiss_ValueChanged(object sender, EventArgs e)
        {
            
            if (DatePicker_DatNaiss.Value >= DateTime.Now)
            {
                DatePicker_DatNaiss.Value = DateTime.Now;
            }
        }
    }
}
