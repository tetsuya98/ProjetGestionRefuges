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
    public partial class Ajout : Form
    {
        public Ajout()
        {
            InitializeComponent();
        }

        private void AjoutRefugies_Load(object sender, EventArgs e)
        {
            
        }

        #region AjoutRefugié

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


        #region Btn_Ajout
        private void Btn_Ajout_Click(object sender, EventArgs e)
        {

            // ce if est degueulasse ... désolé

            if (Txt_Nom.Text != "Nom" && Txt_Nom.Text != "Nom Incorrect" && Txt_Prenom.Text != "Prenom" && Txt_Prenom.Text != "Prenom Incorrect" && List_Nationalite.Text != "" && (RdBtn_Femme.Checked == true || RdBtn_Homme.Checked == true))
            {
                String sex;
                if (RdBtn_Femme.Checked == true)
                {
                    sex = "Femme";
                }
                else
                {
                    sex = "Homme";
                }
                //Refugier refu = new Refugier(Txt_Nom.Text, Txt_Prenom.Text, "" ,sex, DatePicker_DatNaiss.Value, List_Nationalite.Text, 1);
                //bool res = RefugierManage.ajouterRefugier(refu);
                //if (res)
                //{
                //    MessageBox.Show("Ajout validé et enregistré dans la BDD");
                //}
                //else
                //{
                //    MessageBox.Show("erreur creation refugier");
                //}

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


        #region Datepicker_DateNaiss
        private void DatePicker_DatNaiss_ValueChanged(object sender, EventArgs e)
        {

            if (DatePicker_DatNaiss.Value >= DateTime.Now)
            {
                DatePicker_DatNaiss.Value = DateTime.Now;
            }
        }


        #endregion

        #endregion


        #region AjoutMagasinier
        #region Txt_Nom
        private void Txt_NomM_KeyUp(object sender, KeyEventArgs e)
        {

            if (Txt_NomM.Text == "")
            {
                this.Txt_NomM.ForeColor = System.Drawing.SystemColors.WindowFrame;
                Txt_NomM.Text = "Nom";
            }
        }

        private void Txt_NomM_KeyDown_1(object sender, KeyEventArgs e)
        {
            // si on appuie sur un numero ou un caractere special => on supprime l'evenement 
            if (e.KeyValue >= 96 && e.KeyValue <= 105 || e.KeyValue == 49 || e.KeyValue >= 51 && e.KeyValue <= 53 || e.KeyValue == 56 || e.KeyValue == 106 || e.KeyValue == 107 || e.KeyValue == 110 || e.KeyValue == 111)
            {
                e.SuppressKeyPress = true;
            }
            if (Txt_NomM.Text == "Nom" || Txt_NomM.Text == "Nom Incorrect")
            {
                this.Txt_NomM.ForeColor = System.Drawing.Color.Black;
                Txt_NomM.Text = "";
            }
        }
        #endregion
        
        #region Txt_Prenom
        private void Txt_PrenomM_KeyDown_1(object sender, KeyEventArgs e)
        {
            // si on appuie sur un numero ou un caractere special => on supprime l'evenement 
            if (e.KeyValue >= 96 && e.KeyValue <= 105 || e.KeyValue == 49 || e.KeyValue >= 51 && e.KeyValue <= 53 || e.KeyValue == 56 || e.KeyValue == 106 || e.KeyValue == 107 || e.KeyValue == 110 || e.KeyValue == 111)
            {
                e.SuppressKeyPress = true;
            }
            if (Txt_PrenomM.Text == "Prenom" || Txt_PrenomM.Text == "Prenom Incorrect")
            {
                this.Txt_PrenomM.ForeColor = System.Drawing.Color.Black;
                Txt_PrenomM.Text = "";
            }
        }

        private void Txt_PrenomM_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (Txt_PrenomM.Text == "")
            {
                this.Txt_PrenomM.ForeColor = System.Drawing.SystemColors.WindowFrame;
                Txt_PrenomM.Text = "Prenom";
            }
        }
        #endregion
        
        #region Txt_MDP
        private void Txt_MDPM_KeyUp(object sender, KeyEventArgs e)
        {
            if (Txt_MDPM.Text == "")
            {
                this.Txt_MDPM.ForeColor = System.Drawing.SystemColors.WindowFrame;
                Txt_MDPM.Text = "Mot de Passe";
            }
        }

        private void Txt_MDPM_KeyDown(object sender, KeyEventArgs e)
        {

            if (Txt_MDPM.Text == "Mot de Passe" || Txt_MDPM.Text == "Mot de Passe Incorrect")
            {
                this.Txt_MDPM.ForeColor = System.Drawing.Color.Black;
                Txt_MDPM.Text = "";
            }
        } 
        #endregion

        #region Btn_Ajout
        
        private void btn_AjoutM_Click_1(object sender, EventArgs e)
        {
            // ce if est degueulasse ... désolé

            if (Txt_NomM.Text != "Nom" && Txt_NomM.Text != "Nom Incorrect" && Txt_PrenomM.Text != "Prenom" && Txt_PrenomM.Text != "Prenom Incorrect" && Txt_MDPM.Text != "Mot de passe" && Txt_MDPM.Text != "Mot de passe Incorrect" && list_NationM.Text != "" && (rdn_FemmeM.Checked == true || rdn_HommeM.Checked == true))
            {
                String sex;
                if (rdn_FemmeM.Checked == true)
                {
                    sex = "Femme";
                }
                else
                {
                    sex = "Homme";
                }
                //Magasinier maga = new Magasinier(Txt_NomM.Text, Txt_PrenomM.Text, Txt_MDPM.Text, sex, DatePicker_NaissM.Value, list_NationM.Text, 1);
                //bool res = RefugierManage.ajouterRefugier(refu);
                //if (res)
                //{
                //    MessageBox.Show("Ajout validé et enregistré dans la BDD");
                //}
                //else
                //{
                //    MessageBox.Show("erreur creation refugier");
                //}

            }
            else
            {
                if (Txt_NomM.Text == "" || Txt_NomM.Text == "Nom")
                {
                    this.Txt_NomM.ForeColor = System.Drawing.Color.Red;
                    Txt_NomM.Text = "Nom Incorrect";
                }
                if (Txt_PrenomM.Text == "" || Txt_PrenomM.Text == "Prenom")
                {
                    this.Txt_PrenomM.ForeColor = System.Drawing.Color.Red;
                    Txt_PrenomM.Text = "Prenom Incorrect";
                }
                if (Txt_MDPM.Text == "" || Txt_MDPM.Text == "Mot de Passe")
                {
                    this.Txt_MDPM.ForeColor = System.Drawing.Color.Red;
                    Txt_MDPM.Text = "Mot de Passe Incorrect";
                }
                if (list_NationM.Text == "")
                {
                    lbl_errNationM.Visible = true;
                }
                else
                {
                    lbl_errNationM.Visible = false;
                }
                if (rdn_HommeM.Checked == false && rdn_FemmeM.Checked == false)
                {
                    lbl_errSexM.Visible = true;
                }
                else
                {
                    lbl_errSexM.Visible = false;
                }
            }
        }
        #endregion
        
        #region Datepicker_DateNaiss
        
        private void DatePicker_NaissM_ValueChanged_1(object sender, EventArgs e)
        {
            if (DatePicker_NaissM.Value >= DateTime.Now)
            {
                DatePicker_NaissM.Value = DateTime.Now;
            }
        }


        #endregion

        #endregion

        #region AjoutAgentAccueil
        #region Txt_Nom
        private void Txt_NomAA_KeyUp(object sender, KeyEventArgs e)
        {
            if (Txt_NomAA.Text == "")
            {
                this.Txt_NomAA.ForeColor = System.Drawing.SystemColors.WindowFrame;
                Txt_NomAA.Text = "Nom";
            }
        }

        private void Txt_NomAA_KeyDown(object sender, KeyEventArgs e)
        {
            // si on appuie sur un numero ou un caractere special => on supprime l'evenement 
            if (e.KeyValue >= 96 && e.KeyValue <= 105 || e.KeyValue == 49 || e.KeyValue >= 51 && e.KeyValue <= 53 || e.KeyValue == 56 || e.KeyValue == 106 || e.KeyValue == 107 || e.KeyValue == 110 || e.KeyValue == 111)
            {
                e.SuppressKeyPress = true;
            }
            if (Txt_NomAA.Text == "Nom" || Txt_NomAA.Text == "Nom Incorrect")
            {
                this.Txt_NomAA.ForeColor = System.Drawing.Color.Black;
                Txt_NomAA.Text = "";
            }
        }
        #endregion

        #region Txt_Prenom
        private void Txt_PrenomAA_KeyUp(object sender, KeyEventArgs e)
        {
            if (Txt_PrenomAA.Text == "")
            {
                this.Txt_PrenomAA.ForeColor = System.Drawing.SystemColors.WindowFrame;
                Txt_PrenomAA.Text = "Prenom";
            }
        }

        private void Txt_PrenomAA_KeyDown(object sender, KeyEventArgs e)
        {
            // si on appuie sur un numero ou un caractere special => on supprime l'evenement 
            if (e.KeyValue >= 96 && e.KeyValue <= 105 || e.KeyValue == 49 || e.KeyValue >= 51 && e.KeyValue <= 53 || e.KeyValue == 56 || e.KeyValue == 106 || e.KeyValue == 107 || e.KeyValue == 110 || e.KeyValue == 111)
            {
                e.SuppressKeyPress = true;
            }
            if (Txt_PrenomAA.Text == "Prenom" || Txt_PrenomAA.Text == "Prenom Incorrect")
            {
                this.Txt_PrenomAA.ForeColor = System.Drawing.Color.Black;
                Txt_PrenomAA.Text = "";
            }
        }
        #endregion

        #region Txt_MDP
        private void Txt_MDPAA_KeyUp(object sender, KeyEventArgs e)
        {
            if (Txt_MDPAA.Text == "")
            {
                this.Txt_MDPAA.ForeColor = System.Drawing.SystemColors.WindowFrame;
                Txt_MDPAA.Text = "Mot de Passe";
            }
        }

        private void Txt_MDPAA_KeyDown(object sender, KeyEventArgs e)
        {
            if (Txt_MDPAA.Text == "Mot de Passe" || Txt_MDPAA.Text == "Mot de Passe Incorrect")
            {
                this.Txt_MDPAA.ForeColor = System.Drawing.Color.Black;
                Txt_MDPAA.Text = "";
            }
        }
        #endregion

        #region DatePicker_DatNaissAA
        private void DatePicker_DatNaissAA_ValueChanged(object sender, EventArgs e)
        {
            if (DatePicker_DatNaissAA.Value >= DateTime.Now)
            {
                DatePicker_DatNaissAA.Value = DateTime.Now;
            }
        } 
        #endregion

        private void btn_AjoutAA_Click(object sender, EventArgs e)
        {
            // ce if est degueulasse ... désolé

            if (Txt_NomAA.Text != "Nom" && Txt_NomAA.Text != "Nom Incorrect" && Txt_PrenomAA.Text != "Prenom" && Txt_PrenomAA.Text != "Prenom Incorrect" && Txt_MDPAA.Text != "Mot de passe" && Txt_MDPAA.Text != "Mot de passe Incorrect" && list_NationAA.Text != "" && (rdn_FemmeAA.Checked == true || rdn_HommeAA.Checked == true))
            {
                String sex;
                if (rdn_FemmeAA.Checked == true)
                {
                    sex = "Femme";
                }
                else
                {
                    sex = "Homme";
                }
                //Magasinier maga = new Magasinier(Txt_NomM.Text, Txt_PrenomM.Text, Txt_MDPM.Text, sex, DatePicker_NaissM.Value, list_NationM.Text, 1);
                //bool res = RefugierManage.ajouterRefugier(refu);
                //if (res)
                //{
                //    MessageBox.Show("Ajout validé et enregistré dans la BDD");
                //}
                //else
                //{
                //    MessageBox.Show("erreur creation refugier");
                //}

            }
            else
            {
                if (Txt_NomAA.Text == "" || Txt_NomAA.Text == "Nom")
                {
                    this.Txt_NomAA.ForeColor = System.Drawing.Color.Red;
                    Txt_NomAA.Text = "Nom Incorrect";
                }
                if (Txt_PrenomAA.Text == "" || Txt_PrenomAA.Text == "Prenom")
                {
                    this.Txt_PrenomAA.ForeColor = System.Drawing.Color.Red;
                    Txt_PrenomAA.Text = "Prenom Incorrect";
                }
                if (Txt_MDPAA.Text == "" || Txt_MDPAA.Text == "Mot de Passe")
                {
                    this.Txt_MDPAA.ForeColor = System.Drawing.Color.Red;
                    Txt_MDPAA.Text = "Mot de Passe Incorrect";
                }
                if (list_NationAA.Text == "")
                {
                    lbl_errNationAA.Visible = true;
                }
                else
                {
                    lbl_errNationAA.Visible = false;
                }
                if (rdn_HommeAA.Checked == false && rdn_FemmeAA.Checked == false)
                {
                    lbl_errSexAA.Visible = true;
                }
                else
                {
                    lbl_errSexAA.Visible = false;
                }
            }
        } 
        #endregion
    }
}
