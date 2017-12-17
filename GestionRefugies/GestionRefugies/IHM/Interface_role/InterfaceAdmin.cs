﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
        private List<Refugier> listeRefu = null;
        private List<User> listeUser = null;

        public Ajout(User connect_u)
        {
            InitializeComponent();
            connected_user = connect_u;
            label_nameU.Text = connected_user.Nom;

            if (connected_user.Roles.Magasinier == null) { label_MagaAccess.Text = "false"; } else { label_MagaAccess.Text = "true"; }
            if (connected_user.Roles.Agent == null) { label_AgentAccess.Text = "false"; } else { label_AgentAccess.Text = "true"; }
            if (connected_user.Roles.Adminnistrateur == null) { label_AdminAccess.Text = "false"; } else { label_AdminAccess.Text = "true"; }
        }


        private void AjoutRefugies_Load(object sender, EventArgs e)
        {

        }



        #region Maj des Champs et label_erreur


        private void Maj_champs_ajoutGerant()
        {
            Txt_MDPM.ForeColor = System.Drawing.SystemColors.WindowFrame;
            Txt_MDPM.Text = "Mot de Passe";
            Txt_NomM.ForeColor = System.Drawing.SystemColors.WindowFrame;
            Txt_NomM.Text = "Nom";
            Txt_PrenomM.ForeColor = System.Drawing.SystemColors.WindowFrame;
            Txt_PrenomM.Text = "Prenom";
            check_admin.Checked = false;
            check_AgentAccueil.Checked = false;
            check_Magasinier.Checked = false;
        }
        private void Maj_data_modifGerant()
        {
            dataGrid_modifgerant.Rows.Clear();
            listeUser = User.select();

            foreach (var user in listeUser)
            {
                dataGrid_modifgerant.Rows.Add(
                    user.Id,
                    user.Nom,
                    user.Prenom,
                    user.Roles.Adminnistrateur,
                    user.Roles.Agent,
                    user.Roles.Magasinier

                    );
            }
        }
        
        private void Maj_champs_modifGerant()
        {
            Txt_nom_modif_gerant.ForeColor = System.Drawing.SystemColors.WindowFrame;
            Txt_nom_modif_gerant.Text = "Nom";
            Txt_prenom_modif_gerant.ForeColor = System.Drawing.SystemColors.WindowFrame;
            Txt_prenom_modif_gerant.Text = "Prenom";
            txt_mdp_modif_ger.ForeColor = System.Drawing.SystemColors.WindowFrame;
            txt_mdp_modif_ger.Text = "Mot de Passe";
            check_AA_modif_gerant.Checked = false;
            check_Admin_modif_gerant.Checked = false;
            check_maga_modif_gerant.Checked = false;

        }
        private void Maj_labelerr_ajoutref()
        {
            Lbl_errSexe.Visible = false;
            Lbl_ErrNation.Visible = false;
            lbl_err_allerg_ajoutref.Visible = false;
            lbl_err_bless_ajoutref.Visible = false;
            lbl_err_coulchev_ajoutref.Visible = false;
            lbl_err_coulpeau_ajoutref.Visible = false;
            lbl_err_coulyeux_ajoutref.Visible = false;
            lbl_err_handi_ajoutref.Visible = false;
            lbl_err_typchev_ajoutref.Visible = false;
        }

        private void Maj_labelerr_modifref()
        {
            lbl_err_sex_modif_ref.Visible = false;
            lbl_err_nation_modif_ref.Visible = false;
            lbl_err_allerg_modifref.Visible = false;
            lbl_err_bless_modif_ref.Visible = false;
            lbl_err_coulpeau_modif_ref.Visible = false;
            lbl_err_coulchev_modif_ref.Visible = false;
            lbl_err_coulyeux_modif_ref.Visible = false;
            lbl_err_typchev_modif_ref.Visible = false;
            lbl_err_handi_modif_ref.Visible = false;
            lbl_err_champs_modifref.Visible = false;
            lbl_err_btn_modif_ref.Visible = false;
            lbl_errsupp_modif_ref.Visible = false;
        }

        private void Maj_Champs_modifref()
        {
            txt_allerg_modifref.Text = null;
            txt_autre_modifref.Text = null;
            txt_bless_modifref.Text = null;
            txt_coulchev_modifref.Text = null;
            txt_coulpeau_modifref.Text = null;
            txt_coulyeux_modifref.Text = null;
            txt_typchev_modifref.Text = null;
            txt_handi_modifref.Text = null;
            Txt_Prenom_Modifref.ForeColor = System.Drawing.SystemColors.WindowFrame;
            Txt_Prenom_Modifref.Text = "Prenom";
            Txt_Nom_Modifref.ForeColor = System.Drawing.SystemColors.WindowFrame;
            Txt_Nom_Modifref.Text = "Nom";
            list_nation_modif_ref.Text = null;
            rdn_Femme_Modif_ref.Checked = false;
            rdn_Homme_Modif_ref.Checked = false;
            DatePicker_Naiss_modif_ref.Value = new DateTime(1900, 01, 01);
            num_refugeref_modif_ref.Value = 0;
            num_taille_modifref.Value = 0;

        }

        private void Maj_Champs_ajoutref()
        {
            txt_typchev_ajoutref.Text = null;
            txt_allerg_ajoutref.Text = null;
            txt_autre_ajoutref.Text = null;
            txt_bless_ajoutref.Text = null;
            txt_coulchev_ajoutref.Text = null;
            txt_coulpeau_ajoutref.Text = null;
            txt_coulyeux_ajoutref.Text = null;
            txt_handi_ajoutref.Text = null;
            Txt_Prenom.ForeColor = System.Drawing.SystemColors.WindowFrame;
            Txt_Prenom.Text = "Prenom";
            Txt_Nom.ForeColor = System.Drawing.SystemColors.WindowFrame;
            Txt_Nom.Text = "Nom";
            List_Nationalite.Text = null;
            RdBtn_Femme.Checked = false;
            RdBtn_Homme.Checked = false;
            DatePicker_DatNaiss.Value = DateTime.Today;
            num_RefugeRef.Value = 1;
            num_taille_ajoutref.Value = 1;
        }

        private void Maj_data_modifRef()
        {
            DataGrid_modif_ref.Rows.Clear();
            listeRefu = Refugier.select();

            foreach (var refugier in listeRefu)
            {
                DataGrid_modif_ref.Rows.Add(
                    refugier.Id,
                    refugier.Nom,
                    refugier.Prenom,
                    refugier.Sexe,
                    refugier.DateNais,
                    refugier.Nationalite,
                    refugier.Adresse,
                    refugier.Taille,
                    refugier.CouleurPeau,
                    refugier.CouleurYeux,
                    refugier.CouleurCheveux,
                    refugier.TypeCheveux,
                    refugier.Blessure,
                    refugier.Allergie,
                    refugier.Handicap,
                    refugier.Autre

                    );
            }
        }
        #endregion
        

        #region tabPageAjoutRefugié

        #region Txt_Nom
        private void Txt_Nom_KeyUp(object sender, KeyEventArgs e)
        {

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
            

            if (txt_typchev_ajoutref.Text != "" &&
                txt_coulpeau_ajoutref.Text != "" &&
                txt_allerg_ajoutref.Text != "" &&
                txt_bless_ajoutref.Text != "" &&
                txt_coulchev_ajoutref.Text != "" &&
                txt_coulyeux_ajoutref.Text != "" &&
                txt_handi_ajoutref.Text != "" &&
                Txt_Nom.Text != "Nom" &&
                Txt_Nom.Text != "Nom Incorrect" &&
                Txt_Prenom.Text != "Prenom" &&
                Txt_Prenom.Text != "Prenom Incorrect" &&
                List_Nationalite.Text != "" &&
                (RdBtn_Femme.Checked == true || RdBtn_Homme.Checked == true))
            {
                String sex;
                if (RdBtn_Femme.Checked == true)
                {
                    sex = "F";
                }
                else
                {
                    sex = "M";
                }

                if (Refugier.add(new Refugier(Txt_Nom.Text, Txt_Prenom.Text, sex, DatePicker_DatNaiss.Value, List_Nationalite.Text, (int)num_RefugeRef.Value, (int)num_taille_ajoutref.Value, txt_coulpeau_ajoutref.Text, txt_coulchev_ajoutref.Text, txt_typchev_ajoutref.Text, txt_coulyeux_ajoutref.Text, txt_bless_ajoutref.Text, txt_allerg_ajoutref.Text, txt_handi_ajoutref.Text, txt_autre_ajoutref.Text)) == true)
                {
                    MessageBox.Show("Succes de l'ajout du refugié : " + Txt_Nom.Text + " " + Txt_Prenom.Text);
                    Maj_labelerr_ajoutref();
                    Maj_Champs_ajoutref();
                }
                else
                {
                    MessageBox.Show("Echec de l'Ajout du refugié");
                }

            }
            else
            {
                if (txt_typchev_ajoutref.Text == "")
                {
                    lbl_err_typchev_ajoutref.Visible = true;
                }
                else
                {
                    lbl_err_typchev_ajoutref.Visible = false;
                }
                if (txt_coulpeau_ajoutref.Text == "")
                {
                    lbl_err_coulpeau_ajoutref.Visible = true;
                }
                else
                {
                    lbl_err_coulpeau_ajoutref.Visible = false;
                }
                if (txt_allerg_ajoutref.Text == "")
                {
                    lbl_err_allerg_ajoutref.Visible = true;
                }
                else
                {
                    lbl_err_allerg_ajoutref.Visible = false;
                }
                if (txt_bless_ajoutref.Text == "")
                {
                    lbl_err_bless_ajoutref.Visible = true;
                }
                else
                {
                    lbl_err_bless_ajoutref.Visible = false;
                }
                if (txt_coulchev_ajoutref.Text == "")
                {
                    lbl_err_coulchev_ajoutref.Visible = true;
                }
                else
                {
                    lbl_err_coulchev_ajoutref.Visible = false;
                }
                if (txt_coulyeux_ajoutref.Text == "")
                {
                    lbl_err_coulyeux_ajoutref.Visible = true;
                }
                else
                {
                    lbl_err_coulyeux_ajoutref.Visible = false;
                }
                if (txt_handi_ajoutref.Text == "")
                {
                    lbl_err_handi_ajoutref.Visible = true;
                }
                else
                {
                    lbl_err_handi_ajoutref.Visible = false;
                }
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
                    Lbl_errSexe.Visible = true;
                }
                else
                {
                    Lbl_errSexe.Visible = false;
                }
            }
        }
        #endregion

        #region btn_reinit
        private void btn_reinit_ajoutref_Click(object sender, EventArgs e)
        {
            Maj_labelerr_ajoutref();
            Maj_Champs_ajoutref();
        }
        #endregion

        #region Datepicker_DateNaiss
        private void DatePicker_DatNaiss_ValueChanged(object sender, EventArgs e)
        {

            if (DatePicker_DatNaiss.Value >= DateTime.Today)
            {
                DatePicker_DatNaiss.Value = DateTime.Today;
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
            if (Txt_Nom_Modifref.Text == "Nom" || Txt_Nom_Modifref.Text == "Nom Incorrect")
            {
                this.Txt_Nom_Modifref.ForeColor = System.Drawing.Color.Black;
                Txt_Nom_Modifref.Text = "";
            }
        }

        private void Txt_Nom_Modif_ref_KeyUp(object sender, KeyEventArgs e)
        {
            if (Txt_Nom_Modifref.Text == "")
            {
                this.Txt_Nom_Modifref.ForeColor = System.Drawing.SystemColors.WindowFrame;
                Txt_Nom_Modifref.Text = "Nom";
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
            if (Txt_Prenom_Modifref.Text == "Prenom" || Txt_Prenom_Modifref.Text == "Prenom Incorrect")
            {
                this.Txt_Prenom_Modifref.ForeColor = System.Drawing.Color.Black;
                Txt_Prenom_Modifref.Text = "";
            }
        }

        private void Txt_Prenom_Modif_ref_KeyUp(object sender, KeyEventArgs e)
        {
            if (Txt_Prenom_Modifref.Text == "")
            {
                this.Txt_Prenom_Modifref.ForeColor = System.Drawing.SystemColors.WindowFrame;
                Txt_Prenom_Modifref.Text = "Prenom";
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

        #region Les labels d'erreurs
        private void list_nation_modif_ref_TextChanged(object sender, EventArgs e)
        {
            lbl_err_nation_modif_ref.Visible = false;
        }

        private void txt_coulpeau_modifref_TextChanged(object sender, EventArgs e)
        {
            lbl_err_coulpeau_modif_ref.Visible = false;
        }

        private void txt_coulchev_modifref_TextChanged(object sender, EventArgs e)
        {
            lbl_err_coulchev_modif_ref.Visible = false;
        }

        private void txt_coulyeux_modifref_TextChanged(object sender, EventArgs e)
        {
            lbl_err_coulyeux_modif_ref.Visible = false;
        }

        private void txt_bless_modifref_TextChanged(object sender, EventArgs e)
        {
            lbl_err_bless_modif_ref.Visible = false;
        }

        private void txt_typchev_modifref_TextChanged(object sender, EventArgs e)
        {
            lbl_err_typchev_modif_ref.Visible = false;
        }

        private void txt_allerg_modifref_TextChanged(object sender, EventArgs e)
        {
            lbl_err_allerg_modifref.Visible = false;
        }

        private void txt_handi_modifref_TextChanged(object sender, EventArgs e)
        {
            lbl_err_handi_modif_ref.Visible = false;
        }
        private void rdn_Femme_Modif_ref_CheckedChanged(object sender, EventArgs e)
        {
            lbl_err_sex_modif_ref.Visible = false;
        }

        private void rdn_Homme_Modif_ref_CheckedChanged(object sender, EventArgs e)
        {
            lbl_err_sex_modif_ref.Visible = false;
        }

        #endregion


        #region Boutons Reinitialiser Rechercher Modifier et Supprimer refugié

        #region btn_reinit
        private void btn_reinit_modifref_Click(object sender, EventArgs e)
        {
            Maj_Champs_modifref();
            Maj_labelerr_modifref();
            Maj_data_modifRef();
        }
        #endregion


        #region btn recherche
        private void btn_rechercher_modifref_Click(object sender, EventArgs e)
        {
            DataGrid_modif_ref.Rows.Clear();

            String sex, nom, prenom;

            if (Txt_Nom_Modifref.Text == "Nom" | Txt_Nom_Modifref.Text == "Nom Incorrect")
            {
                nom = "";
            }
            else
            {
                nom = Txt_Nom_Modifref.Text;
            }

            if (Txt_Prenom_Modifref.Text == "Prenom" | Txt_Prenom_Modifref.Text == "Prenom Incorrect")
            {
                prenom = "";
            }
            else
            {
                prenom = Txt_Prenom_Modifref.Text;
            }

            if (rdn_Femme_Modif_ref.Checked == true)
            {
                sex = "F";
            }
            else
            {
                if (rdn_Homme_Modif_ref.Checked == true)
                {
                    sex = "M";
                }
                else
                {
                    sex = "";
                }
            }

            //appel recherche de josselin
           listeRefu = Refugier.Rechercher(Refugier.select(), nom, prenom, sex, DatePicker_Naiss_modif_ref.Value, list_nation_modif_ref.Text, (int)num_refugeref_modif_ref.Value, (int)num_taille_modifref.Value, txt_coulpeau_modifref.Text, txt_coulchev_modifref.Text, txt_typchev_modifref.Text, txt_coulyeux_modifref.Text, txt_bless_modifref.Text, txt_allerg_modifref.Text, txt_handi_modifref.Text, txt_autre_modifref.Text);

            foreach (var refugier in listeRefu)
            {
                DataGrid_modif_ref.Rows.Add(
                    refugier.Id,
                    refugier.Nom,
                    refugier.Prenom,
                    refugier.Sexe,
                    refugier.DateNais,
                    refugier.Nationalite,
                    refugier.Adresse,
                    refugier.Taille,
                    refugier.CouleurPeau,
                    refugier.CouleurYeux,
                    refugier.CouleurCheveux,
                    refugier.TypeCheveux,
                    refugier.Blessure,
                    refugier.Allergie,
                    refugier.Handicap,
                    refugier.Autre

                    );
            }

        }
        #endregion

        #region btn_modifref
        private void btn_Modif_ref_Click(object sender, EventArgs e)
        {
            lbl_err_btn_modif_ref.Visible = false;

            if ((txt_allerg_modifref.Text != "" && txt_bless_modifref.Text != "" && txt_coulchev_modifref.Text != "" && txt_coulpeau_modifref.Text != "" && txt_coulyeux_modifref.Text != "" && txt_handi_modifref.Text != "" && txt_typchev_modifref.Text != "" && Txt_Nom_Modifref.Text != "Nom" && Txt_Nom_Modifref.Text != "Nom Incorrect" && Txt_Prenom_Modifref.Text != "Prenom" && Txt_Prenom_Modifref.Text != "Prenom Incorrect" && list_nation_modif_ref.Text != "" && (rdn_Homme_Modif_ref.Checked == true || rdn_Femme_Modif_ref.Checked == true)))
            {

                lbl_err_champs_modifref.Visible = false;

                String sex;
                if (rdn_Femme_Modif_ref.Checked == true)
                {
                    sex = "F";
                }
                else
                {
                    sex = "M";
                }
                if (DataGrid_modif_ref.SelectedRows.Count == 1)
                {

                    foreach (System.Windows.Forms.DataGridViewRow refugier in DataGrid_modif_ref.SelectedRows)
                    {
                        var result = MessageBox.Show("Voulez vous vraiment modifier l'utilisateur " + refugier.Cells[1].Value + " " + refugier.Cells[2].Value, " ", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                            if ((Refugier.update(new Refugier(Txt_Nom_Modifref.Text, Txt_Prenom_Modifref.Text, sex, DatePicker_Naiss_modif_ref.Value, list_nation_modif_ref.Text, (int)num_refugeref_modif_ref.Value, (int)num_taille_modifref.Value, txt_coulpeau_modifref.Text, txt_coulchev_modifref.Text, txt_typchev_modifref.Text, txt_coulyeux_modifref.Text, txt_bless_modifref.Text, txt_allerg_modifref.Text, txt_handi_modifref.Text, txt_autre_modifref.Text, int.Parse(refugier.Cells[0].Value.ToString()))) == true))
                            {
                                MessageBox.Show("Modification Effectuée");
                                Maj_labelerr_modifref();
                                Maj_data_modifRef();
                                Maj_Champs_modifref();
                            }
                            else
                            {
                                MessageBox.Show("Echec de la modification");
                            }
                    }
                }
                else
                {
                    lbl_err_btn_modif_ref.Visible = true;
                }

            }
            else
            {
                if (DataGrid_modif_ref.SelectedRows.Count != 1)
                {
                    lbl_err_btn_modif_ref.Visible = true;
                }

                lbl_err_champs_modifref.Visible = true;

                if (txt_allerg_modifref.Text == "")
                {
                    lbl_err_allerg_modifref.Visible = true;
                }
                else
                {
                    lbl_err_allerg_modifref.Visible = false;
                }
                if (txt_coulpeau_modifref.Text == "")
                {
                    lbl_err_coulpeau_modif_ref.Visible = true;
                }
                else
                {
                    lbl_err_coulpeau_modif_ref.Visible = false;
                }
                if (txt_bless_modifref.Text == "")
                {
                    lbl_err_bless_modif_ref.Visible = true;
                }
                else
                {
                    lbl_err_bless_modif_ref.Visible = false;
                }
                if (txt_coulchev_modifref.Text == "")
                {
                    lbl_err_coulchev_modif_ref.Visible = true;
                }
                else
                {
                    lbl_err_coulchev_modif_ref.Visible = false;
                }
                if (txt_coulyeux_modifref.Text == "")
                {
                    lbl_err_coulyeux_modif_ref.Visible = true;
                }
                else
                {
                    lbl_err_coulyeux_modif_ref.Visible = false;
                }
                if (txt_handi_modifref.Text == "")
                {
                    lbl_err_handi_modif_ref.Visible = true;
                }
                else
                {
                    lbl_err_handi_modif_ref.Visible = false;
                }
                if (txt_typchev_modifref.Text == "")
                {
                    lbl_err_typchev_modif_ref.Visible = true;
                }
                else
                {
                    lbl_err_typchev_modif_ref.Visible = false;
                }
                if (Txt_Nom_Modifref.Text == "" || Txt_Nom_Modifref.Text == "Nom")
                {
                    this.Txt_Nom_Modifref.ForeColor = System.Drawing.Color.Red;
                    Txt_Nom_Modifref.Text = "Nom Incorrect";
                }
                if (Txt_Prenom_Modifref.Text == "" || Txt_Prenom_Modifref.Text == "Prenom")
                {
                    this.Txt_Prenom_Modifref.ForeColor = System.Drawing.Color.Red;
                    Txt_Prenom_Modifref.Text = "Prenom Incorrect";
                }
                if (list_nation_modif_ref.Text == "")
                {
                    lbl_err_nation_modif_ref.Visible = true;
                }
                else
                {
                    lbl_err_nation_modif_ref.Visible = false;
                }
                if (rdn_Homme_Modif_ref.Checked == false && rdn_Femme_Modif_ref.Checked == false)
                {
                    lbl_err_sex_modif_ref.Visible = true;
                }
                else
                {
                    lbl_err_sex_modif_ref.Visible = false;
                }

            }
        }
        #endregion

        #region supp-ref
        private void btn_Suppr_ref_Click(object sender, EventArgs e)
        {

            if (DataGrid_modif_ref.SelectedRows.Count == 0)
            {
                lbl_errsupp_modif_ref.Visible = true;
            }
            else
            {
                lbl_errsupp_modif_ref.Visible = false;

                if (DataGrid_modif_ref.SelectedRows.Count > 1)
                {
                    var result = MessageBox.Show("Voulez vous vraiment supprimer les " + DataGrid_modif_ref.SelectedRows.Count + " refugiés ? ", " ", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        foreach (System.Windows.Forms.DataGridViewRow refugier in DataGrid_modif_ref.SelectedRows)
                        {
                            if (Refugier.delete((int.Parse(refugier.Cells[0].Value.ToString()))) == true)
                            {
                                Maj_data_modifRef();
                            }
                        }
                    }
                }
                else
                {
                    foreach (System.Windows.Forms.DataGridViewRow refugier in DataGrid_modif_ref.SelectedRows)
                    {
                        var result = MessageBox.Show("Voulez vous vraiment supprimer l'utilisateur " + refugier.Cells[1].Value + " " + refugier.Cells[2].Value, " ", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {

                            if (Refugier.delete((int.Parse(refugier.Cells[0].Value.ToString()))) == true)
                            {
                                Maj_data_modifRef();
                            }
                        }
                    }
                }
            }
        }

        #endregion

        #endregion

        #endregion
        

        #region Se qui se passe au load des pages


        #region Maj des données 
        /// <summary>
        /// remet a jour les données et labels des tabpages lorqu'on clique dessus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControl1.SelectedTab == tabPageModifRef)
            {

                Maj_data_modifRef();
                Maj_labelerr_modifref();
                Maj_Champs_modifref();

            }

            if (tabControl1.SelectedTab == tabPageAjoutRef)
            {
                Maj_labelerr_ajoutref();
                Maj_Champs_ajoutref();
            }

            if (tabControl1.SelectedTab == tabPagemodifGerant)
            {
                Maj_champs_modifGerant();
                Maj_data_modifGerant();
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
            
            if ((check_AgentAccueil.Checked || check_Magasinier.Checked || check_admin.Checked) && 
                Txt_NomM.Text != "Nom" && 
                Txt_NomM.Text != "Nom Incorrect" && 
                Txt_PrenomM.Text != "Prenom" && 
                Txt_PrenomM.Text != "Prenom Incorrect" && 
                Txt_MDPM.Text != "Mot de passe" && 
                Txt_MDPM.Text != "Mot de passe Incorrect")
            {


                if (check_admin.Checked)
                {
                    if (check_AgentAccueil.Checked && check_Magasinier.Checked)
                    {
                        if (User.add(new User(Txt_NomM.Text, Txt_PrenomM.Text, Txt_MDPM.Text, true, true, true)))
                        {
                            MessageBox.Show("Success");
                        }
                        else
                        {
                            MessageBox.Show("Fail");
                        }
                    }
                    else if (check_AgentAccueil.Checked && !(check_Magasinier.Checked))
                    {
                        if (User.add(new User(Txt_NomM.Text, Txt_PrenomM.Text, Txt_MDPM.Text, true, true, false)))
                        {
                            MessageBox.Show("Success");
                        }
                        else
                        {
                            MessageBox.Show("Fail");
                        }
                    }
                    else if (!(check_AgentAccueil.Checked) && check_Magasinier.Checked)
                    {
                        if (User.add(new User(Txt_NomM.Text, Txt_PrenomM.Text, Txt_MDPM.Text, true, false, true)))
                        {
                            MessageBox.Show("Success");
                        }
                        else
                        {
                            MessageBox.Show("Fail");
                        }
                    }
                    else
                    {
                        if (User.add(new User(Txt_NomM.Text, Txt_PrenomM.Text, Txt_MDPM.Text, true, false, false)))
                        {
                            MessageBox.Show("Success");
                        }
                        else
                        {
                            MessageBox.Show("Fail");
                        }
                    }
                }
                else
                {
                    if (check_AgentAccueil.Checked && check_Magasinier.Checked)
                    {
                        if (User.add(new User(Txt_NomM.Text, Txt_PrenomM.Text, Txt_MDPM.Text, false, true, true)))
                        {
                            MessageBox.Show("Success");
                        }
                        else
                        {
                            MessageBox.Show("Fail");
                        }
                    }
                    else if (check_AgentAccueil.Checked && !(check_Magasinier.Checked))
                    {
                        if (User.add(new User(Txt_NomM.Text, Txt_PrenomM.Text, Txt_MDPM.Text, false, true, false)))
                        {
                            MessageBox.Show("Success");
                        }
                        else
                        {
                            MessageBox.Show("Fail");
                        }
                    }
                    else if (!(check_AgentAccueil.Checked) && check_Magasinier.Checked)
                    {
                        if (User.add(new User(Txt_NomM.Text, Txt_PrenomM.Text, Txt_MDPM.Text, false, false, true)))
                        {
                            MessageBox.Show("Success");
                        }
                        else
                        {
                            MessageBox.Show("Fail");
                        }
                    }
                    else
                    {
                        if (User.add(new User(Txt_NomM.Text, Txt_PrenomM.Text, Txt_MDPM.Text, false, false, false)))
                        {
                            MessageBox.Show("Success");
                        }
                        else
                        {
                            MessageBox.Show("Fail");

                        }
                    }
                }
                
               

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
                if (!check_AgentAccueil.Checked && !check_Magasinier.Checked && !check_admin.Checked)
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

        #region btn_reinit
        private void btn_reinit_ajoutgerant_Click(object sender, EventArgs e)
        {
            Maj_champs_ajoutGerant();
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



        #region Boutons reinitialiser/ rechercher,Modifier et Supprimer gerant

        private void btn_reinit_modifGerant_Click(object sender, EventArgs e)
        {
            Maj_data_modifGerant();
            Maj_champs_modifGerant();
        }

        private void btn_recherche_modif_user_Click(object sender, EventArgs e)
        {
            listeUser = User.Rechercher(User.select(), Txt_nom_modif_gerant.Text, Txt_prenom_modif_gerant.Text, check_Admin_modif_gerant.Checked, check_maga_modif_gerant.Checked, check_AA_modif_gerant.Checked);

            foreach (var user in listeUser)
            {
                DataGrid_modif_ref.Rows.Add(
                    
                    user.Nom,
                    user.Prenom,
                    user.Roles.Adminnistrateur,
                    user.Roles.Agent,
                    user.Roles.Magasinier
                    

                    );
            }
        }

        private void btn_modif_gerant_Click(object sender, EventArgs e)
        {
            
            if ((Txt_nom_modif_gerant.Text != "Nom" && Txt_nom_modif_gerant.Text != "Nom Incorrect" && Txt_prenom_modif_gerant.Text != "Prenom" && Txt_prenom_modif_gerant.Text != "Prenom Incorrect"))
            {
                if (dataGrid_modifgerant.SelectedRows.Count == 1)
                {

                    foreach (System.Windows.Forms.DataGridViewRow user in dataGrid_modifgerant.SelectedRows)
                    {
                        var result = MessageBox.Show("Voulez vous vraiment modifier l'utilisateur " + user.Cells[1].Value + " " + user.Cells[2].Value, " ", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            if (check_Admin_modif_gerant.Checked)
                            {
                                if (check_AA_modif_gerant.Checked && check_maga_modif_gerant.Checked)
                                {
                                    if ((User.update(new User(Txt_Nom_Modifref.Text, Txt_Prenom_Modifref.Text, txt_mdp_modif_ger.Text, true, true, true))))
                                    {
                                        MessageBox.Show("Modification Effectuée");
                                        Maj_data_modifGerant();
                                    }
                                }
                                else if (!(check_AA_modif_gerant.Checked) && check_maga_modif_gerant.Checked)
                                {
                                    if ((User.update(new User(Txt_Nom_Modifref.Text, Txt_Prenom_Modifref.Text, txt_mdp_modif_ger.Text, true, false, true))))
                                    {
                                        MessageBox.Show("Modification Effectuée");
                                        Maj_data_modifGerant();
                                    }
                                }
                                else if (check_AA_modif_gerant.Checked && !(check_maga_modif_gerant.Checked))
                                {
                                    if ((User.update(new User(Txt_Nom_Modifref.Text, Txt_Prenom_Modifref.Text, txt_mdp_modif_ger.Text, true, true, false))))
                                    {
                                        MessageBox.Show("Modification Effectuée");
                                        Maj_data_modifGerant();
                                    }
                                }
                                else if (!(check_AA_modif_gerant.Checked) && !(check_maga_modif_gerant.Checked))
                                {
                                    if ((User.update(new User(Txt_Nom_Modifref.Text, Txt_Prenom_Modifref.Text, txt_mdp_modif_ger.Text, true, false, false))))
                                    {
                                        MessageBox.Show("Modification Effectuée");
                                        Maj_data_modifGerant();
                                    }
                                }

                            }
                            else
                            {
                                if (check_AA_modif_gerant.Checked && check_maga_modif_gerant.Checked)
                                {
                                    if ((User.update(new User(Txt_Nom_Modifref.Text, Txt_Prenom_Modifref.Text, txt_mdp_modif_ger.Text, false, true, true))))
                                    {
                                        MessageBox.Show("Modification Effectuée");
                                        Maj_data_modifGerant();
                                    }
                                }
                                else if (!(check_AA_modif_gerant.Checked) && check_maga_modif_gerant.Checked)
                                {
                                    if ((User.update(new User(Txt_Nom_Modifref.Text, Txt_Prenom_Modifref.Text, txt_mdp_modif_ger.Text, false, false, true))))
                                    {
                                        MessageBox.Show("Modification Effectuée");
                                        Maj_data_modifGerant();
                                    }
                                }
                                else if (check_AA_modif_gerant.Checked && !(check_maga_modif_gerant.Checked))
                                {
                                    if ((User.update(new User(Txt_Nom_Modifref.Text, Txt_Prenom_Modifref.Text, txt_mdp_modif_ger.Text, false, true, false))))
                                    {
                                        MessageBox.Show("Modification Effectuée");
                                        Maj_data_modifGerant();
                                    }
                                }
                                else if (!(check_AA_modif_gerant.Checked) && !(check_maga_modif_gerant.Checked))
                                {
                                    if ((User.update(new User(Txt_Nom_Modifref.Text, Txt_Prenom_Modifref.Text, txt_mdp_modif_ger.Text, false, false, false))))
                                    {
                                        MessageBox.Show("Modification Effectuée");
                                        Maj_data_modifGerant();
                                    }
                                }
                            }
                        }


                    }
                }
            }
            else
            {
                if (Txt_nom_modif_gerant.Text == "" || Txt_nom_modif_gerant.Text == "Nom")
                {
                    this.Txt_nom_modif_gerant.ForeColor = System.Drawing.Color.Red;
                    Txt_nom_modif_gerant.Text = "Nom Incorrect";
                }
                if (Txt_prenom_modif_gerant.Text == "" || Txt_prenom_modif_gerant.Text == "Prenom")
                {
                    this.Txt_prenom_modif_gerant.ForeColor = System.Drawing.Color.Red;
                    Txt_prenom_modif_gerant.Text = "Prenom Incorrect";
                }

            }

        }

        private void btn_suppr_gerant_Click(object sender, EventArgs e)
        {
            foreach (System.Windows.Forms.DataGridViewRow user in dataGrid_modifgerant.SelectedRows)
            {
                var result = MessageBox.Show("Voulez vous vraiment supprimer l'utilisateur " + user.Cells[1].Value + " " + user.Cells[2].Value, " ", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (User.delete((user.Cells[0].Value.ToString())) == true)
                    {
                        MessageBox.Show("Suppression Effectuée");
                        Maj_data_modifGerant();

                    }

                }

            }

        }
        #endregion

        #endregion



        #region restrictions
        private void tabControl1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Check Credentials Here

            if ((connected_user.Roles.Adminnistrateur == null))
            {

                //save de la page selectionné avant les test
                TabPage selectPage = new TabPage();
                selectPage = tabControl1.SelectedTab;

                //test des droit d'accée de l'individu
                if ((connected_user.Roles.Agent == null) && ((tabControl1.SelectedTab == tabPageAjoutRef) || (tabControl1.SelectedTab == tabPageModifRef)))
                {
                    tabControl1.SelectedTab = tabPageAccueil;
                    MessageBox.Show("Unable to load tab. You have insufficient access privileges.");
                }

                if (tabControl1.SelectedTab == tabPageAjoutGérant)
                {
                    tabControl1.SelectedTab = tabPageAccueil;
                    MessageBox.Show("Unable to load tab. You have insufficient access privileges.");

                }
                if (tabControl1.SelectedTab == tabPagemodifGerant)
                {
                    tabControl1.SelectedTab = tabPageAccueil;
                    MessageBox.Show("Unable to load tab. You have insufficient access privileges.");

                }
                if ((connected_user.Roles.Magasinier == null) && (tabControl1.SelectedTab == tabPageStock))
                {
                    tabControl1.SelectedTab = tabPageAccueil;
                    MessageBox.Show("Unable to load tab. You have insufficient access privileges.");

                }


            }


        }











        #endregion

        private void deconnect_Click(object sender, EventArgs e)
        {
            var disconnect_res = MessageBox.Show("Voulez vous vraiment vous déconnecter ?"," ", MessageBoxButtons.YesNo);
            if (disconnect_res == DialogResult.Yes)
            {
                this.Close();
            }

        }
    }

}
