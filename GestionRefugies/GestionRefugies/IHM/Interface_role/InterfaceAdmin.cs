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
        
        private User connected_user;
        
        public Ajout(User connect_u)
        {
            InitializeComponent();
            connected_user = connect_u;
            label_nameU.Text = connected_user.Nom;

            if(connected_user.Roles.Magasinier == null) { label_MagaAccess.Text = "false"; } else { label_MagaAccess.Text = "true"; }
            if(connected_user.Roles.Agent == null) { label_AgentAccess.Text = "false"; } else { label_AgentAccess.Text = "true"; }
            if(connected_user.Roles.Adminnistrateur == null) { label_AdminAccess.Text = "false"; } else { label_AdminAccess.Text = "true"; }
        }

        
        private void AjoutRefugies_Load(object sender, EventArgs e)
        {
            
        }

        #region tabPageAjoutRefugié

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
        
        #region tabPageAjoutGerant
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
            if ((check_AgentAccueil.Checked || check_Magasinier.Checked) && Txt_NomM.Text != "Nom" && Txt_NomM.Text != "Nom Incorrect" && Txt_PrenomM.Text != "Prenom" && Txt_PrenomM.Text != "Prenom Incorrect" && Txt_MDPM.Text != "Mot de passe" && Txt_MDPM.Text != "Mot de passe Incorrect" && list_NationM.Text != "" && (rdn_FemmeM.Checked == true || rdn_HommeM.Checked == true))
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
                //if (check_AgentAccueil.Checked && check_Magasinier.Checked)
                //{

                //}
                //else if (check_AgentAccueil.Checked)
                //{

                //}
                //else
                //{

                //}


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
                if (!check_AgentAccueil.Checked && !check_Magasinier.Checked)
                {
                    lbl_errRole.Visible = true;
                }
                else
                {
                    lbl_errRole.Visible = false;
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

        #region tabPageModif/Suppr_Ref

        #region Txt_nom_modif_ref
        private void Txt_Nom_Modif_ref_KeyDown(object sender, KeyEventArgs e)
        {
            // si on appuie sur un numero ou un caractere special => on supprime l'evenement 
            if (e.KeyValue >= 96 && e.KeyValue <= 105 || e.KeyValue == 49 || e.KeyValue >= 51 && e.KeyValue <= 53 || e.KeyValue == 56 || e.KeyValue == 106 || e.KeyValue == 107 || e.KeyValue == 110 || e.KeyValue == 111)
            {
                e.SuppressKeyPress = true;
            }
            if (Txt_Nom_Modif_ref.Text == "Nom" || Txt_Nom_Modif_ref.Text == "Nom Incorrect")
            {
                this.Txt_Nom_Modif_ref.ForeColor = System.Drawing.Color.Black;
                Txt_Nom_Modif_ref.Text = "";
            }
        }

        private void Txt_Nom_Modif_ref_KeyUp(object sender, KeyEventArgs e)
        {
            if (Txt_Nom_Modif_ref.Text == "")
            {
                this.Txt_Nom_Modif_ref.ForeColor = System.Drawing.SystemColors.WindowFrame;
                Txt_Nom_Modif_ref.Text = "Nom";
            }
        }

        #endregion
        
        #region Txt-premon_modif_ref
        private void Txt_Prenom_Modif_ref_KeyDown(object sender, KeyEventArgs e)
        {
            // si on appuie sur un numero ou un caractere special => on supprime l'evenement 
            if (e.KeyValue >= 96 && e.KeyValue <= 105 || e.KeyValue == 49 || e.KeyValue >= 51 && e.KeyValue <= 53 || e.KeyValue == 56 || e.KeyValue == 106 || e.KeyValue == 107 || e.KeyValue == 110 || e.KeyValue == 111)
            {
                e.SuppressKeyPress = true;
            }
            if (Txt_Prenom_Modif_ref.Text == "Prenom" || Txt_Prenom_Modif_ref.Text == "Prenom Incorrect")
            {
                this.Txt_Prenom_Modif_ref.ForeColor = System.Drawing.Color.Black;
                Txt_Prenom_Modif_ref.Text = "";
            }
        }

        private void Txt_Prenom_Modif_ref_KeyUp(object sender, KeyEventArgs e)
        {
            if (Txt_Prenom_Modif_ref.Text == "")
            {
                this.Txt_Prenom_Modif_ref.ForeColor = System.Drawing.SystemColors.WindowFrame;
                Txt_Prenom_Modif_ref.Text = "Prenom";
            }
        }
        #endregion
        
        #region DatePicker_Naiss_modif_ref
        private void DatePicker_Naiss_modif_ref_ValueChanged(object sender, EventArgs e)
        {
            if (DatePicker_Naiss_modif_ref.Value >= DateTime.Now)
            {
                DatePicker_Naiss_modif_ref.Value = DateTime.Now;
            }
        }
        #endregion
        

        #region Boutons Modifier et Supprimer refugié
        private void btn_Modif_ref_Click(object sender, EventArgs e)
        {
            // appel fonction update ref
        }

        private void btn_Suppr_ref_Click(object sender, EventArgs e)
        {
            //appelfonction delete refugié
        }

        #endregion

        #endregion

        #region tabpageModif/Suppr_Gerant

        #region Txt_nom_modif_gerant
        private void Txt_nom_modif_gerant_KeyDown(object sender, KeyEventArgs e)
        {
            // si on appuie sur un numero ou un caractere special => on supprime l'evenement 
            if (e.KeyValue >= 96 && e.KeyValue <= 105 || e.KeyValue == 49 || e.KeyValue >= 51 && e.KeyValue <= 53 || e.KeyValue == 56 || e.KeyValue == 106 || e.KeyValue == 107 || e.KeyValue == 110 || e.KeyValue == 111)
            {
                e.SuppressKeyPress = true;
            }
            if (Txt_nom_modif_gerant.Text == "Nom" || Txt_nom_modif_gerant.Text == "Nom Incorrect")
            {
                this.Txt_nom_modif_gerant.ForeColor = System.Drawing.Color.Black;
                Txt_nom_modif_gerant.Text = "";
            }
        }

        private void Txt_nom_modif_gerant_KeyUp(object sender, KeyEventArgs e)
        {
            if (Txt_nom_modif_gerant.Text == "")
            {
                this.Txt_nom_modif_gerant.ForeColor = System.Drawing.SystemColors.WindowFrame;
                Txt_nom_modif_gerant.Text = "Nom";
            }
        }
        #endregion

        #region  Txt_prenom_modif_gerant
        private void Txt_prenom_modif_gerant_KeyDown(object sender, KeyEventArgs e)
        {
            // si on appuie sur un numero ou un caractere special => on supprime l'evenement 
            if (e.KeyValue >= 96 && e.KeyValue <= 105 || e.KeyValue == 49 || e.KeyValue >= 51 && e.KeyValue <= 53 || e.KeyValue == 56 || e.KeyValue == 106 || e.KeyValue == 107 || e.KeyValue == 110 || e.KeyValue == 111)
            {
                e.SuppressKeyPress = true;
            }
            if (Txt_prenom_modif_gerant.Text == "Prenom" || Txt_prenom_modif_gerant.Text == "Prenom Incorrect")
            {
                this.Txt_prenom_modif_gerant.ForeColor = System.Drawing.Color.Black;
                Txt_prenom_modif_gerant.Text = "";
            }
        }

        private void Txt_prenom_modif_gerant_KeyUp(object sender, KeyEventArgs e)
        {
            if (Txt_prenom_modif_gerant.Text == "")
            {
                this.Txt_prenom_modif_gerant.ForeColor = System.Drawing.SystemColors.WindowFrame;
                Txt_prenom_modif_gerant.Text = "Prenom";
            }
        }
        #endregion

        #region datePicker_Naiss_modif_gerant
        private void datePicker_Naiss_modif_gerant_ValueChanged(object sender, EventArgs e)
        {
            if (datePicker_Naiss_modif_gerant.Value >= DateTime.Now)
            {
                datePicker_Naiss_modif_gerant.Value = DateTime.Now;
            }
        }
        #endregion

        #region Boutons Modifier et Supprimer gerant
        private void btn_modif_gerant_Click(object sender, EventArgs e)
        {

        }

        private void btn_suppr_gerant_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #endregion


        private void tabControl1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Check Credentials Here

            if( (connected_user.Roles.Adminnistrateur == null))
            {

                //save de la page selectionné avant les test
                TabPage selectPage = new TabPage();
                selectPage = tabControl1.SelectedTab;

                //test des droit d'accée de l'individu
                if ((connected_user.Roles.Agent == null) && ( (tabControl1.SelectedTab == tabPageAjoutRef) || (tabControl1.SelectedTab == tabPageAjoutGérant) || (tabControl1.SelectedTab == tabPagemodifGerant) || (tabControl1.SelectedTab == tabPageModifRef) ) )
                {
                    tabControl1.SelectedTab = tabPageAccueil;
                    MessageBox.Show("Unable to load tab. You have insufficient access privileges.");
                }
                else
                {
                    tabControl1.SelectedTab = selectPage;
                }

                if ((connected_user.Roles.Magasinier == null) && (tabControl1.SelectedTab == tabPageStock))
                {
                    tabControl1.SelectedTab = tabPageAccueil;
                    MessageBox.Show("Unable to load tab. You have insufficient access privileges.");
                }
            }

            
        }

        private void label_nameU_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Refugier> refugiers = new List<Refugier>();
            string sexe;
            if (radioButton1.Checked)
            {
                sexe = "homme";
            }
            else if (radioButton2.Checked)
            {
                sexe = "femme";
            }
            else { sexe = " ? "; }
            refugiers = Rechercher(refugiers, maskedTextBox1.Text, maskedTextBox2.Text, sexe,dateTimePicker1.Value, comboBox2.SelectedItem);
            int i = 1;
            foreach ( Refugier refugier in refugiers)
            {
                dataGridView1.Rows.Add(i,refugier.Nom , refugier.Prenom, refugier.Nationalite, refugier.Sexe, refugier.Adresse, refugier.DateNais );
                i++;
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
